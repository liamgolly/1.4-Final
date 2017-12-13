
using System;
using System.Drawing;
using System.Windows.Forms;
namespace imagesplitter
{
    public partial class Form1 : Form
    {
        public bool Dragging;
        public int Selected = 1;
        public Form1()
        {
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Dragging == false)
            {
                var imagearray = new Image[9];
                var image = Image.FromFile("C:\\Users\\Liam\\Desktop\\download.jpg");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        var n = i * 3 + j;
                        imagearray[n] = new Bitmap(640, 360);
                        var graphics = Graphics.FromImage(imagearray[n]);
                        graphics.DrawImage(image, new Rectangle(0, 0, 640, 360), new Rectangle(i * 640, j * 360, 640, 360), GraphicsUnit.Pixel);
                        graphics.Dispose();
                    }
                }
                pictureBox1.Image = imagearray[0];
                pictureBox2.Image = imagearray[1];
                pictureBox3.Image = imagearray[2];
                pictureBox4.Image = imagearray[3];
                pictureBox5.Image = imagearray[4];
                pictureBox6.Image = imagearray[5];
                pictureBox7.Image = imagearray[6];
                pictureBox8.Image = imagearray[7];
                pictureBox9.Image = imagearray[8];
                Dragging = true;
            }
            else
            {
                Selected = 1;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Selected = 2;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Selected = 3;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Selected = 4;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Selected = 5;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Selected = 6;
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Selected = 7;
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Selected = 8;
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Selected = 9;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {               
                if (Selected == 1) pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);   
                else if (Selected == 2) pictureBox2.Location = new Point(pictureBox2.Location.X + 10, pictureBox2.Location.Y); 
                else if (Selected == 3) pictureBox3.Location = new Point(pictureBox3.Location.X + 10, pictureBox3.Location.Y);
                else if (Selected == 4) pictureBox4.Location = new Point(pictureBox4.Location.X + 10, pictureBox4.Location.Y);
                else if (Selected == 5) pictureBox5.Location = new Point(pictureBox5.Location.X + 10, pictureBox5.Location.Y);
                else if (Selected == 6) pictureBox6.Location = new Point(pictureBox6.Location.X + 10, pictureBox6.Location.Y);
                else if (Selected == 7) pictureBox7.Location = new Point(pictureBox7.Location.X + 10, pictureBox7.Location.Y);
                else if (Selected == 8) pictureBox8.Location = new Point(pictureBox8.Location.X + 10, pictureBox8.Location.Y);
                else pictureBox9.Location = new Point(pictureBox9.Location.X + 10, pictureBox9.Location.Y);
            }
            if (e.KeyCode == Keys.A)
            {
                if (Selected == 1) pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
                else if (Selected == 2) pictureBox2.Location = new Point(pictureBox2.Location.X - 10, pictureBox2.Location.Y);
                else if (Selected == 3) pictureBox3.Location = new Point(pictureBox3.Location.X - 10, pictureBox3.Location.Y);
                else if (Selected == 4) pictureBox4.Location = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y);
                else if (Selected == 5) pictureBox5.Location = new Point(pictureBox5.Location.X - 10, pictureBox5.Location.Y);
                else if (Selected == 6) pictureBox6.Location = new Point(pictureBox6.Location.X - 10, pictureBox6.Location.Y);
                else if (Selected == 7) pictureBox7.Location = new Point(pictureBox7.Location.X - 10, pictureBox7.Location.Y);
                else if (Selected == 8) pictureBox8.Location = new Point(pictureBox8.Location.X - 10, pictureBox8.Location.Y);
                else pictureBox9.Location = new Point(pictureBox9.Location.X - 10, pictureBox9.Location.Y);
            }
            if (e.KeyCode == Keys.S)
            {
                if (Selected == 1) pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
                else if (Selected == 2) pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 10);
                else if (Selected == 3) pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 10);
                else if (Selected == 4) pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + 10);
                else if (Selected == 5) pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + 10);
                else if (Selected == 6) pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 10);
                else if (Selected == 7) pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y + 10);
                else if (Selected == 8) pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y + 10);
                else pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y + 10);
            }
            if (e.KeyCode == Keys.W)
            {
                if (Selected == 1) pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
                else if (Selected == 2) pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 10);
                else if (Selected == 3) pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - 10);
                else if (Selected == 4) pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y - 10);
                else if (Selected == 5) pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y - 10);
                else if (Selected == 6) pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y - 10);
                else if (Selected == 7) pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y - 10);
                else if (Selected == 8) pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y - 10);
                else pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y - 10);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
