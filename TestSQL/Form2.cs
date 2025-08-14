using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSQL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            UserNameBox.Text = "Введите имя";
            UserSerNameBox.Text = "Введите фамилию";
            UserSerNameBox.ForeColor = Color.Gray;
            UserNameBox.ForeColor = Color.Gray;

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            RegistrBuuton.ForeColor = Color.Green;
        }

        private void closeClick_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                passwordBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
            }
        }

        private void RegistrBuuton_MouseLeave(object sender, EventArgs e)
        {
            RegistrBuuton.ForeColor = Color.White;
        }

        private void UserNameBox_Enter(object sender, EventArgs e)
        {
            if(UserNameBox.Text == "Введите имя")
            {
                UserNameBox.Text = "";
                UserNameBox.ForeColor = Color.Black;
            }
        }

        private void UserNameBox_Leave(object sender, EventArgs e)
        {
            if(UserNameBox.Text == "")
            {
                UserNameBox.Text = "Введите имя";
                UserNameBox.ForeColor = Color.Gray;
            }
        }

        private void UserSerNameBox_Enter(object sender, EventArgs e)
        {
            if (UserSerNameBox.Text == "Введите фамилию")
            {
                UserSerNameBox.Text = "";
                UserSerNameBox.ForeColor = Color.Black;
            }
        }

        private void UserSerNameBox_Leave(object sender, EventArgs e)
        {
            if (UserSerNameBox.Text == "")
            {
                UserSerNameBox.Text = "Введите фамилию";
                UserSerNameBox.ForeColor = Color.Gray;
            }
        }

        private void RegistrBuuton_Click(object sender, EventArgs e)
        {
            int a = 0; //test
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`lastname`, `firstname`, `login`, `password`) VALUES (@firstname, @lastname, @log, @password)", dB.getConnection());
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = UserNameBox.Text;
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = loginBox.Text;
            command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = UserSerNameBox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordBox.Text;

            dB.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан!");
            }
            else
            {
                MessageBox.Show("Произошла ошибка!");
            }


            dB.closeConnection();   
        }
    }
}
