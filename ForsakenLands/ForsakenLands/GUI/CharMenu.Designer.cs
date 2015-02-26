namespace ForsakenLands.GUI
{
    partial class CharMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.charNameLbl = new System.Windows.Forms.Label();
            this.charName = new System.Windows.Forms.TextBox();
            this.classBox = new System.Windows.Forms.GroupBox();
            this.assassinRButton = new System.Windows.Forms.RadioButton();
            this.mageRButton = new System.Windows.Forms.RadioButton();
            this.warriorRButton = new System.Windows.Forms.RadioButton();
            this.classBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // charNameLbl
            // 
            this.charNameLbl.AutoSize = true;
            this.charNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.charNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.charNameLbl.Location = new System.Drawing.Point(247, 263);
            this.charNameLbl.Name = "charNameLbl";
            this.charNameLbl.Size = new System.Drawing.Size(39, 13);
            this.charNameLbl.TabIndex = 1;
            this.charNameLbl.Text = "Name";
            // 
            // charName
            // 
            this.charName.Location = new System.Drawing.Point(292, 260);
            this.charName.Name = "charName";
            this.charName.Size = new System.Drawing.Size(100, 20);
            this.charName.TabIndex = 2;
            // 
            // classBox
            // 
            this.classBox.BackColor = System.Drawing.Color.Transparent;
            this.classBox.Controls.Add(this.assassinRButton);
            this.classBox.Controls.Add(this.mageRButton);
            this.classBox.Controls.Add(this.warriorRButton);
            this.classBox.Location = new System.Drawing.Point(234, 187);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(197, 48);
            this.classBox.TabIndex = 3;
            this.classBox.TabStop = false;
            this.classBox.Text = "Class";
            // 
            // assassinRButton
            // 
            this.assassinRButton.AutoSize = true;
            this.assassinRButton.Location = new System.Drawing.Point(131, 19);
            this.assassinRButton.Name = "assassinRButton";
            this.assassinRButton.Size = new System.Drawing.Size(66, 17);
            this.assassinRButton.TabIndex = 2;
            this.assassinRButton.TabStop = true;
            this.assassinRButton.Text = "Assassin";
            this.assassinRButton.UseVisualStyleBackColor = true;
            // 
            // mageRButton
            // 
            this.mageRButton.AutoSize = true;
            this.mageRButton.Location = new System.Drawing.Point(73, 20);
            this.mageRButton.Name = "mageRButton";
            this.mageRButton.Size = new System.Drawing.Size(52, 17);
            this.mageRButton.TabIndex = 1;
            this.mageRButton.TabStop = true;
            this.mageRButton.Text = "Mage";
            this.mageRButton.UseVisualStyleBackColor = true;
            // 
            // warriorRButton
            // 
            this.warriorRButton.AutoSize = true;
            this.warriorRButton.Location = new System.Drawing.Point(7, 20);
            this.warriorRButton.Name = "warriorRButton";
            this.warriorRButton.Size = new System.Drawing.Size(59, 17);
            this.warriorRButton.TabIndex = 0;
            this.warriorRButton.TabStop = true;
            this.warriorRButton.Text = "Warrior";
            this.warriorRButton.UseVisualStyleBackColor = true;
            // 
            // CharMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(664, 371);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.charName);
            this.Controls.Add(this.charNameLbl);
            this.Controls.Add(this.button1);
            this.Name = "CharMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Menu";
            this.classBox.ResumeLayout(false);
            this.classBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label charNameLbl;
        private System.Windows.Forms.TextBox charName;
        private System.Windows.Forms.GroupBox classBox;
        private System.Windows.Forms.RadioButton assassinRButton;
        private System.Windows.Forms.RadioButton mageRButton;
        private System.Windows.Forms.RadioButton warriorRButton;
    }
}