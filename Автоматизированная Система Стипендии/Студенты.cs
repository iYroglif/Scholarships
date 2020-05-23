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
    public partial class Студенты : Form
    {
        static BindingSource bs, bss;
        static OleDbDataAdapter adapter;
        static DataTable dt;
        static List<string[]> authDate = new List<string[]>();
        static string mybdpath;
        public Студенты(string bdpath)
        {
            mybdpath = bdpath;
            InitializeComponent();
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mybdpath;
            OleDbConnection connection = new OleDbConnection(conStr);
            adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM ((Студенты INNER JOIN [Результаты сессии] ON [Результаты сессии].ID = Студенты.[ID сессии]) INNER JOIN [Социальные признаки] ON [Социальные признаки].ID = Студенты.[ID социальный]) INNER JOIN Группы ON Группы.ID = Студенты.[ID группы]", connection);
            connection.Close();
            adapter.SelectCommand = command;
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Update(dt);
            bs = new BindingSource();
            bs.DataSource = dt;
            //bindingNavigator1.BindingSource = bs;
            //dataGridView1.DataSource = bs;
            /*
            textBox1.DataBindings.Add(new Binding("Text", bs, "ID студента", true));
            textBox2.DataBindings.Add(new Binding("Text", bs, "Лицевой счет", true));
            textBox3.DataBindings.Add(new Binding("Text", bs, "Фамилия", true));
            textBox4.DataBindings.Add(new Binding("Text", bs, "Имя", true));
            textBox5.DataBindings.Add(new Binding("Text", bs, "Отчество", true));
            textBox6.DataBindings.Add(new Binding("Text", bs, "Курс", true));
            textBox7.DataBindings.Add(new Binding("Text", bs, "Телефон", true));
            */

            ArrayList row = new ArrayList();
            foreach (DataRow dr in dt.Rows)
            {
                if (!row.Contains(dr["Сессия закрыта на"].ToString()))
                {
                    row.Add(dr["Сессия закрыта на"].ToString());
                }
            }
            comboBox1.Items.AddRange(row.ToArray());
            comboBox1.DataBindings.Add(new Binding("Text", bs, "Сессия закрыта на", true));

            row = new ArrayList();
            foreach (DataRow dr in dt.Rows)
            {
                if (!row.Contains(dr["Социальный признак"].ToString()))
                {
                    row.Add(dr["Социальный признак"].ToString());
                }
            }
            comboBox2.Items.AddRange(row.ToArray());
            comboBox2.DataBindings.Add(new Binding("Text", bs, "Социальный признак", true));

            row = new ArrayList();
            foreach (DataRow dr in dt.Rows)
            {
                if (!row.Contains(dr["Группа"].ToString()))
                {
                    row.Add(dr["Группа"].ToString());
                }
            }
            comboBox3.Items.AddRange(row.ToArray());
            comboBox3.DataBindings.Add(new Binding("Text", bs, "Группа", true));

            connection = new OleDbConnection(conStr);
            adapter = new OleDbDataAdapter();
            connection.Open();
            command = new OleDbCommand("SELECT [Зачисление стипендии].[Номер транзакции], [Зачисление стипендии].Дата, Студенты.[Лицевой счет], [Виды стипендий].[Стипендия в рублях] FROM (([Зачисление стипендии] INNER JOIN Студенты ON Студенты.[ID студента] = [Зачисление стипендии].[ID студента]) INNER JOIN [Виды стипендий] ON [Виды стипендий].ID = [Зачисление стипендии].[ID стипендии]) WHERE Студенты.[ID студента] = " + textBox1.Text.ToString(), connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataTable dtt = new DataTable();
            adapter.Fill(dtt);
            adapter.Update(dtt);
            bss = new BindingSource();
            bss.DataSource = dtt;
            //bindingNavigator1.BindingSource = bss;
            dataGridView2.DataSource = bss;
        }

        private void Студенты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аС_СтипендииDataSet2.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.аС_СтипендииDataSet2.Студенты);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Ввод__просмотр_и_редактирование_данных newForm = new Ввод__просмотр_и_редактирование_данных(mybdpath);
            newForm.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            студентыTableAdapter.Update(аС_СтипендииDataSet2);
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.аС_СтипендииDataSet2);
            MessageBox.Show(
        "Данные сохранены",
        "Сообщение",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = "Convert ([Фамилия],'System.String') LIKE '" + textBox8.Text.ToString() + "%'";
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
            command = new OleDbCommand("SELECT [Зачисление стипендии].[Номер транзакции], [Зачисление стипендии].Дата, Студенты.[Лицевой счет], [Виды стипендий].[Стипендия в рублях] FROM (([Зачисление стипендии] INNER JOIN Студенты ON Студенты.[ID студента] = [Зачисление стипендии].[ID студента]) INNER JOIN [Виды стипендий] ON [Виды стипендий].ID = [Зачисление стипендии].[ID стипендии]) WHERE Студенты.[ID студента] = " + textBox1.Text.ToString(), connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataTable dtt = new DataTable();
            adapter.Fill(dtt);
            adapter.Update(dtt);
            bss = new BindingSource();
            bss.DataSource = dtt;
            //bindingNavigator1.BindingSource = bss;
            dataGridView2.DataSource = bss;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "31";
            comboBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
    }
}
