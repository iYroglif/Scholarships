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
    public partial class Меню__сотрудник_ : Form
    {
        static string mybdpath;
        public Меню__сотрудник_(string bdpath)
        {
            mybdpath = bdpath;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Зачисление_стипендий newForm = new Зачисление_стипендий(mybdpath);
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Результаты_сессии newForm = new Результаты_сессии(mybdpath);
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
