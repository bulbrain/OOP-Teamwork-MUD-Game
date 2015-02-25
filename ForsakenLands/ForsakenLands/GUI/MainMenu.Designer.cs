namespace ForsakenLands.GUI
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Tittle_label = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.creditsButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.passLbl = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tittle_label
            // 
            this.Tittle_label.AutoSize = true;
            this.Tittle_label.BackColor = System.Drawing.Color.Transparent;
            this.Tittle_label.Font = new System.Drawing.Font("Blackadder ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle_label.Location = new System.Drawing.Point(-1, 9);
            this.Tittle_label.Name = "Tittle_label";
            this.Tittle_label.Size = new System.Drawing.Size(393, 82);
            this.Tittle_label.TabIndex = 0;
            this.Tittle_label.Text = "Forsaken Lands";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(307, 288);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.login_button_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(307, 317);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.register_button_Click);
            // 
            // creditsButton
            // 
            this.creditsButton.Location = new System.Drawing.Point(577, 317);
            this.creditsButton.Name = "creditsButton";
            this.creditsButton.Size = new System.Drawing.Size(75, 23);
            this.creditsButton.TabIndex = 3;
            this.creditsButton.Text = "Credits";
            this.creditsButton.UseVisualStyleBackColor = true;
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(577, 288);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(75, 23);
            this.optionsButton.TabIndex = 4;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(34, 316);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.BackColor = System.Drawing.Color.Transparent;
            this.passLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLbl.Location = new System.Drawing.Point(237, 256);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(61, 13);
            this.passLbl.TabIndex = 6;
            this.passLbl.Text = "Password";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.BackColor = System.Drawing.Color.Transparent;
            this.userLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLbl.Location = new System.Drawing.Point(261, 234);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(33, 13);
            this.userLbl.TabIndex = 7;
            this.userLbl.Text = "User";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(296, 253);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(100, 20);
            this.passwordTxt.TabIndex = 8;
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(296, 227);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(100, 20);
            this.userTxt.TabIndex = 9;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(664, 371);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.creditsButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.Tittle_label);
            this.Name = "MainMenu";
            this.Text = "Main_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tittle_label;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button creditsButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button exitButton;
        public System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox userTxt;
    }
}