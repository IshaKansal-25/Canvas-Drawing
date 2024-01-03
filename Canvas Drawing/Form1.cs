using System;
using System.Drawing;
using System.Windows.Forms;

namespace Canvas_Drawing
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void drawRect_Click(object sender, EventArgs e)
        {
            using (Graphics g = pictureBox.CreateGraphics())
            {
                int x = random.Next(pictureBox.Width - 70);
                int y = random.Next(pictureBox.Height - 70);
                int width = random.Next(50,200);
                int height = random.Next(10,150);

                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                g.FillRectangle(new SolidBrush(color), x, y, width, height);
            }
        }

        private void drawCircle_Click(object sender, EventArgs e)
        {
            using (Graphics g = pictureBox.CreateGraphics())
            {
                int x = random.Next(pictureBox.Width - 100);
                int y = random.Next(pictureBox.Height - 100);
                int diameter = random.Next(50, 100);

                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                g.FillEllipse(new SolidBrush(color), x, y, diameter, diameter);
            }
        }

        private void drawText_Click(object sender, EventArgs e)
        {
            string text = textBox.Text;

            using (Graphics g = pictureBox.CreateGraphics())
            {
                int x = random.Next(pictureBox.Width - 70);
                int y = random.Next(pictureBox.Height - 70);
                Font font = new Font("Arial", 16);
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                g.DrawString(text, font, new SolidBrush(color), new Point(x, y));
            }
        }
    }
}
