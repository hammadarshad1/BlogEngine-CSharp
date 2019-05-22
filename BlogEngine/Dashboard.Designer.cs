namespace BlogEngine
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.themeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.aboutBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.profileBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logoutBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.userLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.blogtxt = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.themeBtn);
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.profileBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 525);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BlogEngine.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // themeBtn
            // 
            this.themeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.themeBtn.BackColor = System.Drawing.Color.Turquoise;
            this.themeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.themeBtn.BorderRadius = 0;
            this.themeBtn.ButtonText = "Write a Blog";
            this.themeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.themeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.themeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.themeBtn.Iconimage = global::BlogEngine.Properties.Resources.user;
            this.themeBtn.Iconimage_right = null;
            this.themeBtn.Iconimage_right_Selected = null;
            this.themeBtn.Iconimage_Selected = null;
            this.themeBtn.IconMarginLeft = 0;
            this.themeBtn.IconMarginRight = 0;
            this.themeBtn.IconRightVisible = true;
            this.themeBtn.IconRightZoom = 0D;
            this.themeBtn.IconVisible = true;
            this.themeBtn.IconZoom = 60D;
            this.themeBtn.IsTab = false;
            this.themeBtn.Location = new System.Drawing.Point(-1, 215);
            this.themeBtn.Name = "themeBtn";
            this.themeBtn.Normalcolor = System.Drawing.Color.Turquoise;
            this.themeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.themeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.themeBtn.selected = false;
            this.themeBtn.Size = new System.Drawing.Size(218, 48);
            this.themeBtn.TabIndex = 2;
            this.themeBtn.Text = "Write a Blog";
            this.themeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.themeBtn.Textcolor = System.Drawing.Color.Black;
            this.themeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeBtn.Click += new System.EventHandler(this.ThemeBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.aboutBtn.BackColor = System.Drawing.Color.Turquoise;
            this.aboutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutBtn.BorderRadius = 0;
            this.aboutBtn.ButtonText = "About";
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.DisabledColor = System.Drawing.Color.Gray;
            this.aboutBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.aboutBtn.Iconimage = global::BlogEngine.Properties.Resources.user;
            this.aboutBtn.Iconimage_right = null;
            this.aboutBtn.Iconimage_right_Selected = null;
            this.aboutBtn.Iconimage_Selected = null;
            this.aboutBtn.IconMarginLeft = 0;
            this.aboutBtn.IconMarginRight = 0;
            this.aboutBtn.IconRightVisible = true;
            this.aboutBtn.IconRightZoom = 0D;
            this.aboutBtn.IconVisible = true;
            this.aboutBtn.IconZoom = 60D;
            this.aboutBtn.IsTab = false;
            this.aboutBtn.Location = new System.Drawing.Point(-2, 307);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Normalcolor = System.Drawing.Color.Turquoise;
            this.aboutBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.aboutBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.aboutBtn.selected = false;
            this.aboutBtn.Size = new System.Drawing.Size(218, 48);
            this.aboutBtn.TabIndex = 2;
            this.aboutBtn.Text = "About";
            this.aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn.Textcolor = System.Drawing.Color.Black;
            this.aboutBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.profileBtn.BackColor = System.Drawing.Color.Turquoise;
            this.profileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileBtn.BorderRadius = 0;
            this.profileBtn.ButtonText = "Profile";
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.DisabledColor = System.Drawing.Color.Gray;
            this.profileBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.profileBtn.Iconimage = global::BlogEngine.Properties.Resources.user;
            this.profileBtn.Iconimage_right = null;
            this.profileBtn.Iconimage_right_Selected = null;
            this.profileBtn.Iconimage_Selected = null;
            this.profileBtn.IconMarginLeft = 0;
            this.profileBtn.IconMarginRight = 0;
            this.profileBtn.IconRightVisible = true;
            this.profileBtn.IconRightZoom = 0D;
            this.profileBtn.IconVisible = true;
            this.profileBtn.IconZoom = 60D;
            this.profileBtn.IsTab = false;
            this.profileBtn.Location = new System.Drawing.Point(-1, 260);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Normalcolor = System.Drawing.Color.Turquoise;
            this.profileBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.profileBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.profileBtn.selected = false;
            this.profileBtn.Size = new System.Drawing.Size(218, 48);
            this.profileBtn.TabIndex = 2;
            this.profileBtn.Text = "Profile";
            this.profileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileBtn.Textcolor = System.Drawing.Color.Black;
            this.profileBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // logoutBtn
            // 
            this.logoutBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.logoutBtn.BackColor = System.Drawing.Color.Turquoise;
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutBtn.BorderRadius = 0;
            this.logoutBtn.ButtonText = "Log Out";
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.DisabledColor = System.Drawing.Color.Gray;
            this.logoutBtn.ForeColor = System.Drawing.Color.Black;
            this.logoutBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.logoutBtn.Iconimage = global::BlogEngine.Properties.Resources.logout;
            this.logoutBtn.Iconimage_right = null;
            this.logoutBtn.Iconimage_right_Selected = null;
            this.logoutBtn.Iconimage_Selected = null;
            this.logoutBtn.IconMarginLeft = 0;
            this.logoutBtn.IconMarginRight = 0;
            this.logoutBtn.IconRightVisible = true;
            this.logoutBtn.IconRightZoom = 0D;
            this.logoutBtn.IconVisible = true;
            this.logoutBtn.IconZoom = 60D;
            this.logoutBtn.IsTab = false;
            this.logoutBtn.Location = new System.Drawing.Point(0, 353);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Normalcolor = System.Drawing.Color.Turquoise;
            this.logoutBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.logoutBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.logoutBtn.selected = false;
            this.logoutBtn.Size = new System.Drawing.Size(217, 48);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Textcolor = System.Drawing.Color.Black;
            this.logoutBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.Font = new System.Drawing.Font("Caladea", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(284, 56);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(102, 41);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "demo";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(809, 549);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 218;
            this.lineShape1.X2 = 218;
            this.lineShape1.Y1 = 0;
            this.lineShape1.Y2 = 549;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Controls.Add(this.blogtxt);
            this.panel2.Location = new System.Drawing.Point(257, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 397);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(37, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Red;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Clear";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(36, 263);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Red;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(166, 48);
            this.bunifuFlatButton2.TabIndex = 1;
            this.bunifuFlatButton2.Text = "Clear";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Submit";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(315, 263);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(166, 48);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "Submit";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click_1);
            // 
            // blogtxt
            // 
            this.blogtxt.Location = new System.Drawing.Point(36, 55);
            this.blogtxt.Name = "blogtxt";
            this.blogtxt.Size = new System.Drawing.Size(445, 177);
            this.blogtxt.TabIndex = 0;
            this.blogtxt.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPostToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.fileToolStripMenuItem.Text = "Software";
            // 
            // newPostToolStripMenuItem
            // 
            this.newPostToolStripMenuItem.Name = "newPostToolStripMenuItem";
            this.newPostToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newPostToolStripMenuItem.Text = "New Post";
            this.newPostToolStripMenuItem.Click += new System.EventHandler(this.NewPostToolStripMenuItem_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Image = global::BlogEngine.Properties.Resources.keyboard_left_arrow_button1;
            this.backBtn.Location = new System.Drawing.Point(254, 66);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(43, 29);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 7;
            this.backBtn.TabStop = false;
            this.backBtn.Visible = false;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = global::BlogEngine.Properties.Resources.color_2174043_1280;
            this.ClientSize = new System.Drawing.Size(809, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton logoutBtn;
        private Bunifu.Framework.UI.BunifuFlatButton profileBtn;
        private Bunifu.Framework.UI.BunifuFlatButton themeBtn;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label userLabel;
        private Bunifu.Framework.UI.BunifuFlatButton aboutBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.RichTextBox blogtxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPostToolStripMenuItem;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}