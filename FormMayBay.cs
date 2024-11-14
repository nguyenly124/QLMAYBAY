using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLMAYBAY
{
    public partial class FormMayBay : Form
    {
        public FormMayBay()
        {
            InitializeComponent();
        }
        Ketnoi kn=new Ketnoi();
        private void FormMayBay_Load(object sender, EventArgs e)
        {
           getData();
        }
        public void getData()
        {
            try
            {
                string query = "select * from maybay order by tenmb";
                DataSet ds = kn.LayDuLieu(query);

                if (ds != null && ds.Tables.Count > 0)
                {
                    hienthimaybay.DataSource = ds.Tables[0]; // Gán dữ liệu vào DataGridView
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
    }
}
