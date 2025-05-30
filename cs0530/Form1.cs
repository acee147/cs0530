namespace cs0530
{
    public partial class Form1 : Form
    {
        int vx = -20;
        int vy = -20;
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show($"{label1.Right}{label1.Bottom}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
               
            }
            else if (label1.Right > ClientSize.Height)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
           else if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }
        }
    }
}
