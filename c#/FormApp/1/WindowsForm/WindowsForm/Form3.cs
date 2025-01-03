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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtGirilenMetin.MaxLength = 200;
            lblKalanKarakter.Text = txtGirilenMetin.MaxLength.ToString();
        }

        private void txtGirilenMetin_TextChanged(object sender, EventArgs e)
        {
            int kacKarakterVar = txtGirilenMetin.Text.Length;
            int kalanKarakter = txtGirilenMetin.MaxLength - kacKarakterVar;

            lblKalanKarakter.Text = kalanKarakter.ToString();

            if(kalanKarakter <= 20)
            {
                lblKalanKarakter.ForeColor = Color.Red;
                lblKalanKarakter.Font = new Font(lblKalanKarakter.Font, FontStyle.Bold);
            }
            else
            {
                lblKalanKarakter.ForeColor = Color.Black;
                lblKalanKarakter.Font = new Font(lblKalanKarakter.Font, FontStyle.Regular);
            }
        }
    }
}
