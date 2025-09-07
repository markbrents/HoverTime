namespace HoverTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Opacity = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            notifyIcon1.Text = DateTime.Now.ToLongTimeString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
