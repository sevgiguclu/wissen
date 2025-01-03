namespace WindowsForm
{
    partial class Form4
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
            btnAracListesi = new Button();
            SuspendLayout();
            // 
            // btnAracListesi
            // 
            btnAracListesi.Location = new Point(69, 60);
            btnAracListesi.Name = "btnAracListesi";
            btnAracListesi.Size = new Size(122, 64);
            btnAracListesi.TabIndex = 0;
            btnAracListesi.Text = "Araç Listesi Formunu Göster";
            btnAracListesi.UseVisualStyleBackColor = true;
            btnAracListesi.Click += btnAracListesi_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 188);
            Controls.Add(btnAracListesi);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAracListesi;
    }
}