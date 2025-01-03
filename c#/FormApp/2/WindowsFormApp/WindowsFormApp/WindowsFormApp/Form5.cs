using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        //private Form4 frm;
        private Form4 frm;
        internal void VerileriGonder(List<string> adSoyadList, List<string> tCNOList, List<string> dogumYeriList, Form gelenForm)
        {
            
            lvPersonel.Items.Clear();
            int sayac = 0;
            foreach (string item in adSoyadList)
            {
                int satirNumarasi = sayac + 1;
                lvPersonel.Items.Add(satirNumarasi.ToString());
                lvPersonel.Items[sayac].SubItems.Add(adSoyadList[sayac]);
                lvPersonel.Items[sayac].SubItems.Add(tCNOList[sayac]);
                lvPersonel.Items[sayac].SubItems.Add(dogumYeriList[sayac]);
                sayac++;
            }

            frm = (Form4)gelenForm;
        }

        private void lvPersonel_DoubleClick(object sender, EventArgs e)
        {
            if (lvPersonel.Items.Count > 0 && lvPersonel.SelectedItems.Count > 0)
            {
                int number = int.Parse(lvPersonel.SelectedItems[0].SubItems[0].Text);
                frm.txtAdSoyad.Tag = number;
                this.Close();
            }
        }

        private void lvPersonelMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(lvPersonel, e.Location);
            }
        }

        private void contextMenuSil_Click(object sender, EventArgs e)
        {
            if(lvPersonel.Items.Count > 0)
            {
                //MessageBox.Show(lvPersonel.SelectedItems[0].SubItems[0].Text);
                int index = int.Parse(lvPersonel.SelectedItems[0].SubItems[0].Text) - 1;
                frm.VeriyiSil(index,this);
            }
        }
    }
}
