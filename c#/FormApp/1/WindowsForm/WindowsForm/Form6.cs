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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            button3.Visible = false;
            button4.Visible = false;
        }

        string[] sehirler = { "Ankara", "İstanbul", "Bursa", "Adana", "Mersin", "Kastamonu", "Bolu" };


        private void btnElemanlariEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox2.Items.Clear();
                //foreach (string sehir in listBox1.Items)
                //{
                //    listBox2.Items.Add(sehir);
                //}

                listBox2.Items.AddRange(listBox1.Items);
                listBox1.Items.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(listBox2.Items);
                listBox2.Items.Clear();
            }
        }

        /* ödev :
         * soldan değer seçip > tuşuna basınca seçilen değeri sola, sağdan seçileni sola geçiren kod +
         * çift tıklayarak aynı işlem +
        
        */

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox1.SelectedItem;


            if (selectedItem != null)
            {
                bool inListBox2 = listBox2.Items.Contains(selectedItem);

                if (inListBox2)
                {
                    MessageBox.Show("Bu şehir zaten var..");
                }
                else
                {
                    listBox1.Items.Remove(selectedItem);
                    listBox2.Items.Add(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Lütfen sol taraftan bir şehir seçiniz ve > tuşuna basınız.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var selectedItem = listBox2.SelectedItem;


            if (selectedItem != null)
            {
                bool inListBox1 = listBox1.Items.Contains(selectedItem);

                if (inListBox1)
                {
                    MessageBox.Show("Bu şehir zaten var..");
                }
                else
                {
                    listBox2.Items.Remove(selectedItem);
                    listBox1.Items.Add(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Lütfen sağ taraftan bir şehir seçiniz ve < tuşuna basınız.");
            }
        }

        private void listBox2_Selected(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = true;
        }

        private void listBox1_Selected(object sender, EventArgs e)
        {
            button3.Visible = true;
            button4.Visible = false;
        }
    }
}
