using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Checks : Form
    {
        // Строка подключения к вашей БД
        private string connectionString =
            @"Server=DESKTOP-4GVGGCH,1433;Database=SupermarketDB;Integrated Security=True;TrustServerCertificate=True;";

        public Checks()
        {
            InitializeComponent();

            LoadChecks();
        }

        // Загрузка списка чеков в таблицу
        private void LoadChecks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            Чек.Номер_чека      AS [Номер чека],
                            Кассир.ФИО_кассира  AS [Кассир],
                            Чек.Тип_оплаты      AS [Оплата],
                            Чек.Дата_продажи    AS [Дата],
                            Чек.Время_продажи   AS [Время]
                        FROM Чек
                        INNER JOIN Кассир ON Чек.Код_кассира = Кассир.Код_кассира
                        ORDER BY Чек.Дата_продажи DESC, Чек.Время_продажи DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки таблицы: " + ex.Message);
            }
        }

        // Обработчик кнопки "Печать чека"
        private void print_check_b_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли строка
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выделите нужный чек в таблице!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Берем данные из выделенной строки
            int checkId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Номер чека"].Value);
            string cashierName = dataGridView1.CurrentRow.Cells["Кассир"].Value.ToString();
            string payType = dataGridView1.CurrentRow.Cells["Оплата"].Value.ToString();
            string dateStr = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Дата"].Value).ToString("dd.MM.yyyy");
            string timeStr = dataGridView1.CurrentRow.Cells["Время"].Value.ToString();

            string checkText = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT Товар.Название, Товары_в_чеке.Количество_товара, Товар.Цена,
                               (Товары_в_чеке.Количество_товара * Товар.Цена) AS Сумма
                        FROM Товары_в_чеке
                        JOIN Товар ON Товары_в_чеке.Номер_товара = Товар.Номер_товара
                        WHERE Товары_в_чеке.Номер_чека = @Id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", checkId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Формируем шапку чека
                    checkText += "      ООО \"СУПЕРМАРКЕТ\"\n";
                    checkText += "     г. Москва, ул. Ленина, 1\n";
                    checkText += "--------------------------------\n";
                    checkText += $"ЧЕК №{checkId}\n";
                    checkText += $"Дата: {dateStr}  Время: {timeStr}\n";
                    checkText += $"Кассир: {cashierName}\n";
                    checkText += "--------------------------------\n";
                    checkText += "Товар            Кол-во   Сумма\n";
                    checkText += "--------------------------------\n";

                    decimal total = 0;

                    // Читаем товары
                    while (reader.Read())
                    {
                        string name = reader["Название"].ToString();

                        // Обрезаем слишком длинные названия
                        if (name.Length > 16) name = name.Substring(0, 16);

                        decimal qty = Convert.ToDecimal(reader["Количество_товара"]);
                        decimal sum = Convert.ToDecimal(reader["Сумма"]);
                        total += sum;

                        // Форматируем строку: имя (16 симв), кол-во (4), сумма (7 с двумя знаками)
                        checkText += $"{name,-16} {qty,-8:F2} {sum,7:F2}\n";
                    }

                    checkText += "--------------------------------\n";
                    checkText += $"ИТОГО:                 {total,7:F2} руб.\n";
                    checkText += $"Тип оплаты: {payType}\n";
                    checkText += "--------------------------------\n";
                    checkText += "       СПАСИБО ЗА ПОКУПКУ!\n";
                    checkText += "         ЖДЕМ ВАС СНОВА";
                }

                // Показываем результат
                MessageBox.Show(checkText, "Ваш чек", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при формировании чека: " + ex.Message);
            }
        }
    }
}