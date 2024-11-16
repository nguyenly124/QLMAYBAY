using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace QLMAYBAY
{
    public partial class FormSua : Form
    {
        public FormSua()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string query = "UPDATE maybay SET tenmb = @ten, namsx = @nam, sogiobay = @sogio WHERE mamb = @ma";

                try
                {
                
                        using (SqlCommand cmd = new SqlCommand(query, kn.Connection))
                        {
                        cmd.Parameters.AddWithValue("@ma", txtma.Text);
                        cmd.Parameters.AddWithValue("@ten", txtten.Text);
                            cmd.Parameters.AddWithValue("@nam", txtnam.Text);
                            cmd.Parameters.AddWithValue("@sogio", txtgio.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thông tin máy bay thành công!");
                                // Cập nhật lại DataGridView
                                getdata();
                        ClearText();
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật thông tin máy bay thất bại.");
                            }
                        }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        public void ClearText()
        {
            txtma.Text = "";
            txtten.Text = "";
            txtnam.Text = "";
            txtgio.Text = "";
        }


        private void FormSua_Load(object sender, EventArgs e)
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

        private void hienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kn.Connection.State != ConnectionState.Open)
            {
                kn.Connection.Open();
            }
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị của ô được click
                DataGridViewRow row = hienthi.Rows[e.RowIndex];
                string ma = row.Cells["mamb"].Value.ToString();
                string ten = row.Cells["tenmb"].Value.ToString();
                int nam = Convert.ToInt32(row.Cells["namsx"].Value);
                float sogio = Convert.ToSingle(row.Cells["sogiobay"].Value);

                // Gán giá trị vào các TextBox
                txtma.Text = ma;
                txtten.Text = ten;
                txtnam.Text = nam.ToString();
                txtgio.Text = sogio.ToString();
            }
        }
    }
}
