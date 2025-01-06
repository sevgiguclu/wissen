namespace directoryandfilesample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDriveInfo_Click(object sender, EventArgs e)
        {
            //Disk üzerindeki sürücü bilgilerini almak için kullanýlan sýnýf DriveInfo sýnýfý
            DriveInfo di = new DriveInfo("C:\\");
            string driveInfo = string.Empty;
            driveInfo = $"Sürücü ADI: {di.Name}\n" +
                $"Sürücü Ön adý: {di.VolumeLabel}\n" +
                $"toplam boyut: {di.TotalSize}\n" +
                $"Boþ alan boyutu: {di.TotalFreeSpace}\n" +
                $"Kullanýlabilir boþ alan : {di.AvailableFreeSpace}\n";
            MessageBox.Show(driveInfo);


        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            //DirectoryInfo klasör hakkýnda bilgileri alma ve klasör ekleme silme taþýma gibi iþlemleri yapmak için kullanýlan sýnýftýr 
            DirectoryInfo dirInfo = new DirectoryInfo("C:\\UygulamaIcerikleri");
            string directoryInfo = string.Empty;
            directoryInfo = $"Klasör yolu: {dirInfo.FullName}\n" +
                $"Klasör adý: {dirInfo.Name}\n" +
                $"bir üst klasör adý: {dirInfo.Parent}\n" +
                $"dosya türü: {dirInfo.Attributes}\n" +
                $"oluþturma tarihi: {dirInfo.CreationTime.ToString("yyyy-MM-dd HH:mm:ss ")} \n" +
            $"son deðiþtirme tarihi: {dirInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss ")} \n";
            MessageBox.Show(directoryInfo);
        }

        private void btnKlasorIslemleri_Click(object sender, EventArgs e)
        {
            /* Directory bir dosya sistemindeki klasörleri (dizinleri) yönetmek için kullanýlan bir sýnýftýr.
             * System.IO ad alanýnda bulunur ve statik (static) bir sýnýftýr, yani bir örnek (instance) oluþturmadan doðrudan kullanýlabilir. 
             */
            if (Directory.Exists("C:\\NewDirectory"))//bu directory varsa
                Directory.Delete("C:\\NewDirectory");//klasörü sil
                /* klasörün içi doluysa hata verecektir o sebeple boþbir klasör olsun
                 * Klasör dolu olduðunda bile silmek istiyorsanýz, Directory.Delete metodunun ikinci bir parametresini (recursive: true) kullanabilirsiniz.
                 * Bu parametre, klasör içindeki tüm alt klasörler ve dosyalar da dahil olmak üzere her þeyi siler.
                 * ya da Klasörü silmeden önce içerik kontrolü yapabilirsiniz
                */
            Directory.CreateDirectory("C:\\NewDirectory");//yeni klasör oluþtur

        }

        private void btnKlasorKopyala_Click(object sender, EventArgs e)
        {
            string source = "C:\\UygulamaIcerikleri";
            string destinationDir = "C:\\NewDirectory\\MoveFolder";
            Directory.Move(source, destinationDir);
        }

        private void btnDosyaKopayala_Click(object sender, EventArgs e)
        {
            string sourceFile = "C:\\NewDirectory\\MoveFolder\\Kisiler.txt";//nerden kopayalacaðý
            string destinationFile = "C:\\NewDirectory\\NewKisiler.txt";//nereye kopyalayacaðý
            File.Move(sourceFile, destinationFile);
        }
    }
}
