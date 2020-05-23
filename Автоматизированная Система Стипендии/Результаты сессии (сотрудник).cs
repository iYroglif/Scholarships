using System;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Автоматизированная_Система_Стипендии
{
    public partial class Результаты_сессии__сотрудник_ : Form
    {
        static List<string[]> authDate = new List<string[]>();
        static string mybdpath;
        public Результаты_сессии__сотрудник_(string bdpath)
        {
            mybdpath = bdpath;
            InitializeComponent();
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mybdpath;
            OleDbConnection connection = new OleDbConnection(conStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM [Результаты сессии]", connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Update(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            bindingNavigator1.BindingSource = bs;
            //dataGridView1.DataSource = bs;
            textBox1.DataBindings.Add(new Binding("Text", bs, "ID", true));

            connection = new OleDbConnection(conStr);
            adapter = new OleDbDataAdapter();
            connection.Open();
            command = new OleDbCommand("SELECT Фамилия, Имя, Отчество, Группы.Группа FROM Студенты INNER JOIN Группы ON Группы.ID = Студенты.[ID группы] WHERE Студенты.[ID сессии] = " + textBox1.Text.ToString(), connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataTable dtt = new DataTable();
            adapter.Fill(dtt);
            adapter.Update(dtt);
            BindingSource bss = new BindingSource();
            bss.DataSource = dtt;
            //bindingNavigator1.BindingSource = bss;
            dataGridView1.DataSource = bss;
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            Меню__сотрудник_ newForm = new Меню__сотрудник_(mybdpath);
            newForm.Show();
            Close();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mybdpath;
            OleDbConnection connection = new OleDbConnection(conStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command;

            connection = new OleDbConnection(conStr);
            adapter = new OleDbDataAdapter();
            connection.Open();
            command = new OleDbCommand("SELECT Фамилия, Имя, Отчество, Группы.Группа FROM Студенты INNER JOIN Группы ON Группы.ID = Студенты.[ID группы] WHERE Студенты.[ID сессии] = " + textBox1.Text.ToString(), connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataTable dtt = new DataTable();
            adapter.Fill(dtt);
            adapter.Update(dtt);
            BindingSource bss = new BindingSource();
            bss.DataSource = dtt;
            //bindingNavigator1.BindingSource = bss;
            dataGridView1.DataSource = bss;
        }
    }
}
