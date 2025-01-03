using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistem_app
{
    public partial class Form2 : Form
    {
        const string path = @"C:\UygulamaIcerikleri\";
        const string fileKisiler = "Kisiler.txt";
        public Form2()
        {
            InitializeComponent();

            btn_kayit_ekle.Click += KayitEkle;
            btn_temizle.Click += Temizle;
            btnVeriYukle.Click += VeriYukle;
        }

        private void VeriYukle(object? sender, EventArgs e)
        {
            string FullPath = string.Concat(path, fileKisiler);

            using(StreamReader sr = new StreamReader(FullPath))
            {
                ListeYaz(sr);
            }
        }

        

        private void ListeYaz(StreamReader sr)
        {
            listViewVeriler.Items.Clear();
            string line = sr.ReadLine();
            while (line != null)
            {
                ListViewAdd(line);
                line = sr.ReadLine();
            }
        }

        private void ListViewAdd(string line)
        {
            string[] lineValues = line.Split(';');
            int index = listViewVeriler.Items.Count;
            listViewVeriler.Items.Add(lineValues[0]);
            listViewVeriler.Items[index].SubItems.Add(lineValues[1].ToString());
        }

        private void KayitEkle(object sender, EventArgs e)
        {
            string ad = string.Empty;
            string soyad = string.Empty;
            int yas;
            string line = string.Empty;
            string fullPath = string.Concat(path, fileKisiler);

            ad = textBoxAd.Text;
            soyad = textBoxSoyad.Text;
            yas = int.Parse(textBoxYas.Text);

            line = $"{ad} {soyad} ; {yas}";


            using (StreamWriter sw = new StreamWriter(fullPath,true))
            {
                sw.WriteLine(line);
                sw.Close();
            }

            FormTemizle();

        }

        private void Temizle(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void FormTemizle()
        {
            foreach (Control cnt in grpVeriGirisi.Controls)
            {
                if (cnt.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)cnt;
                    txt.Clear();

                }
            }
        }

    }
}
