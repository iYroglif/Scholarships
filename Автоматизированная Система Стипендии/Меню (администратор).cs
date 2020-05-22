using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Автоматизированная_Система_Стипендии
{
    public partial class Меню__администратор_ : Form
    {
        static string mybdpath;
        public Меню__администратор_(string bdpath)
        {
            mybdpath = bdpath;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ввод__просмотр_и_редактирование_данных newForm = new Ввод__просмотр_и_редактирование_данных(mybdpath);
            newForm.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Отчеты newForm = new Отчеты(/*mybdpath*/);
            newForm.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Авторизация newForm = new Авторизация();
            newForm.Show();
            Close();
        }
    }
}
