namespace QLMAYBAY
{
    partial class FormThem
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
            btthem = new Button();
            bthtoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtma = new TextBox();
            txtnam = new TextBox();
            txtthoigian = new TextBox();
            txtten = new TextBox();
            SuspendLayout();
            // 
            // btthem
            // 
            btthem.Location = new Point(277, 392);
            btthem.Name = "btthem";
            btthem.Size = new Size(94, 29);
            btthem.TabIndex = 0;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            // 
            // bthtoat
            // 
            bthtoat.Location = new Point(553, 392);
            bthtoat.Name = "bthtoat";
            bthtoat.Size = new Size(94, 29);
            bthtoat.TabIndex = 1;
            bthtoat.Text = "Thoát";
            bthtoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 102);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 2;
            label1.Text = "Mã máy bay ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 166);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên máy bay";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 236);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 4;
            label3.Text = "Năm sản xuất ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 300);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 5;
            label4.Text = "Thời gian bay ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(265, 21);
            label5.Name = "label5";
            label5.Size = new Size(218, 38);
            label5.TabIndex = 6;
            label5.Text = "Thêm máy bay ";
            // 
            // txtma
            // 
            txtma.Location = new Point(207, 99);
            txtma.Name = "txtma";
            txtma.Size = new Size(319, 27);
            txtma.TabIndex = 7;
            txtma.TextChanged += textBox1_TextChanged;
            // 
            // txtnam
            // 
            txtnam.Location = new Point(210, 231);
            txtnam.Name = "txtnam";
            txtnam.Size = new Size(316, 27);
            txtnam.TabIndex = 9;
            // 
            // txtthoigian
            // 
            txtthoigian.Location = new Point(208, 303);
            txtthoigian.Name = "txtthoigian";
            txtthoigian.Size = new Size(318, 27);
            txtthoigian.TabIndex = 10;
            // 
            // txtten
            // 
            txtten.Location = new Point(209, 164);
            txtten.Name = "txtten";
            txtten.Size = new Size(317, 27);
            txtten.TabIndex = 11;
            // 
            // FormThem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtten);
            Controls.Add(txtthoigian);
            Controls.Add(txtnam);
            Controls.Add(txtma);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bthtoat);
            Controls.Add(btthem);
            Name = "FormThem";
            Text = "FormThem";
            Load += FormThem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btthem;
        private Button bthtoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtma;
        private TextBox txtnam;
        private TextBox txtthoigian;
        private TextBox txtten;
    }
}