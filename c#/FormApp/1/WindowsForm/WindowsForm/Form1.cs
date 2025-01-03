namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World!!!", "Welcome", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string parola = txtParola.Text.Trim();

            string msg = $"Kullanýcý Adý : {kullaniciAdi}\n" +
                $"Parola : {parola}";

            MessageBox.Show(msg, "Kullanmýcý Bilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        //private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        //{

        //}

        //private void btnLogin_MouseClick(object sender, MouseEventArgs e)
        //{

        //}
    }
}
