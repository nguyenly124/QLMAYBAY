namespace QLMAYBAY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMayBay form = new FormMayBay();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormThem form = new FormThem();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSua form = new FormSua();
            form.Show();
        }
    }
}
