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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            CharMenu charMenu = new CharMenu();
            charMenu.Show();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            optionsButton.Visible = false;
            creditsButton.Visible = false;
            playButton.Visible = false;
            exitButton.Text = "Back";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (exitButton.Text.Equals("Back"))
            {
                optionsButton.Visible = true;
                creditsButton.Visible = true;
                playButton.Visible = true;
                exitButton.Text = "Exit";
            }
            else
            {
                Application.Exit();
            }
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
