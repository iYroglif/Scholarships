﻿using System;
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
    public partial class Меню__студент_ : Form
    {
        static string mybdpath;
        public Меню__студент_(string bdpath)
        {
            mybdpath = bdpath;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Редактирование_данных_о_студенте newForm = new Редактирование_данных_о_студенте(mybdpath);
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
