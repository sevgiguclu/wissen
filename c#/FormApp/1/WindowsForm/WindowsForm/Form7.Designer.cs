namespace WindowsForm
{
    partial class Form7
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
            btnElemanEkle = new Button();
            btnSiralama = new Button();
            btnElemanVarmi = new Button();
            SuspendLayout();
            // 
            // btnElemanEkle
            // 
            btnElemanEkle.Location = new Point(36, 35);
            btnElemanEkle.Name = "btnElemanEkle";
            btnElemanEkle.Size = new Size(75, 53);
            btnElemanEkle.TabIndex = 0;
            btnElemanEkle.Text = "Eleman Ekle";
            btnElemanEkle.UseVisualStyleBackColor = true;
            btnElemanEkle.Click += btnElemanEkle_Click;
            // 
            // btnSiralama
            // 
            btnSiralama.Location = new Point(149, 35);
            btnSiralama.Name = "btnSiralama";
            btnSiralama.Size = new Size(75, 53);
            btnSiralama.TabIndex = 1;
            btnSiralama.Text = "Sıralama";
            btnSiralama.UseVisualStyleBackColor = true;
            btnSiralama.Click += btnSiralama_Click;
            // 
            // btnElemanVarmi
            // 
            btnElemanVarmi.Location = new Point(246, 35);
            btnElemanVarmi.Name = "btnElemanVarmi";
            btnElemanVarmi.Size = new Size(75, 53);
            btnElemanVarmi.TabIndex = 2;
            btnElemanVarmi.Text = "Eleman Var mı";
            btnElemanVarmi.UseVisualStyleBackColor = true;
            btnElemanVarmi.Click += btnElemanVarmi_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnElemanVarmi);
            Controls.Add(btnSiralama);
            Controls.Add(btnElemanEkle);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
        }

        #endregion

        private Button btnElemanEkle;
        private Button btnSiralama;
        private Button btnElemanVarmi;
    }
}