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
    public partial class Редактирование_данных_о_студенте : Form
    {
        static List<string[]> authDate = new List<string[]>();
        static string mybdpath;
        public Редактирование_данных_о_студенте(string bdpath)
        {
            mybdpath = bdpath;
            InitializeComponent();
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mybdpath;
            OleDbConnection connection = new OleDbConnection(conStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM Студенты", connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Update(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            bindingNavigator1.BindingSource = bs;
            //dataGridView1.DataSource = bs;

            connection = new OleDbConnection(conStr);
            adapter = new OleDbDataAdapter();
            connection.Open();
            command = new OleDbCommand("SELECT [Зачисление стипендии].[Номер транзакции], [Зачисление стипендии].Дата, Студенты.[Лицевой счет], [Виды стипендий].[Стипендия в рублях] FROM (([Зачисление стипендии] INNER JOIN Студенты ON Студенты.[ID студента] = [Зачисление стипендии].[ID студента]) INNER JOIN [Виды стипендий] ON [Виды стипендий].ID = [Зачисление стипендии].[ID стипендии]) WHERE Студенты.Фамилия = 'Терентьев'", connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataTable dtt = new DataTable();
            adapter.Fill(dtt);
            adapter.Update(dtt);
            BindingSource bss = new BindingSource();
            bss.DataSource = dtt;
            //bindingNavigator1.BindingSource = bss;
            dataGridView2.DataSource = bss;
        }

        private void Студенты_Load(object sender, EventArgs e)
        {

        }
    }
}
