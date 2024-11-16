namespace QLMAYBAY
{
    partial class FormMayBay
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
            hienthimaybay = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)hienthimaybay).BeginInit();
            SuspendLayout();
            // 
            // hienthimaybay
            // 
            hienthimaybay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthimaybay.Location = new Point(115, 71);
            hienthimaybay.Name = "hienthimaybay";
            hienthimaybay.RowHeadersWidth = 51;
            hienthimaybay.Size = new Size(558, 281);
            hienthimaybay.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 21);
            label1.Name = "label1";
            label1.Size = new Size(279, 38);
            label1.TabIndex = 1;
            label1.Text = "Danh sách máy bay ";
            // 
            // button1
            // 
            button1.Location = new Point(579, 389);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Thoát ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormMayBay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(hienthimaybay);
            Name = "FormMayBay";
            Text = "FormMayBay";
            Load += FormMayBay_Load;
            ((System.ComponentModel.ISupportInitialize)hienthimaybay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView hienthimaybay;
        private Label label1;
        private Button button1;
    }
}