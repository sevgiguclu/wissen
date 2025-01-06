namespace directoryandfilesample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDriveInfo = new Button();
            btnDirectory = new Button();
            btnKlasorIslemleri = new Button();
            btnKlasorKopyala = new Button();
            btnDosyaKopayala = new Button();
            SuspendLayout();
            // 
            // btnDriveInfo
            // 
            btnDriveInfo.Location = new Point(33, 25);
            btnDriveInfo.Name = "btnDriveInfo";
            btnDriveInfo.Size = new Size(196, 29);
            btnDriveInfo.TabIndex = 0;
            btnDriveInfo.Text = "Sürücü Bilgileri";
            btnDriveInfo.UseVisualStyleBackColor = true;
            btnDriveInfo.Click += btnDriveInfo_Click;
            // 
            // btnDirectory
            // 
            btnDirectory.Location = new Point(259, 25);
            btnDirectory.Name = "btnDirectory";
            btnDirectory.Size = new Size(175, 29);
            btnDirectory.TabIndex = 1;
            btnDirectory.Text = "klasör bilgileri";
            btnDirectory.UseVisualStyleBackColor = true;
            btnDirectory.Click += btnDirectory_Click;
            // 
            // btnKlasorIslemleri
            // 
            btnKlasorIslemleri.Location = new Point(476, 26);
            btnKlasorIslemleri.Name = "btnKlasorIslemleri";
            btnKlasorIslemleri.Size = new Size(172, 29);
            btnKlasorIslemleri.TabIndex = 2;
            btnKlasorIslemleri.Text = "klasör işlemleri";
            btnKlasorIslemleri.UseVisualStyleBackColor = true;
            btnKlasorIslemleri.Click += btnKlasorIslemleri_Click;
            // 
            // btnKlasorKopyala
            // 
            btnKlasorKopyala.Location = new Point(33, 87);
            btnKlasorKopyala.Name = "btnKlasorKopyala";
            btnKlasorKopyala.Size = new Size(155, 29);
            btnKlasorKopyala.TabIndex = 3;
            btnKlasorKopyala.Text = "klasörKopyala";
            btnKlasorKopyala.UseVisualStyleBackColor = true;
            btnKlasorKopyala.Click += btnKlasorKopyala_Click;
            // 
            // btnDosyaKopayala
            // 
            btnDosyaKopayala.Location = new Point(259, 87);
            btnDosyaKopayala.Name = "btnDosyaKopayala";
            btnDosyaKopayala.Size = new Size(176, 29);
            btnDosyaKopayala.TabIndex = 4;
            btnDosyaKopayala.Text = "dosya kopyala";
            btnDosyaKopayala.UseVisualStyleBackColor = true;
            btnDosyaKopayala.Click += btnDosyaKopayala_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDosyaKopayala);
            Controls.Add(btnKlasorKopyala);
            Controls.Add(btnKlasorIslemleri);
            Controls.Add(btnDirectory);
            Controls.Add(btnDriveInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDriveInfo;
        private Button btnDirectory;
        private Button btnKlasorIslemleri;
        private Button btnKlasorKopyala;
        private Button btnDosyaKopayala;
    }
}
