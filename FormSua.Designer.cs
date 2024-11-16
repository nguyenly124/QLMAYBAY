namespace QLMAYBAY
{
    partial class FormSua
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
            hienthi = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtma = new TextBox();
            txtten = new TextBox();
            txtnam = new TextBox();
            txtgio = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)hienthi).BeginInit();
            SuspendLayout();
            // 
            // hienthi
            // 
            hienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthi.Location = new Point(388, 44);
            hienthi.Name = "hienthi";
            hienthi.RowHeadersWidth = 51;
            hienthi.Size = new Size(400, 314);
            hienthi.TabIndex = 0;
            hienthi.CellContentClick += hienthi_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(274, 394);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Sửa ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(496, 394);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(68, 394);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Làm mới ";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 133);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã máy bay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 194);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên máy bay ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 263);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 6;
            label3.Text = "Năm sản xuất ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 331);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 7;
            label4.Text = "Số giờ bay ";
            // 
            // txtma
            // 
            txtma.Location = new Point(143, 130);
            txtma.Name = "txtma";
            txtma.Size = new Size(216, 27);
            txtma.TabIndex = 8;
            // 
            // txtten
            // 
            txtten.Location = new Point(143, 191);
            txtten.Name = "txtten";
            txtten.Size = new Size(216, 27);
            txtten.TabIndex = 9;
            // 
            // txtnam
            // 
            txtnam.Location = new Point(143, 260);
            txtnam.Name = "txtnam";
            txtnam.Size = new Size(216, 27);
            txtnam.TabIndex = 10;
            txtnam.TextChanged += textBox3_TextChanged;
            // 
            // txtgio
            // 
            txtgio.Location = new Point(143, 328);
            txtgio.Name = "txtgio";
            txtgio.Size = new Size(216, 27);
            txtgio.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(95, 57);
            label5.Name = "label5";
            label5.Size = new Size(196, 28);
            label5.TabIndex = 12;
            label5.Text = "Thông tin máy bay ";
            // 
            // FormSua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtgio);
            Controls.Add(txtnam);
            Controls.Add(txtten);
            Controls.Add(txtma);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(hienthi);
            Name = "FormSua";
            Text = "FormSua";
            Load += FormSua_Load;
            ((System.ComponentModel.ISupportInitialize)hienthi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView hienthi;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtma;
        private TextBox txtten;
        private TextBox txtnam;
        private TextBox txtgio;
        private Label label5;
    }
}