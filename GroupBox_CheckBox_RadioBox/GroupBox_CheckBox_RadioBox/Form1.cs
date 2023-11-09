namespace GroupBox_CheckBox_RadioBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked) lblOutput.ForeColor = radBlack.ForeColor;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked) lblOutput.ForeColor = radBlue.ForeColor;
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            chkBold.Checked = true;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Text = txtInput.Text;

        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked) lblOutput.ForeColor = radRed.ForeColor;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked) lblOutput.ForeColor = radGreen.ForeColor;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(
                lblOutput.Font.Name,
                lblOutput.Font.Size,
                lblOutput.Font.Style ^ FontStyle.Bold
            );
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(
                lblOutput.Font.Name,
                lblOutput.Font.Size,
                lblOutput.Font.Style ^ FontStyle.Italic
            );
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(
                lblOutput.Font.Name,
                lblOutput.Font.Size,
                lblOutput.Font.Style ^ FontStyle.Underline
            );
        }
    }
}