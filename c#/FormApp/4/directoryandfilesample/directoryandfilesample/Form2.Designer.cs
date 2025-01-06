namespace directoryandfilesample
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtFolderPath = new TextBox();
            btnChooseFolder = new Button();
            fbdGetFolder = new FolderBrowserDialog();
            btnGetFolderName = new Button();
            lvFolderList = new ListView();
            sirano = new ColumnHeader();
            klasorAdi = new ColumnHeader();
            klasorYolu = new ColumnHeader();
            cntMenuDetail_Opening = new ContextMenuStrip(components);
            klasörVeDosylarToolStripMenuItem = new ToolStripMenuItem();
            cntMenuDetail_Opening.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 40);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "klasör seç";
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(139, 37);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.Size = new Size(198, 27);
            txtFolderPath.TabIndex = 1;
            // 
            // btnChooseFolder
            // 
            btnChooseFolder.Location = new Point(356, 37);
            btnChooseFolder.Name = "btnChooseFolder";
            btnChooseFolder.Size = new Size(78, 29);
            btnChooseFolder.TabIndex = 2;
            btnChooseFolder.Text = "...";
            btnChooseFolder.UseVisualStyleBackColor = true;
            btnChooseFolder.Click += btnChooseFolder_Click;
            // 
            // btnGetFolderName
            // 
            btnGetFolderName.Location = new Point(356, 97);
            btnGetFolderName.Name = "btnGetFolderName";
            btnGetFolderName.Size = new Size(159, 29);
            btnGetFolderName.TabIndex = 3;
            btnGetFolderName.Text = "Klasör Listesi";
            btnGetFolderName.UseVisualStyleBackColor = true;
            btnGetFolderName.Click += btnGetFolderName_Click;
            // 
            // lvFolderList
            // 
            lvFolderList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvFolderList.Columns.AddRange(new ColumnHeader[] { sirano, klasorAdi, klasorYolu });
            lvFolderList.ContextMenuStrip = cntMenuDetail_Opening;
            lvFolderList.FullRowSelect = true;
            lvFolderList.GridLines = true;
            lvFolderList.Location = new Point(0, 177);
            lvFolderList.Name = "lvFolderList";
            lvFolderList.Size = new Size(683, 245);
            lvFolderList.TabIndex = 4;
            lvFolderList.UseCompatibleStateImageBehavior = false;
            lvFolderList.View = View.Details;
            // 
            // sirano
            // 
            sirano.Text = "SIRA NO";
            sirano.Width = 100;
            // 
            // klasorAdi
            // 
            klasorAdi.Text = "klasor Adi";
            klasorAdi.Width = 200;
            // 
            // klasorYolu
            // 
            klasorYolu.Text = "klasor Yolu";
            klasorYolu.Width = 300;
            // 
            // cntMenuDetail_Opening
            // 
            cntMenuDetail_Opening.ImageScalingSize = new Size(20, 20);
            cntMenuDetail_Opening.Items.AddRange(new ToolStripItem[] { klasörVeDosylarToolStripMenuItem });
            cntMenuDetail_Opening.Name = "contextMenuStrip1";
            cntMenuDetail_Opening.Size = new Size(211, 56);
            cntMenuDetail_Opening.Opening += cntMenuDetail_Opening_Opening;
            cntMenuDetail_Opening.Click += cntMenuDetail_Opening_Click;
            // 
            // klasörVeDosylarToolStripMenuItem
            // 
            klasörVeDosylarToolStripMenuItem.Name = "klasörVeDosylarToolStripMenuItem";
            klasörVeDosylarToolStripMenuItem.Size = new Size(210, 24);
            klasörVeDosylarToolStripMenuItem.Text = "klasör ve dosyalar";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 434);
            Controls.Add(lvFolderList);
            Controls.Add(btnGetFolderName);
            Controls.Add(btnChooseFolder);
            Controls.Add(txtFolderPath);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            cntMenuDetail_Opening.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFolderPath;
        private Button btnChooseFolder;
        private FolderBrowserDialog fbdGetFolder;
        private Button btnGetFolderName;
        private ListView lvFolderList;
        private ColumnHeader sirano;
        private ColumnHeader klasorAdi;
        private ColumnHeader klasorYolu;
        private ContextMenuStrip cntMenuDetail_Opening;
        private ToolStripMenuItem klasörVeDosylarToolStripMenuItem;
    }
}