namespace hover
{
    public partial class Form1 : Form
    {
        DateTime startTime;
        public Form1()
        {

            InitializeComponent();
            //button1.MouseEnter += button1_MouseEnter;
            //button1.MouseLeave += button1_MouseLeave;
            timer1.Tick += timer1_Tick;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer1.Start();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime;
            label1.Text = $"Hover: {elapsed.TotalSeconds:F2} sekundy";
        }

    }
}
