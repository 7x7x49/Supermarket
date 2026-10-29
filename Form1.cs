using System;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Кнопка "Назад" — возврат к окну авторизации
        private void back_b_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Autorisation)
                {
                    f.Show();
                    break;
                }
            }
            this.Close();
        }

        // Кнопка "Сотрудники" — открыть форму Employees
        private void empl_b_Click(object sender, EventArgs e)
        {
            Employees form = new Employees();
            form.Show();
        }

        // Кнопка "Поставщики" — открыть форму Providers
        private void providers_b_Click(object sender, EventArgs e)
        {
            Providers form = new Providers();
            form.Show();
        }

        // Кнопка "Чеки" — открыть форму Checks
        private void checks_b_Click(object sender, EventArgs e)
        {
            Checks form = new Checks();
            form.Show();
        }
    }
}