namespace sistem_app
{
    public partial class Form1 : Form
    {
        //filestream

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //StreamWriter strwrite = new StreamWriter(textFilePath.Text);
            //strwrite.Write(richTextBox1.Text);
            //strwrite.Close();// ya ad flush 
            //richTextBox1.Clear();

            //FileStream fs = new FileStream(textFilePath.Text,FileMode.Create,FileAccess.Write);
            FileStream fs = new FileStream(textFilePath.Text, FileMode.Append, FileAccess.Write);
            StreamWriter strwrite = new StreamWriter(fs);
            strwrite.WriteLine(richTextBox1.Text);
            strwrite.Close();
            fs.Close();
            fs = null;
            richTextBox1.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(textFilePath.Text);
            //string str = sr.ReadToEnd();
            //richTextBox1.Text = str;
            //sr.Close();

            FileStream fs = new FileStream(textFilePath.Text,FileMode.Open,FileAccess.Read);
            StreamReader strread = new StreamReader(fs);
            string fileCOntent = strread.ReadToEnd();
            richTextBox1.Text = fileCOntent;
            strread.Close();
            fs.Close();

            strread = null;
            fs = null;

        }
    }
}
