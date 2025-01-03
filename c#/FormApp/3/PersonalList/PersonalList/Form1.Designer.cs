namespace PersonalList
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
            groupBox1 = new GroupBox();
            btnSave = new Button();
            txtBoxPhone = new TextBox();
            lblPhone = new Label();
            txtBoxEmail = new TextBox();
            lblEmail = new Label();
            txtBoxTc = new TextBox();
            lblTc = new Label();
            txtBoxName = new TextBox();
            lblName = new Label();
            lvPerList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lblPerList = new Label();
            txtBoxSearch = new TextBox();
            btnSearch = new Button();
            btnClearFilter = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(txtBoxPhone);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(txtBoxEmail);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(txtBoxTc);
            groupBox1.Controls.Add(lblTc);
            groupBox1.Controls.Add(txtBoxName);
            groupBox1.Controls.Add(lblName);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(36, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Ekleme Formu";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientInactiveCaption;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.Location = new Point(539, 153);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 37);
            btnSave.TabIndex = 8;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtBoxPhone
            // 
            txtBoxPhone.Location = new Point(465, 88);
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Size = new Size(184, 31);
            txtBoxPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPhone.Location = new Point(386, 88);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(82, 25);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Telefon :";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(101, 88);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(184, 31);
            txtBoxEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEmail.Location = new Point(22, 88);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(82, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-Posta :";
            // 
            // txtBoxTc
            // 
            txtBoxTc.Location = new Point(465, 35);
            txtBoxTc.Name = "txtBoxTc";
            txtBoxTc.Size = new Size(184, 31);
            txtBoxTc.TabIndex = 3;
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTc.Location = new Point(386, 35);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(38, 23);
            lblTc.TabIndex = 2;
            lblTc.Text = "TC :";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(101, 35);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(184, 31);
            txtBoxName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblName.Location = new Point(22, 35);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 25);
            lblName.TabIndex = 0;
            lblName.Text = "İsim :";
            // 
            // lvPerList
            // 
            lvPerList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvPerList.FullRowSelect = true;
            lvPerList.GridLines = true;
            lvPerList.Location = new Point(36, 302);
            lvPerList.Name = "lvPerList";
            lvPerList.Size = new Size(721, 121);
            lvPerList.TabIndex = 1;
            lvPerList.UseCompatibleStateImageBehavior = false;
            lvPerList.View = View.Details;
            lvPerList.DoubleClick += lvPersonel_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "İsim";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "TC";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "E-Posta";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Telefon";
            columnHeader4.Width = 150;
            // 
            // lblPerList
            // 
            lblPerList.AutoSize = true;
            lblPerList.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPerList.Location = new Point(36, 274);
            lblPerList.Name = "lblPerList";
            lblPerList.Size = new Size(141, 25);
            lblPerList.TabIndex = 2;
            lblPerList.Text = "Personel Listesi";
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(501, 269);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(156, 27);
            txtBoxSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSearch.Location = new Point(663, 269);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 27);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Location = new Point(385, 268);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(94, 27);
            btnClearFilter.TabIndex = 6;
            btnClearFilter.Text = "Sıfırla";
            btnClearFilter.UseVisualStyleBackColor = true;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearFilter);
            Controls.Add(btnSearch);
            Controls.Add(txtBoxSearch);
            Controls.Add(lblPerList);
            Controls.Add(lvPerList);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblName;
        private TextBox txtBoxTc;
        private Label lblTc;
        private TextBox txtBoxName;
        private Label lblPhone;
        private TextBox txtBoxEmail;
        private Label lblEmail;
        private TextBox txtBoxPhone;
        private Button btnSave;
        private ListView lvPerList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label lblPerList;
        private TextBox txtBoxSearch;
        private Button btnSearch;
        private Button btnClearFilter;
    }
}
