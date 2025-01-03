namespace PersonalList
{
    public partial class Form1 : Form
    {
        const string path = @"C:\UygulamaIcerikleri\";
        const string fileKisiler = "Personel.txt";

        string FullPath = string.Concat(path, fileKisiler);
        bool edit = false;
        string old_line;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //eðer kayýtlý bir dosya var ise listede gösterelim yoksa boþ bir dosya oluþturalým

            if (File.Exists(FullPath))
            {
                ReadList();
            }
            else
            {
                using (File.Create(FullPath))
                {
                    MessageBox.Show("Personel Kayýt Listeniz bulunmadýðýndan dolayý yeni bir dosya oluþturuldu.");
                }

            }

        }

        private void ReadList()
        {
            using (StreamReader sr = new StreamReader(FullPath))
            {
                ListAllPersonel(sr);
            }
        }

        private void ListAllPersonel(StreamReader sr)
        {
            lvPerList.Items.Clear();
            string line = sr.ReadLine();

            while (line != null)
            {
                splitLineAndWrite(line);
                line = sr.ReadLine();
            }
        }

        private void splitLineAndWrite(string line)
        {
            string[] values = line.Split(" | ");
            int index = lvPerList.Items.Count;
            lvPerList.Items.Add(values[0]);

            for (int i = 1; i < values.Length; i++)
            {
                lvPerList.Items[index].SubItems.Add(values[i]);
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (edit)
            {
                List<string> new_list = new List<string>();
                using (StreamReader sr = new StreamReader(FullPath))
                {
                    string line = sr.ReadLine();
                    while (line != null) {
                        if (line.Trim() == old_line.Trim())
                        {
                            
                            string new_name = txtBoxName.Text;
                            string new_tc = txtBoxTc.Text;
                            string new_email = txtBoxEmail.Text;
                            string new_phone = txtBoxPhone.Text;

                            string new_line = $"{new_name} | {new_tc} | {new_email} | {new_phone} ";
                            new_list.Add(new_line);
                        }
                        else
                        {
                            new_list.Add(line);
                        }
                        line = sr.ReadLine();
                    }

                }

                File.Delete(FullPath);
                foreach (string item in new_list)
                {
                    using (StreamWriter sw = new StreamWriter(FullPath, true))
                    {
                        sw.WriteLine(item);
                        sw.Close();
                    }
                }
            }
            else
            {
                string name = txtBoxName.Text;
                string tc = txtBoxTc.Text;
                string email = txtBoxEmail.Text;
                string phone = txtBoxPhone.Text;

                // sevgi güçlü | 11111111111 | sevgiguclu@gmail.com | 1111111111111

                string text = $"{name} | {tc} | {email} | {phone} ";

                using (StreamWriter sw = new StreamWriter(FullPath, true))
                {
                    sw.WriteLine(text);
                    sw.Close();
                }
            }

            edit = false;
            cleanForm();
            ReadList();
        }

        private void cleanForm()
        {
            foreach (Control cntrl in groupBox1.Controls)
            {
                if (cntrl.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)cntrl;
                    txt.Clear();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvPerList.Items.Clear();
            string keyword = txtBoxSearch.Text;

            using (StreamReader sr = new StreamReader(FullPath))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (line.Contains(keyword))
                    {
                        splitLineAndWrite(line);

                    }
                    line = sr.ReadLine();
                }
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            ReadList();
        }

        private void lvPersonel_DoubleClick(object sender, EventArgs e)
        {
            
            string name = lvPerList.SelectedItems[0].SubItems[0].Text;
            string tc = lvPerList.SelectedItems[0].SubItems[1].Text;
            string email = lvPerList.SelectedItems[0].SubItems[2].Text;
            string phone = lvPerList.SelectedItems[0].SubItems[3].Text;

            old_line = $"{name} | {tc} | {email} | {phone} ";

            txtBoxName.Text = name;
            txtBoxTc.Text = tc;
            txtBoxEmail.Text = email;
            txtBoxPhone.Text = phone;

            edit = true;


        }
    }
}
