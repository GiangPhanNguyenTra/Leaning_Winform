namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtNhap.Text);
            lstDS.Items.Add(x);
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            lstDS.Items.RemoveAt(0);
            lstDS.Items.RemoveAt(lstDS.Items.Count - 1);
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int x in lstDS.Items)
            {
                sum += x;
            }
            MessageBox.Show("Tổng của danh sách số: " + sum);
        }

        private void btnXoaPTChon_Click(object sender, EventArgs e)
        {
            while (lstDS.SelectedIndex != -1)
            {
                lstDS.Items.RemoveAt(lstDS.SelectedIndex);
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDS.Items.Count; i++)
            {
                int k = (int)lstDS.Items[i] + 2;
                lstDS.Items[i] = k;
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDS.Items.Count; i++)
            {
                int k = (int)lstDS.Items[i] * (int)lstDS.Items[i];
                lstDS.Items[i] = k;
            }
        }

        private void btnChonChan_Click(object sender, EventArgs e)
        {
            lstDS.SelectedIndex = -1;
            for (int i = 0; i < lstDS.Items.Count; i++)
            {
                int k = (int)lstDS.Items[i];
                if (k % 2 == 0) lstDS.SelectedIndex = i;
            }
        }

        private void btnChonLe_Click(object sender, EventArgs e)
        {
            lstDS.SelectedIndex = -1;
            for (int i = 0; i < lstDS.Items.Count; i++)
            {
                int k = (int)lstDS.Items[i];
                if (k % 2 == 1) lstDS.SelectedIndex = i;
            }
        }
    }
}