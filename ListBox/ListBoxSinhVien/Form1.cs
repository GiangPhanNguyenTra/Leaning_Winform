namespace ListBoxSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = txtMa.Text;
            sv.Name = txtName.Text;
            string temp = sv.MSSV + "\t" + sv.Name;
            lstSV.Items.Add(temp);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả dữ liệu trong danh sách ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                lstSV.Items.Clear();
        }

        private void XoaCuoi_Click(object sender, EventArgs e)
        {
            lstSV.Items.RemoveAt(lstSV.Items.Count - 1);
        }
    }
}