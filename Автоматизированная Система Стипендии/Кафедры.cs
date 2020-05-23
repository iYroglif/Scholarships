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
    public partial class Кафедры : Form
    {
        static BindingSource bs, bss;
        static OleDbDataAdapter adapter;
        static DataTable dt;
        static List<string[]> authDate = new List<string[]>();
        static string mybdpath;
        public Кафедры(string bdpath)
        {
            mybdpath = bdpath;
            InitializeComponent();
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mybdpath;
            OleDbConnection connection = new OleDbConnection(conStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM (Кафедры INNER JOIN Факультеты ON Кафедры.[ID факультета] = Факультеты.ID)", connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Update(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            bindingNavigator1.BindingSource = bs;
            //dataGridView1.DataSource = bs;
            textBox1.DataBindings.Add(new Binding("Text", bs, "Кафедры.ID", true));
            textBox2.DataBindings.Add(new Binding("Text", bs, "Кафедры.Кафедра", true));
            ArrayList row = new ArrayList();
            foreach (DataRow dr in dt.Rows)
            {
                if (!row.Contains(dr["Факультет"].ToString()))
                {
                    row.Add(dr["Факультет"].ToString());
                }
            }
            comboBox2.Items.AddRange(row.ToArray());
            comboBox2.DataBindings.Add(new Binding("Text", bs, "Факультет", true));
            
            connection = new OleDbConnection(conStr);
            adapter = new OleDbDataAdapter();
            connection.Open();
            command = new OleDbCommand("SELECT ID, Группа FROM Группы WHERE Группы.[ID кафедры] = " + textBox1.Text.ToString(), connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataTable dtt = new DataTable();
            adapter.Fill(dtt);
            adapter.Update(dtt);
            bss = new BindingSource();
            bss.DataSource = dtt;
            //bindingNavigator1.BindingSource = bss;
            dataGridView1.DataSource = bss;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ввод__просмотр_и_редактирование_данных newForm = new Ввод__просмотр_и_редактирование_данных(mybdpath);
            newForm.Show();
            Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = "Convert ([Кафедры.Кафедра],'System.String') LIKE '%" + textBox8.Text.ToString() + "%'";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mybdpath;
            OleDbConnection connection = new OleDbConnection(conStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command;

            connection = new OleDbConnection(conStr);
            adapter = new OleDbDataAdapter();
            connection.Open();
            command = new OleDbCommand("SELECT ID, Группа FROM Группы WHERE Группы.[ID кафедры] = " + textBox1.Text.ToString(), connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataTable dtt = new DataTable();
            adapter.Fill(dtt);
            adapter.Update(dtt);
            bss = new BindingSource();
            bss.DataSource = dtt;
            //bindingNavigator1.BindingSource = bss;
            dataGridView1.DataSource = bss;
        }
    }
}
