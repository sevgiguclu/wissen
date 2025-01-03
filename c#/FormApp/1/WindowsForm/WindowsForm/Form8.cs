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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        int sayac = 1;
        private void btnButunEkle_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Width = 150;
            btn.Height = 40;

            Random rnd = new Random();
            int btnX = rnd.Next(0, this.ClientSize.Width - btn.Width);
            btn.Left = btnX;

            int btnY = rnd.Next(0,this.ClientSize.Height - btn.Height);
            btn.Top = btnY;

            btn.Text = sayac.ToString();
            sayac++;

            //btn.Click += new EventHandler(btn_Click);
            btn.Click += btn_Click;

            this.Controls.Add(btn);
        }

        private void btn_Click(object? sender, EventArgs e)
        {
            Button btn = ((Button)sender);
            MessageBox.Show(btn.Text);
        }
    }
}
