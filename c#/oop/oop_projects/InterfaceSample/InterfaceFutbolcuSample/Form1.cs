using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace InterfaceFutbolcuSample
{
    public partial class Form1 : Form
    {
        //farklı bir instance alma şekli
        Kaleci rustu = new Kaleci
        {
            AdSoyad = "Rüştü Reşber",
            Agresiflik = 50,
            Dayaniklilik = 75,
            ElleTopKontrolu = 80,
            FormaNumarasi = 1,
            Refleks = 78,
            SolAYakMi = false,
            SutGucu = 55
        };

        Kaleci muslera = new Kaleci
        {
            AdSoyad = "Fernando Muslera",
            Agresiflik = 60,
            Dayaniklilik = 90,
            ElleTopKontrolu = 76,
            FormaNumarasi = 12,
            Refleks = 82,
            SolAYakMi = false,
            SutGucu = 60
        };

        Defans roberto = new Defans
        {
            AdSoyad = "Roberto Carlos",
            Agresiflik = 72,
            Dayaniklilik = 90,
            FormaNumarasi = 10,
            Refleks = 90,
            SolAYakMi = true,
            SutGucu = 80
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lstFutbolcular.Items.Add(rustu.AdSoyad);
            //lstFutbolcular.Items.Add(muslera.AdSoyad);
            //lstFutbolcular.Items.Add(roberto.AdSoyad);

            lstFutbolcular.Items.Add(rustu);//toString metodu liste kulladığımız için otamatik olarak çalıştırılır
            lstFutbolcular.Items.Add(muslera);
            lstFutbolcular.Items.Add(roberto);
        }

        private void lstFutbolcular_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpFutbolcuOzellikleri.Controls.Clear();//flpnin içi temizlenir

            if (lstFutbolcular.SelectedItem != null && lstFutbolcular.SelectedItem.GetType().GetInterface("IFutbolcu") != null) {

                IFutbolcu secilenFutbolcu = (IFutbolcu) lstFutbolcular.SelectedItem;
                PropertyInfo[] properties = secilenFutbolcu.GetType().GetProperties();
                foreach (PropertyInfo item in properties)
                {
                    Label lbl = new Label();
                    lbl.Text = item.GetCustomAttribute<DisplayAttribute>().Name + " - " + item.GetValue(secilenFutbolcu);

                    lbl.AutoSize = false;
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    lbl.Width = flpFutbolcuOzellikleri.Width - 4;

                    flpFutbolcuOzellikleri.Controls.Add(lbl);
                }
            }

        }
    }
}
