using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Providers : Form
    {
        private string connectionString =
            @"Server=DESKTOP-4GVGGCH,1433;Database=SupermarketDB;Integrated Security=True;TrustServerCertificate=True;";

        private SqlDataAdapter adapter;
        private DataTable table;

        public Providers()
        {
            InitializeComponent();

            // Настройки DataGridView для добавления/удаления строк
            dataGridView2.ReadOnly = false;
            dataGridView2.AllowUserToAddRows = true;
            dataGridView2.AllowUserToDeleteRows = true;

            LoadProviders();
        }

        private void LoadProviders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Код_поставщика, Название, Адрес, Телефон FROM Поставщик ORDER BY Название";

                    adapter = new SqlDataAdapter(query, conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    table = new DataTable();
                    adapter.Fill(table);

                    dataGridView2.DataSource = table;

                    // Настройка заголовков
                    dataGridView2.Columns["Код_поставщика"].HeaderText = "Код";
                    dataGridView2.Columns["Название"].HeaderText = "Название";
                    dataGridView2.Columns["Адрес"].HeaderText = "Адрес";
                    dataGridView2.Columns["Телефон"].HeaderText = "Телефон";

                    dataGridView2.Columns["Код_поставщика"].ReadOnly = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка загрузки: " + ex.Message); }
        }

        // Обработчик кнопки "Применить" (applyProv_b)
        private void applyProv_b_Click(object sender, EventArgs e)
        {
            if (table == null) return;

            // Фиксируем ввод из ячейки
            dataGridView2.EndEdit();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlDataAdapter updateAdapter = new SqlDataAdapter("SELECT Код_поставщика, Название, Адрес, Телефон FROM Поставщик", conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(updateAdapter);

                    updateAdapter.InsertCommand = builder.GetInsertCommand();
                    updateAdapter.UpdateCommand = builder.GetUpdateCommand();
                    updateAdapter.DeleteCommand = builder.GetDeleteCommand();

                    updateAdapter.Update(table);

                    MessageBox.Show("Изменения сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProviders();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("Удаление невозможно: у поставщика есть оформленные поставки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (ex.Number == 2627)
                    MessageBox.Show("Поставщик с таким Кодом уже существует! Введите другой ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (ex.Number == 515)
                    MessageBox.Show("Не забудьте вписать Код (ID) для нового поставщика!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Ошибка БД: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
