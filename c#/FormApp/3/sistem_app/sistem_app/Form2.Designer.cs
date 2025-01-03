namespace sistem_app
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
            grpVeriGirisi = new GroupBox();
            btn_kayit_ekle = new Button();
            btn_temizle = new Button();
            textBoxYas = new TextBox();
            textBoxSoyad = new TextBox();
            textBoxAd = new TextBox();
            yas = new Label();
            soyad = new Label();
            ad = new Label();
            grpVeriOku = new GroupBox();
            listViewVeriler = new ListView();
            btnVeriYukle = new Button();
            name = new ColumnHeader();
            age = new ColumnHeader();
            grpVeriGirisi.SuspendLayout();
            grpVeriOku.SuspendLayout();
            SuspendLayout();
            // 
            // grpVeriGirisi
            // 
            grpVeriGirisi.Controls.Add(btn_kayit_ekle);
            grpVeriGirisi.Controls.Add(btn_temizle);
            grpVeriGirisi.Controls.Add(textBoxYas);
            grpVeriGirisi.Controls.Add(textBoxSoyad);
            grpVeriGirisi.Controls.Add(textBoxAd);
            grpVeriGirisi.Controls.Add(yas);
            grpVeriGirisi.Controls.Add(soyad);
            grpVeriGirisi.Controls.Add(ad);
            grpVeriGirisi.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpVeriGirisi.Location = new Point(49, 26);
            grpVeriGirisi.Name = "grpVeriGirisi";
            grpVeriGirisi.Size = new Size(563, 251);
            grpVeriGirisi.TabIndex = 0;
            grpVeriGirisi.TabStop = false;
            grpVeriGirisi.Text = "veri giriş";
            // 
            // btn_kayit_ekle
            // 
            btn_kayit_ekle.Font = new Font("Comic Sans MS", 12F);
            btn_kayit_ekle.Location = new Point(247, 193);
            btn_kayit_ekle.Name = "btn_kayit_ekle";
            btn_kayit_ekle.Size = new Size(118, 36);
            btn_kayit_ekle.TabIndex = 7;
            btn_kayit_ekle.Text = "kayıt ekle";
            btn_kayit_ekle.UseVisualStyleBackColor = true;
            // 
            // btn_temizle
            // 
            btn_temizle.Font = new Font("Comic Sans MS", 12F);
            btn_temizle.Location = new Point(132, 193);
            btn_temizle.Name = "btn_temizle";
            btn_temizle.Size = new Size(91, 36);
            btn_temizle.TabIndex = 6;
            btn_temizle.Text = "temizle";
            btn_temizle.UseVisualStyleBackColor = true;
            // 
            // textBoxYas
            // 
            textBoxYas.Location = new Point(132, 130);
            textBoxYas.Name = "textBoxYas";
            textBoxYas.Size = new Size(233, 33);
            textBoxYas.TabIndex = 5;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(132, 86);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(233, 33);
            textBoxSoyad.TabIndex = 4;
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(132, 39);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(233, 33);
            textBoxAd.TabIndex = 3;
            // 
            // yas
            // 
            yas.AutoSize = true;
            yas.Font = new Font("Comic Sans MS", 12F);
            yas.Location = new Point(30, 131);
            yas.Name = "yas";
            yas.Size = new Size(42, 28);
            yas.TabIndex = 2;
            yas.Text = "yaş";
            // 
            // soyad
            // 
            soyad.AutoSize = true;
            soyad.Font = new Font("Comic Sans MS", 12F);
            soyad.Location = new Point(21, 83);
            soyad.Name = "soyad";
            soyad.Size = new Size(65, 28);
            soyad.TabIndex = 1;
            soyad.Text = "soyad";
            // 
            // ad
            // 
            ad.AutoSize = true;
            ad.Font = new Font("Comic Sans MS", 12F);
            ad.Location = new Point(30, 40);
            ad.Name = "ad";
            ad.Size = new Size(34, 28);
            ad.TabIndex = 0;
            ad.Text = "ad";
            // 
            // grpVeriOku
            // 
            grpVeriOku.Controls.Add(listViewVeriler);
            grpVeriOku.Controls.Add(btnVeriYukle);
            grpVeriOku.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpVeriOku.Location = new Point(42, 283);
            grpVeriOku.Name = "grpVeriOku";
            grpVeriOku.Size = new Size(570, 217);
            grpVeriOku.TabIndex = 1;
            grpVeriOku.TabStop = false;
            grpVeriOku.Text = "dosyadan veri oku ";
            // 
            // listViewVeriler
            // 
            listViewVeriler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewVeriler.BackColor = SystemColors.ButtonHighlight;
            listViewVeriler.Columns.AddRange(new ColumnHeader[] { name, age });
            listViewVeriler.ForeColor = SystemColors.InfoText;
            listViewVeriler.GridLines = true;
            listViewVeriler.Location = new Point(29, 68);
            listViewVeriler.Name = "listViewVeriler";
            listViewVeriler.Size = new Size(535, 146);
            listViewVeriler.TabIndex = 1;
            listViewVeriler.UseCompatibleStateImageBehavior = false;
            listViewVeriler.View = View.Details;
            // 
            // btnVeriYukle
            // 
            btnVeriYukle.Location = new Point(22, 33);
            btnVeriYukle.Name = "btnVeriYukle";
            btnVeriYukle.Size = new Size(94, 29);
            btnVeriYukle.TabIndex = 0;
            btnVeriYukle.Text = "veriYükle";
            btnVeriYukle.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            name.Text = "ad";
            name.Width = 300;
            // 
            // age
            // 
            age.Text = "yas";
            age.Width = 100;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 569);
            Controls.Add(grpVeriOku);
            Controls.Add(grpVeriGirisi);
            Name = "Form2";
            Text = "Form2";
            grpVeriGirisi.ResumeLayout(false);
            grpVeriGirisi.PerformLayout();
            grpVeriOku.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpVeriGirisi;
        private TextBox textBoxYas;
        private TextBox textBoxSoyad;
        private TextBox textBoxAd;
        private Label yas;
        private Label soyad;
        private Label ad;
        private Button btn_kayit_ekle;
        private Button btn_temizle;
        private GroupBox grpVeriOku;
        private Button btnVeriYukle;
        private ListView listViewVeriler;
        private ColumnHeader name;
        private ColumnHeader age;
    }
}