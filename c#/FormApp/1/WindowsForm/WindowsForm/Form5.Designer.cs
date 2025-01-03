namespace WindowsForm
{
    partial class Form5
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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            lstArac = new ListBox();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 24);
            button1.Name = "button1";
            button1.Size = new Size(138, 23);
            button1.TabIndex = 0;
            button1.Text = "Son Eleman";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(13, 63);
            button2.Name = "button2";
            button2.Size = new Size(137, 23);
            button2.TabIndex = 1;
            button2.Text = "Rastgele Eleman";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lstArac);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(184, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 390);
            panel1.TabIndex = 2;
            // 
            // lstArac
            // 
            lstArac.Dock = DockStyle.Bottom;
            lstArac.FormattingEnabled = true;
            lstArac.ItemHeight = 15;
            lstArac.Location = new Point(0, 56);
            lstArac.Name = "lstArac";
            lstArac.Size = new Size(313, 334);
            lstArac.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(10, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "Araç Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AracListeEkle;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 414);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form5";
            Text = "Form5";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
        private ListBox lstArac;
        private Button button3;
    }
}