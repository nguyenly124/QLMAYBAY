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
            btthoat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtma = new TextBox();
            txtnam = new TextBox();
            txtsogio = new TextBox();
            txtten = new TextBox();
            btlammoi = new Button();
            hienthi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)hienthi).BeginInit();
            SuspendLayout();
            // 
            // btthem
            // 
            btthem.Location = new Point(349, 392);
            btthem.Name = "btthem";
            btthem.Size = new Size(94, 29);
            btthem.TabIndex = 0;
            btthem.Text = "Thêm";
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // btthoat
            // 
            btthoat.Location = new Point(553, 392);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(94, 29);
            btthoat.TabIndex = 1;
            btthoat.Text = "Thoát";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
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
            label4.Size = new Size(80, 20);
            label4.TabIndex = 5;
            label4.Text = "Số giờ bay";
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
            // txtsogio
            // 
            txtsogio.Location = new Point(208, 303);
            txtsogio.Name = "txtsogio";
            txtsogio.Size = new Size(318, 27);
            txtsogio.TabIndex = 10;
            // 
            // txtten
            // 
            txtten.Location = new Point(209, 164);
            txtten.Name = "txtten";
            txtten.Size = new Size(317, 27);
            txtten.TabIndex = 11;
            // 
            // btlammoi
            // 
            btlammoi.Location = new Point(110, 392);
            btlammoi.Name = "btlammoi";
            btlammoi.Size = new Size(94, 29);
            btlammoi.TabIndex = 12;
            btlammoi.Text = "Làm mới ";
            btlammoi.UseVisualStyleBackColor = true;
            // 
            // hienthi
            // 
            hienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthi.Location = new Point(580, 67);
            hienthi.Name = "hienthi";
            hienthi.RowHeadersWidth = 51;
            hienthi.Size = new Size(415, 263);
            hienthi.TabIndex = 13;
            // 
            // FormThem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 450);
            Controls.Add(hienthi);
            Controls.Add(btlammoi);
            Controls.Add(txtten);
            Controls.Add(txtsogio);
            Controls.Add(txtnam);
            Controls.Add(txtma);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btthoat);
            Controls.Add(btthem);
            Name = "FormThem";
            Text = "FormThem";
            Load += FormThem_Load;
            ((System.ComponentModel.ISupportInitialize)hienthi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btthem;
        private Button btthoat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtma;
        private TextBox txtnam;
        private TextBox txtsogio;
        private TextBox txtten;
        private Button btlammoi;
        private DataGridView hienthi;
    }
}