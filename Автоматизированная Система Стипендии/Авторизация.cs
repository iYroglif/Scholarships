using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Автоматизированная_Система_Стипендии
{
    public partial class Авторизация : Form
    {
        static List<string[]> authDate = new List<string[]>();
        static string mybdpath;
        public Авторизация()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            /*
            Меню__администратор_ newForm = new Меню__администратор_(mybdpath);
            newForm.Show();
            */
            //
            if (comboBox1.SelectedItem != null)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Администратор":
                        for (int i = 0; i < authDate.Count(); i++)
                        {
                            if (authDate[i][0] == "Администратор")
                            {
                                if (textBox1.Text.ToString() == authDate[i][1]) 
                                {
                                    Меню__администратор_ menuForm = new Меню__администратор_(mybdpath);
                                    menuForm.Show();
                                    Hide();
                                }
                                else MessageBox.Show("Неверный пароль", "Ошибка");
                            }
                        }
                        break;
                    case "Сотрудник":
                        for (int i = 0; i < authDate.Count(); i++)
                        {
                            if (authDate[i][0] == "Сотрудник")
                            {
                                if (textBox1.Text.ToString() == authDate[i][1])
                                {
                                    Меню__сотрудник_ menuForm = new Меню__сотрудник_(mybdpath);
                                    menuForm.Show();
                                    Hide();
                                }
                                else MessageBox.Show("Неверный пароль", "Ошибка");
                            }
                        }
                        break;
                    case "Студент":
                        for (int i = 0; i < authDate.Count(); i++)
                        {
                            if (authDate[i][0] == "Студент")
                            {
                                if (textBox1.Text.ToString() == authDate[i][1]) 
                                {
                                    Меню__студент_ menuForm = new Меню__студент_(mybdpath);
                                    menuForm.Show();
                                    Hide();
                                }
                                else MessageBox.Show("Неверный пароль", "Ошибка");
                            }
                        }
                        break;
                    default:
                        MessageBox.Show("Пользователь не найден. Выберите существующего пользователя", "Ошибка");
                        break;
                }
            } else MessageBox.Show("Выберите пользователя", "Ошибка");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            FileInfo fileInf = new FileInfo(openFileDialog1.FileName);
            textBox2.Text = fileInf.FullName;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            authDate = new List<string[]>();
            comboBox1.Items.Clear();
            mybdpath = textBox2.Text;
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mybdpath;
            OleDbConnection connection = new OleDbConnection(conStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT *FROM `Группы пользователей`;", connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string[] temp = new string[2];
                    temp[0] = reader[1].ToString();
                    temp[1] = reader[2].ToString();
                    authDate.Add(temp);
                    comboBox1.Items.Add(temp[0]);
                }
                reader.Close();
                connection.Close();
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            О_Автоматизированной_системе menuForm = new О_Автоматизированной_системе();
            menuForm.ShowDialog();
        }
    }
}
