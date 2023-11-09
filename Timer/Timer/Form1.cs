using System.Media;
namespace Timer
{
    public partial class Form1 : Form
    {
        private int money = 100;
        private Random ran = new Random();
        private bool check = false;
        private SoundPlayer player = new SoundPlayer("music.wav");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (money >= 100)
                MessageBox.Show("Chúc mừng ! Bạn đang có " + money + " xu");
            else 
                MessageBox.Show("Rất tiếc ! Bạn có " + money + " xu");
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (check) return;
            if (money < 20)
                MessageBox.Show("Bạn không đủ 20 xu để chơi !");
            else
            {
                if (chkMusic.Checked)
                    player.Play();
                money -= 20;
                txtMoney.Text = money.ToString();
                timer1.Start();
                check = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (check)
            {
                check = false;
                timer1.Stop();
                if (chkMusic.Checked)
                    player.Stop();
                if (int.Parse(lbl1.Text) == 7)
                    money += 30;
                if (int.Parse(lbl2.Text) == 7)
                    money += 40;
                if (int.Parse(lbl3.Text) == 7)
                    money += 50;
                txtMoney.Text = money.ToString();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl1.Text = ran.Next(0,8).ToString();
            lbl2.Text = ran.Next(0,9).ToString();
            lbl3.Text = ran.Next(0,10).ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            money = 100;
            txtMoney.Text = money.ToString();
            lbl1.Text = lbl2.Text = lbl3.Text = "7";
            if (chkMusic.Checked)
                player.Stop();
        }

        private void lblGuide_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Bấm Start để chơi: Mỗi lần chơi bị trừ 20 xu\n ~ Nếu ô thứ nhất là 7, tiền sẽ tăng thêm 30 xu.\n ~ Nếu ô thứ hai là 7, tiền sẽ tăng thêm 40 xu.\n ~ Nếu ô thứ ba là 7, tiền sẽ tăng thêm 50 xu.", "Hướng dẫn");
        }

        private void chkMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMusic.Checked && check)
                player.Play();
            else
                player.Stop();
        }
    }
}