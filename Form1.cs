namespace bouncing_ball
{
    public partial class Form1 : Form
    {
        private int ballWidth =200;
        private int ballHeight = 200;
        private int ballPosX = 100;
        private int ballPosY = 50;
        private int moveStepX = 4;
        private int moveStepY = 4;
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        private void MoveBall(object sender, EventArgs e)
        {
            ballPosX += moveStepX;
            if (ballPosX < 0 ||
                ballPosX + ballWidth > this.ClientSize.Width)
            {
                moveStepX = -moveStepX;
            }

            ballPosY += moveStepY;
            if (ballPosY < 0 ||
                ballPosY + ballHeight > this.ClientSize.Height)
            {
                moveStepY = -moveStepY;
            }
            this.Refresh();
        }

        private void PrintCircle(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.BackColor);
            e.Graphics.FillEllipse(Brushes.Purple, ballPosX, ballPosY, ballWidth, ballHeight);
            e.Graphics.DrawEllipse(Pens.Black, ballPosX, ballPosY, ballWidth, ballHeight);
        }
    }
}