using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;



namespace QLMAYBAY
{
    public partial class FormThem : Form
    {
        Ketnoi kn = new Ketnoi();
        public FormThem()
        {
            InitializeComponent();

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormThem_Load(object sender, EventArgs e)
        {
            getdata();
        }
        public void getdata()
        {

            try
            {
                string query = "select * from maybay order by mamb";
                DataSet ds = kn.LayDuLieu(query);

                if (ds != null && ds.Tables.Count > 0)
                {
                    hienthi.DataSource = ds.Tables[0]; // Gán dữ liệu vào DataGridView
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }
            // Get data from form controls (replace with actual control names)
            string ma = txtma.Text;
            string ten = txtten.Text;
            int nam = int.Parse(txtnam.Text);
            float sogio = float.Parse(txtsogio.Text);

            // Create SQL INSERT statement with parameterized query for security
            string query = "INSERT INTO maybay (mamb, tenmb, namsx, sogiobay) VALUES (@ma, @ten, @nam, @sogio)";

            try
            {

                using (SqlCommand cmd = new SqlCommand(query, kn.Connection))
                {
                    // Add parameters with explicit data types for better type safety
                    cmd.Parameters.AddWithValue("@ma", SqlDbType.VarChar).Value = ma;
                    cmd.Parameters.AddWithValue("@ten", SqlDbType.NVarChar).Value = ten;
                    cmd.Parameters.AddWithValue("@nam", SqlDbType.Int).Value = nam;
                    cmd.Parameters.AddWithValue("@sogio", SqlDbType.Float).Value = sogio;

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm máy bay thành công!");
                        getdata(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Thêm máy bay thất bại!");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message);
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
