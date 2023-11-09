using System.Media;
namespace PictureBox
{
    public partial class Form1 : Form
    {
        private SoundPlayer music;
        public Form1()
        {
            InitializeComponent();
            music = new SoundPlayer("nhactap.wav");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picNang_Click(object sender, EventArgs e)
        {

        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (!picHa.Visible)
                btnClick.Text = txtInput.Text + "! Click để hạ tạ.";
            else
                btnClick.Text = txtInput.Text + "! Click để nâng tạ.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picHa.Visible = true;
            picNang.Visible = false;
        }

        int count = 1;
        private void btnClick_Click(object sender, EventArgs e)
        {
            if (!picHa.Visible)
            {
                picHa.Visible = true;
                picNang.Visible = false;
                btnClick.Text = btnClick.Text.Replace("hạ", "nâng");
                lblCount.Text = count.ToString();
                count++;
                if (count == 11)
                {
                    DialogResult result = MessageBox.Show("Bạn đã hoàn thành bài tập của hôm nay. Bạn có muốn tiếp tục không ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        Close();
                }
            } else
            {
                picHa.Visible = false;
                picNang.Visible = true;
                btnClick.Text = btnClick.Text.Replace("nâng", "hạ");
            }
        }

        private void chkMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMusic.Checked == true)
                music.Play();
            else
                music.Stop();
        }
    }
}