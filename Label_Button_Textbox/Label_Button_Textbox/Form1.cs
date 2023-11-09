namespace Label_Button_Textbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tong;
            tong = Convert.ToInt32(txtA.Text) + Convert.ToInt32(txtB.Text);
            lblKQ.Text = txtA.Text + " + " + txtB.Text + " = " + tong;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu;
            hieu = Convert.ToInt32(txtA.Text) - Convert.ToInt32(txtB.Text);
            lblKQ.Text = txtA.Text + " - " + txtB.Text + " = " + hieu;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                            ("Bạn chắc chắn muốn Reset?", 
                            "Confirm", 
                           MessageBoxButtons.YesNo, 
                           MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lblKQ.Text = "Kết quả";
                txtA.Text = txtB.Text = "";
            } else
            {
                MessageBox.Show("Ồ, vậy thôi.");
            }
            
        }
    }
}