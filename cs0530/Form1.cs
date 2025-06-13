namespace cs0530
{
    public partial class Form1 : Form
    {
        int[] vx = new int[3];
        int[] vy = new int[3];
        int counter = 0;

        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            for(int i=0;i<3;i++)
            {
                vx[i] = random.Next(-10, 11);
                vy[i] = random.Next(-10, 11);
            }
        
            label1.Left = random.Next(ClientSize.Width - label1.Width);
            label1.Top = random.Next(ClientSize.Height - label1.Height);
            label4.Left = random.Next(ClientSize.Width - label1.Width);
            label4.Top = random.Next(ClientSize.Height - label1.Height);
            label5.Left = random.Next(ClientSize.Width - label1.Width);
            label5.Top = random.Next(ClientSize.Height - label1.Height);

            //MessageBox.Show($"{label1.Right}{label1.Bottom}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label3.Text = counter.ToString();
            var mpos = MousePosition;

            var fpos = PointToClient(mpos);

            Text = $"{mpos.X},{mpos.Y}/{fpos.X},{fpos.Y}";

            label2.Left = fpos.X - (label2.Width / 2);
            label2.Top = fpos.Y - (label2.Height / 2);


            label4.Left += vx[1];
            label4.Top += vy[1];
            label5.Left += vx[2];
            label5.Top += vx[2];

            label1.Left += vx[0];
            label1.Top += vy[0];
            if (label1.Left < 0)
            {
                vx[0] = Math.Abs(vx[0]) - 1;

            }
            else if (label1.Right > ClientSize.Width)
            {
                vx[0] = -Math.Abs(vx[0]) - 1;
            }
            if (label1.Top < 0)
            {
                vy[0] = Math.Abs(vy[0]) - 1;
            }
            else if (label1.Bottom > ClientSize.Height)
            {
                vy[0] = -Math.Abs(vy[0]) - 1;
            }
            if (mpos.X >= label1.Left && mpos.X <= label1.Right &&
                mpos.Y >= label1.Top && mpos.Y <= label1.Bottom)
            {
                timer1.Enabled = false;
            }
            if (label4.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);
            }
            if (label4.Right > ClientSize.Width)
            {
                vx[1] = -Math.Abs(vx[1]);
            }
            if (label4.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }
            else if (label4.Bottom > ClientSize.Height)
            {
                vy[1] = -Math.Abs(vy[1]);
            }
            if (label5.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            if (label5.Right > ClientSize.Width)
            {
                vx[2] = -Math.Abs(vx[2]);
            }
            if (label5.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);
            }
            if (label5.Bottom > ClientSize.Height)
            { vy[2] = -Math.Abs(vy[2]); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 0;
            timer1.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                {
                    MessageBox.Show($"{i}");
                }
            }
        }
    }
}
