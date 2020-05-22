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
    public partial class Отчеты : Form
    {
        //static string mybdpath;
        public Отчеты(/*string bdpath*/)
        {
            //mybdpath = bdpath;
            InitializeComponent();
        }

        private void Отчеты_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Отчет_Студенты newForm = new Отчет_Студенты();
            newForm.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Отчет_Результаты_сессии newForm = new Отчет_Результаты_сессии();
            newForm.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Отчет_Социальные_признаки newForm = new Отчет_Социальные_признаки();
            newForm.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Отчет_Студенты_отличники newForm = new Отчет_Студенты_отличники();
            newForm.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Отчет_Выплаты_стипендий_студента newForm = new Отчет_Выплаты_стипендий_студента();
            newForm.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Отчет_Виды_стипендий newForm = new Отчет_Виды_стипендий();
            newForm.Show();
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Отчет_Сумма_зачисленных_стипендий_по_месяцам newForm = new Отчет_Сумма_зачисленных_стипендий_по_месяцам();
            newForm.Show();
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Отчет_Сумма_зачисленных_стипендий_по_факультетам newForm = new Отчет_Сумма_зачисленных_стипендий_по_факультетам();
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
