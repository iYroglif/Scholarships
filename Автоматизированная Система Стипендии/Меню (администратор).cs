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
    }
}
