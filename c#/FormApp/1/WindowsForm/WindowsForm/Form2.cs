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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtMetin_TextChanged(object sender, EventArgs e)
        {
            //TextBox'ın içine herhangi bir metin yazıldığında anlık olarak Label'ın içinede o metin aktarılsın
            lblMetin.Text = txtMetin.Text.Trim();
        }

        private void txtMetin_MouseEnter(object sender, EventArgs e)
        {
            txtMetin.BackColor = Color.Coral;
            txtMetin.ForeColor = Color.Blue;
        }

        private void txtMetin_MouseLeave(object sender, EventArgs e)
        {
            txtMetin.BackColor = Color.White;
            txtMetin.ForeColor = Color.Black;
        }
    }
}
