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
    public partial class Зачисление_стипендий : Form
    {
        static List<string[]> authDate = new List<string[]>();
        static string mybdpath;
        public Зачисление_стипендий(string bdpath)
        {
            mybdpath = bdpath;
            InitializeComponent();
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mybdpath;
            OleDbConnection connection = new OleDbConnection(conStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT [Зачисление стипендии].[Номер транзакции], [Зачисление стипендии].Дата, Студенты.[Лицевой счет], Студенты.Фамилия, [Виды стипендий].Название, [Виды стипендий].[Стипендия в рублях] FROM ([Зачисление стипендии] INNER JOIN Студенты ON Студенты.[ID студента] = [Зачисление стипендии].[ID студента]) INNER JOIN [Виды стипендий] ON [Виды стипендий].ID = [Зачисление стипендии].[ID стипендии] ORDER BY [Зачисление стипендии].Дата", connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Update(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.DataSource = bs;
            textBox1.DataBindings.Add(new Binding("Text", bs, "Стипендия в рублях", true));
            textBox2.DataBindings.Add(new Binding("Text", bs, "Номер транзакции", true));
            textBox3.DataBindings.Add(new Binding("Text", bs, "Дата", true));

            ArrayList row = new ArrayList();
            foreach (DataRow dr in dt.Rows) {
                row.Add(dr["Фамилия"].ToString());
            }
            comboBox1.Items.AddRange(row.ToArray());
            comboBox1.DataBindings.Add(new Binding("Text", bs, "Фамилия", true));

            row = new ArrayList();
            foreach (DataRow dr in dt.Rows)
            {
                row.Add(dr["Лицевой счет"].ToString());
            }
            comboBox2.Items.AddRange(row.ToArray());
            comboBox2.DataBindings.Add(new Binding("Text", bs, "Лицевой счет", true));

            row = new ArrayList();
            foreach (DataRow dr in dt.Rows)
            {
                row.Add(dr["Название"].ToString());
            }
            comboBox3.Items.AddRange(row.ToArray());
            comboBox3.DataBindings.Add(new Binding("Text", bs, "Название", true));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ввод__просмотр_и_редактирование_данных newForm = new Ввод__просмотр_и_редактирование_данных(mybdpath);
            newForm.Show();
            Close();
        }
    }
}
