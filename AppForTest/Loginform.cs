using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace AppForTest
{
    public partial class Loginform : Form
    {
        dbfortestEntities dbfortestEntities = new dbfortestEntities();
        public static int points = 0;

        public Loginform()
        {
            InitializeComponent();

        }


        // Внешние настройки для кнопки входа
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(230, 70, 0);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 128, 0);
        }
        // -----------------------------------------


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                MessageBox.Show("Вы не ввели логин");
            }
            Infoform f = new Infoform();
            var passwordg = from a in dbfortestEntities.users
                            where a.login == textBoxLogin.Text
                            select a.password;
            string y = passwordg.First().ToString();

            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Вы не ввели пароль");
            }
            else 
            {
                if (y.Contains(textBoxPassword.Text))
                {

                    MessageBox.Show("Пользователь есть в БД");
                    this.Hide();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Пользователя нет в системе");
                }

            }


        }

    }
}
