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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string[] arabalar = { "BMW", "Volvo", "Toyota", "Kia", "Honda", "Fiat", "Tesla", "Hyundai", "VW", "Renault", "Peugeout", "Suzuki", "Tofaş" };

        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            string sonEleman = arabalar[arabalar.Length - 1];
            MessageBox.Show(sonEleman, "Son Eleman", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rastgeleSayi = rnd.Next(0, arabalar.Length);
            string rastgeleEleman = arabalar[rastgeleSayi];
            MessageBox.Show(rastgeleEleman, "Rastgele Eleman", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        int index = 0;
        //private void button3_Click(object sender, EventArgs e)
        //{
        //    if (index < arabalar.Length)
        //    {
        //        lstArac.Items.Add(arabalar[index]);
        //        index++;
        //    }
        //    else
        //        MessageBox.Show("Dizinin son elemanına ulaşıldı");
        //}


        private void AracListeEkle(object sender, EventArgs e)
        {
            if (index < arabalar.Length)
            {
                lstArac.Items.Add(arabalar[index]);
                index++;
            }
            else
                MessageBox.Show("Dizinin son elemanına ulaşıldı");
        }
        
    }
}
