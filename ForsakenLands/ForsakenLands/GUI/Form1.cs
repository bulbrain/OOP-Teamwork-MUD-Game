using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ForsakenLands.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form1_KeyDown);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            {
                if (x < 250 && y < 10)
                {
                    var img = new Bitmap(ForsakenLands.Properties.Resources.dungeon2);
                    this.BackgroundImage = new Bitmap(img);
                    x = 300;
                    y = 310;
                }
                else if (e.KeyCode == Keys.Right)
                { x += 4; Update(); }
                else if (e.KeyCode == Keys.Left)
                { x -= 4; Update(); }
                else if (e.KeyCode == Keys.Up)
                { y -= 4; Update(); }
                else if (e.KeyCode == Keys.Down)
                { y += 4; Update(); }
                    
            }
            pictureBox1.Location = new System.Drawing.Point(x, y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
