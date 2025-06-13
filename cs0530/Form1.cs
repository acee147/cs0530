namespace cs0530
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        int counter = 0;
        int a = 10;
        int b = 10;
        int c = 10;
        int d = 10;
        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            vx = random.Next(-10, 11);
            vy = random.Next(-10, 11);
            a= random.Next(-10, 11);
            b= random.Next(-10,11); 
            c= random.Next(-10,11);
            d = random.Next(-10, 11);
            label1.Left = random.Next(ClientSize.Width - label1.Width);
            label1.Top = random.Next(ClientSize.Height - label1.Height);


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
            

            label4.Left += a;
            label4.Top += b;
           label5.Left += c;
            label5.Top += d;

            label1.Left += vx;
            label1.Top += vy;
            if (label1.Left < 0)
            {
                vx = Math.Abs(vx) - 1;

            }
            else if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx) - 1;
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy) - 1;
            }
            else if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy) - 1;
            }
            if (mpos.X >= label1.Left && mpos.X <= label1.Right &&
                mpos.Y >= label1.Top && mpos.Y <= label1.Bottom)
            {
                timer1.Enabled = false;
            }
            if(label4.Left < 0) {
                a = Math.Abs(a);
            }
            if (label4.Right > ClientSize.Width)
            {
                a = -Math.Abs(a);
            }
            if(label4.Top < 0)
            {
                b = Math.Abs(b);
            }
            else if (label4.Bottom > ClientSize.Height)
            {
                b = -Math.Abs(b);
            }
            if (label5.Left < 0)
            {
                c = Math.Abs(c);
            }
            if (label5.Right > ClientSize.Width)
            {
                c = -Math.Abs(c);
            }
            if (label5.Top < 0)
            { 
                d = Math.Abs(d);
            }
            if (label5.Bottom > ClientSize.Height)
            { d = -Math.Abs(d); }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 0;
            timer1.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
