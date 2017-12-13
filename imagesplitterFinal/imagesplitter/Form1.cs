using System;
using System.Drawing;
using System.Windows.Forms;
namespace imagesplitter
{
    public partial class Form1 : Form
    {
        public bool Started;
        public string Selected = "";
        private PictureBox find(string name)
        {
            foreach (object p in this.Controls)
            {
                if (p.GetType() == typeof(PictureBox))
                    if (((PictureBox)p).Name == name)
                        return (PictureBox)p;
            }
            return new PictureBox(); //OR return null;
        }
        public Form1()
        {
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            InitializeComponent();
            pictureBox1.MouseClick += _ClickEvent;
            pictureBox2.MouseClick += _ClickEvent;
            pictureBox3.MouseClick += _ClickEvent;
            pictureBox4.MouseClick += _ClickEvent;
            pictureBox5.MouseClick += _ClickEvent;
            pictureBox6.MouseClick += _ClickEvent;
            pictureBox7.MouseClick += _ClickEvent;
            pictureBox8.MouseClick += _ClickEvent;
            pictureBox9.MouseClick += _ClickEvent;
        }
        private void _ClickEvent(object sender, EventArgs e)
        {
            Selected = ((PictureBox)sender).Name;
            switch (Selected)
            {
                case "pictureBox1":
                    if (Started == false)
                    {
                        var imagearray = new Image[9];
                        var image = Image.FromFile("C:\\Users\\519-p5\\Desktop\\download3.jpg");
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
                        for (int a = 0; a < 9; a++)
                        {
                            find("pictureBox" + (a + 1)).Image = imagearray[a];
                        }
                        Started = true;
                    }
                    break;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                find(Selected).Location = new Point(find(Selected).Location.X + 10, find(Selected).Location.Y);
            }
            if (e.KeyCode == Keys.A)
            {
                find(Selected).Location = new Point(find(Selected).Location.X - 10, find(Selected).Location.Y);
            }
            if (e.KeyCode == Keys.S)
            {
                find(Selected).Location = new Point(find(Selected).Location.X, find(Selected).Location.Y + 10);
            }
            if (e.KeyCode == Keys.W)
            {
                find(Selected).Location = new Point(find(Selected).Location.X, find(Selected).Location.Y - 10);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
