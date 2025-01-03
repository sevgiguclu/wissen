namespace WindowsForm
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
            txtGirilenMetin = new TextBox();
            lblKalanKarakter = new Label();
            SuspendLayout();
            // 
            // txtGirilenMetin
            // 
            txtGirilenMetin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtGirilenMetin.Location = new Point(12, 12);
            txtGirilenMetin.Multiline = true;
            txtGirilenMetin.Name = "txtGirilenMetin";
            txtGirilenMetin.Size = new Size(366, 109);
            txtGirilenMetin.TabIndex = 0;
            txtGirilenMetin.TextChanged += txtGirilenMetin_TextChanged;
            // 
            // lblKalanKarakter
            // 
            lblKalanKarakter.AutoSize = true;
            lblKalanKarakter.Location = new Point(15, 138);
            lblKalanKarakter.Name = "lblKalanKarakter";
            lblKalanKarakter.Size = new Size(38, 15);
            lblKalanKarakter.TabIndex = 1;
            lblKalanKarakter.Text = "label1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 260);
            Controls.Add(lblKalanKarakter);
            Controls.Add(txtGirilenMetin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGirilenMetin;
        private Label lblKalanKarakter;
    }
}