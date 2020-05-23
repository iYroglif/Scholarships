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
    public partial class Группы : Form
    {
        static List<string[]> authDate = new List<string[]>();
        static string mybdpath;
        public Группы(string bdpath)
        {
            mybdpath = bdpath;
            InitializeComponent();
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mybdpath;
            OleDbConnection connection = new OleDbConnection(conStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT Группы.ID, Группы.Группа, Кафедры.Кафедра FROM Группы INNER JOIN Кафедры ON Группы.[ID кафедры] = Кафедры.ID", connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Update(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.DataSource = bs;
            textBox3.DataBindings.Add(new Binding("Text", bs, "ID", true));
            textBox2.DataBindings.Add(new Binding("Text", bs, "Группа", true));
            ArrayList row = new ArrayList();
            foreach (DataRow dr in dt.Rows)
            {
                if (!row.Contains(dr["Кафедра"].ToString()))
                {
                    row.Add(dr["Кафедра"].ToString());
                }
            }
            comboBox2.Items.AddRange(row.ToArray());
            comboBox2.DataBindings.Add(new Binding("Text", bs, "Кафедра", true));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ввод__просмотр_и_редактирование_данных newForm = new Ввод__просмотр_и_редактирование_данных(mybdpath);
            newForm.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Группы_Студенты newForm = new Группы_Студенты(mybdpath, textBox3.Text.ToString());
            newForm.Show();
            Close();
        }
    }
}
