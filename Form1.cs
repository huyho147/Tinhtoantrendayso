namespace Tinhtoantrendayso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int sodau = Convert.ToInt32(SoDauTxt.Text);
            int socuoi = Convert.ToInt32(SoCuoiTxt.Text);
            int tong = 0, tongchan = 0, tongle = 0, tich = 1;
            
            for (int i = sodau; i <= socuoi; i++)
            {
                tong += i;
                tich *= i;

                if( i % 2 == 0)
                    tongchan += i;
                if( i % 2 != 0)
                    tongle += i;
            }
            TongTxt.Text = tong.ToString();
            TichTxt.Text = tich.ToString();
            TongchanTxt.Text = tongchan.ToString();
            TongleTxt.Text = tongle.ToString();
        }
    }
}
