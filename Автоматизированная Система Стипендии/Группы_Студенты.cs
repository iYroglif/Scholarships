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
    public partial class Группы_Студенты : Form
    {
        static List<string[]> authDate = new List<string[]>();
        static string mybdpath;
        public Группы_Студенты(string bdpath)
        {
            mybdpath = bdpath;
            InitializeComponent();
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mybdpath;
            OleDbConnection connection = new OleDbConnection(conStr);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT Студенты.[ID студента], Студенты.Фамилия, Студенты.Имя, Студенты.Отчество, [Результаты сессии].[Сессия закрыта на], [Социальные признаки].[Социальный признак] FROM ((Студенты INNER JOIN [Результаты сессии] ON [Результаты сессии].[ID] = Студенты.[ID сессии]) INNER JOIN [Социальные признаки] ON [Социальные признаки].[ID] = Студенты.[ID социальный]) WHERE Студенты.[ID группы] = 1", connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Update(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.DataSource = bs;
        }

        private void Группы_Студенты_Load(object sender, EventArgs e)
        {

        }
    }
}
