using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Employees : Form
    {
        // Строка подключения к БД
        private string connectionString =
            @"Server=DESKTOP-4GVGGCH,1433;Database=SupermarketDB;Integrated Security=True;TrustServerCertificate=True;";

        // Адаптер и таблица на уровне класса для доступа из кнопок
        private SqlDataAdapter adapter;
        private DataTable table;

        public Employees()
        {
            InitializeComponent();

            // Настройки DataGridView для добавления/удаления строк
            dataGridView3.ReadOnly = false;
            dataGridView3.AllowUserToAddRows = true;
            dataGridView3.AllowUserToDeleteRows = true;

            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Код_кассира, ФИО_кассира, Должность FROM Кассир ORDER BY Код_кассира";

                    adapter = new SqlDataAdapter(query, conn);
                    table = new DataTable();
                    adapter.Fill(table);

                    // Привязка данных к DataGridView
                    dataGridView3.DataSource = table;

                    // Переименование заголовков столбцов
                    dataGridView3.Columns["Код_кассира"].HeaderText = "Код";
                    dataGridView3.Columns["ФИО_кассира"].HeaderText = "ФИО";
                    dataGridView3.Columns["Должность"].HeaderText = "Должность";
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка загрузки: " + ex.Message); }
        }

        private void applyEmpl_b_Click(object sender, EventArgs e)
        {
            if (table == null) return;

            // Принудительно завершаем редактирование текущей ячейки, 
            // чтобы введенные данные точно попали в DataTable
            dataGridView3.EndEdit();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Создаем новый адаптер для отправки изменений
                    SqlDataAdapter updateAdapter = new SqlDataAdapter("SELECT Код_кассира, ФИО_кассира, Должность FROM Кассир", conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(updateAdapter);

                    // Явная привязка команд для генерации INSERT/UPDATE/DELETE
                    updateAdapter.InsertCommand = builder.GetInsertCommand();
                    updateAdapter.UpdateCommand = builder.GetUpdateCommand();
                    updateAdapter.DeleteCommand = builder.GetDeleteCommand();

                    // Синхронизация изменений с БД
                    updateAdapter.Update(table);

                    MessageBox.Show("Изменения сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Перезагрузка таблицы для актуализации данных
                    LoadEmployees();
                }
            }
            catch (SqlException ex)
            {
                // Обработка конкретных ошибок SQL Server
                if (ex.Number == 547) // Нарушение внешнего ключа (FOREIGN KEY)
                    MessageBox.Show("Удаление невозможно: у сотрудника есть пробитые чеки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (ex.Number == 2627) // Нарушение PRIMARY KEY (дубликат)
                    MessageBox.Show("Сотрудник с таким Кодом уже существует! Введите другой ID.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (ex.Number == 515) // Попытка вставить NULL в обязательное поле
                    MessageBox.Show("Не забудьте вписать Код (ID) для нового сотрудника!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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