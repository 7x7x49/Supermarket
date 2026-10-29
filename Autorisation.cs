using System;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            InitializeComponent();
        }

        // Кнопка "Войти"
        private void enter_b_Click(object sender, EventArgs e)
        {
            // Если хоть одно поле пустое — ошибка
            if (string.IsNullOrWhiteSpace(login_tb.Text) ||
                string.IsNullOrWhiteSpace(password_tb.Text))
            {
                MessageBox.Show("Поле не заполнено", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide(); // прячем окно входа
        }

        // Кнопка "Завершить работу"
        private void exit_b_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}