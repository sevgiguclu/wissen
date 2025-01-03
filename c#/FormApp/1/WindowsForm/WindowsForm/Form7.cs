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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnElemanEkle_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);
            sayilar.Add(6);
            sayilar.Add(7);
            sayilar.Add(8);
            sayilar.Add(9);


            //sayilar.Add("8");Tanımlamada oluşturulan veri tipine uygun elemanlar eklenmeli

            MessageBox.Show("Elemanlar int listesine eklendi. \n" +
                "Eleman Sayısı : " + sayilar.Count);
        }

        private void btnSiralama_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("Bursa");
            sehirler.Add("KahramanMaraş");
            sehirler.Add("Bilecik");
            sehirler.Add("Kütahya");

            sehirler.Sort();
            foreach (string sehir in sehirler)
            {
                MessageBox.Show(sehir);
            }
        }

        private void btnElemanVarmi_Click(object sender, EventArgs e)
        {
            //List<string> sehirler = new (){ "Ankara", "İstanbul", "Bursa" };
            //List<string> sehirler = new List<string>() { "Ankara", "İstanbul", "Bursa" };
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("İstanbul");
            sehirler.Add("Bursa");
            sehirler.Add("KahramanMaraş");
            sehirler.Add("Bilecik");
            sehirler.Add("Kütahya");

            if (sehirler.Contains("Bursa"))
                MessageBox.Show("Bursa Mevcut");
            else
                MessageBox.Show("Bursa mevcut değil");
        }
        //List<T> içerisine verilen (<T>) tipe bürünerek, verilen tipdeki elemanları tutan bir kolleksiyon(collection) oluşturmamaızı sağla. Dizilerdeki gibi boyutunu artırma işlemine gerek yok.Kendiliğinde boyutu arttırarak elelman eklenebilir. Diziede Arry.Resize KUllanılıyorud

        //List<string> list = new List<string>();
    }
}
