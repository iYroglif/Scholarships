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
    public partial class Ввод__просмотр_и_редактирование_данных : Form
    {
        static string mybdpath;
        public Ввод__просмотр_и_редактирование_данных(string bdpath)
        {
            mybdpath = bdpath;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Студенты newForm = new Студенты(mybdpath);
            newForm.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Группы newForm = new Группы(mybdpath);
            newForm.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Кафедры newForm = new Кафедры(mybdpath);
            newForm.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Факультеты newForm = new Факультеты(mybdpath);
            newForm.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Результаты_сессии newForm = new Результаты_сессии(mybdpath);
            newForm.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Социальные_признаки newForm = new Социальные_признаки(mybdpath);
            newForm.Show();
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Зачисление_стипендий newForm = new Зачисление_стипендий(mybdpath);
            newForm.Show();
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Виды_стипендий newForm = new Виды_стипендий(mybdpath);
            newForm.Show();
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Меню__администратор_ newForm = new Меню__администратор_(mybdpath);
            newForm.Show();
            Close();
        }
    }
}
