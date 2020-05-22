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
    public partial class Отчет_Социальные_признаки : Form
    {
        public Отчет_Социальные_признаки()
        {
            InitializeComponent();
        }

        private void Отчет_Студенты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "АС_СтипендииDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.СтудентыTableAdapter.Fill(this.АС_СтипендииDataSet.Студенты);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Отчеты newForm = new Отчеты();
            newForm.Show();
            Close();
        }
    }
}
