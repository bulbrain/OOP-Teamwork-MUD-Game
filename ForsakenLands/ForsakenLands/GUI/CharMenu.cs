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
    public partial class CharMenu : Form
    {
        public CharMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = "";
            output += charName.Text;
        }
    }
}
