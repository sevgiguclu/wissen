using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace directoryandfilesample
{
    public partial class Form3 : Form
    {
        string FullPath = string.Empty;
        public Form3()
        {
            InitializeComponent();
        }

        //Constructor Method
        public Form3(string _path)
        {
            FullPath = _path;
            InitializeComponent();

            this.Load += LoadFilesAndFolders;

        }

        private void LoadFilesAndFolders(object? sender, EventArgs e)
        {
            string[] directories = Directory.GetDirectories(FullPath);
            string[] files = Directory.GetFiles(FullPath);

            ListDirectories(directories);//klasörleri listele
            ListFiles(files);//dosyaları listele
        }

        private void ListFiles(string[] files)
        {
            int index = 0;
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                lstViewFolderList.Items.Add(fileInfo.Name);
                lstViewFolderList.Items[index].SubItems.Add((fileInfo.Length / 1024).ToString());
                lstViewFolderList.Items[index].SubItems.Add(((fileInfo.Length / 1024) / 1024).ToString());
                lstViewFolderList.Items[index].SubItems.Add(fileInfo.CreationTime.ToLongDateString());
                lstViewFolderList.Items[index].SubItems.Add(fileInfo.Extension);
                index++;


            }
        }

        private void ListDirectories(string[] directories)
        {
            //foreach (string item in directories)
            //{
            //    lstBoxFolderList.Items.Add(item);
            //}

            lstBoxFolderList.Items.AddRange(directories);
        }
    }
}
