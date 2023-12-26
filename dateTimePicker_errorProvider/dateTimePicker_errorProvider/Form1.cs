namespace dateTimePicker_errorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
                //abcbcbaba
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool check = true;
            if (txtPhone.Text == "")
            {
                check = false;
                errorProvider1.SetError(txtPhone, "Chưa nhập số điện thoại !");
            }

            int tuoi = 0;
            if (int.TryParse(txtTuoi.Text, out tuoi) == false)
            {
                check = false;
                errorProvider1.SetError(txtTuoi, "Sai định dạng !");
            } else if (tuoi < 18)
            {
                check = false;
                errorProvider1.SetError(txtTuoi, "Yêu cầu trên 17 tuổi !");
            }

            if (dtpDK.Value.DayOfWeek == DayOfWeek.Monday)
            {
                check = false;
                errorProvider1.SetError(dtpDK, "Phim không chiếu vào thứ hai !");
            }

            if (check)
            {
                MessageBox.Show("Đăng ký thành công. Cảm ơn bạn !");
                Close();
            }
        }
    }
}
