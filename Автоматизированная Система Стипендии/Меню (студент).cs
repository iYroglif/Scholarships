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
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Авторизация newForm = new Авторизация();
            newForm.Show();
            Close();
        }

        private void Меню__студент__Load(object sender, EventArgs e)
        {

        }

        private void Меню__студент__FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
