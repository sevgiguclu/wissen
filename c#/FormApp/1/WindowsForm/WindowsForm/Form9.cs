using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            textBox1.Enter += ChangeBackColor;
            textBox2.Enter += ChangeBackColor;
            textBox3.Enter += ChangeBackColor;
            textBox4.Enter += ChangeBackColor;

            textBox1.Leave += ChangeBackCOlorDefault;
            textBox2.Leave += ChangeBackCOlorDefault;
            textBox3.Leave += ChangeBackCOlorDefault;
            textBox4.Leave += ChangeBackCOlorDefault;
        }

        private void ChangeBackCOlorDefault(object? sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;
        }

        private void ChangeBackColor(object? sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.Aqua;
        }

        //private void textBox1_Enter(object sender, EventArgs e)
        //{
        //    textBox1.BackColor = Color.Aqua;
        //}

        //private void textBox1_Leave(object sender, EventArgs e)
        //{
        //    textBox1.BackColor = Color.White;
        //}

        //private void textBox2_Enter(object sender, EventArgs e)
        //{
        //    textBox2.BackColor = Color.Aqua;
        //}

        //private void textBox2_Leave(object sender, EventArgs e)
        //{
        //    textBox2.BackColor = Color.White;
        //}
    }
}
