namespace directoryandfilesample
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            lstBoxFolderList = new ListBox();
            lstViewFolderList = new ListView();
            FileName = new ColumnHeader();
            FileSize1 = new ColumnHeader();
            FileSize2 = new ColumnHeader();
            FileDate = new ColumnHeader();
            FileEx = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lstBoxFolderList);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lstViewFolderList);
            splitContainer1.Size = new Size(870, 450);
            splitContainer1.SplitterDistance = 161;
            splitContainer1.TabIndex = 0;
            // 
            // lstBoxFolderList
            // 
            lstBoxFolderList.Dock = DockStyle.Fill;
            lstBoxFolderList.FormattingEnabled = true;
            lstBoxFolderList.Location = new Point(0, 0);
            lstBoxFolderList.Name = "lstBoxFolderList";
            lstBoxFolderList.Size = new Size(161, 450);
            lstBoxFolderList.TabIndex = 0;
            // 
            // lstViewFolderList
            // 
            lstViewFolderList.Columns.AddRange(new ColumnHeader[] { FileName, FileSize1, FileSize2, FileDate, FileEx });
            lstViewFolderList.Dock = DockStyle.Fill;
            lstViewFolderList.GridLines = true;
            lstViewFolderList.Location = new Point(0, 0);
            lstViewFolderList.Name = "lstViewFolderList";
            lstViewFolderList.Size = new Size(705, 450);
            lstViewFolderList.TabIndex = 0;
            lstViewFolderList.UseCompatibleStateImageBehavior = false;
            lstViewFolderList.View = View.Details;
            // 
            // FileName
            // 
            FileName.Text = "Dosya Adı";
            FileName.Width = 100;
            // 
            // FileSize1
            // 
            FileSize1.Text = "Dosya Boyutu(KB)";
            FileSize1.Width = 150;
            // 
            // FileSize2
            // 
            FileSize2.Text = "Dosya Boyutu (MB)";
            FileSize2.Width = 150;
            // 
            // FileDate
            // 
            FileDate.Text = "Oluşturulma Tarihi";
            FileDate.Width = 150;
            // 
            // FileEx
            // 
            FileEx.Text = "Dosya Uzantısı";
            FileEx.Width = 150;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 450);
            Controls.Add(splitContainer1);
            Name = "Form3";
            Text = "Form3";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox lstBoxFolderList;
        private ListView lstViewFolderList;
        private ColumnHeader FileName;
        private ColumnHeader FileSize1;
        private ColumnHeader FileSize2;
        private ColumnHeader FileDate;
        private ColumnHeader FileEx;
    }
}