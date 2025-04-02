namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private long fib(long num)
        {
            if (num == 0)
            {
                return 0;
            }
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return fib(num - 1) + fib(num - 2);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long num;
            if (long.TryParse(textBox2.Text, out num) && num >= 0)
            {
                long result = fib(num);
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("請輸入有效的非負整數");
            }
        }
    }
}