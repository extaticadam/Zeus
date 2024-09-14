namespace PortfolioUI
{
    partial class PanelTest
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
            panelMenu = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            iconMinimise = new FontAwesome.Sharp.IconPictureBox();
            iconClose = new FontAwesome.Sharp.IconPictureBox();
            iconMaximise = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMinimise).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximise).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(iconButton4);
            panelMenu.Controls.Add(iconButton3);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 945);
            panelMenu.TabIndex = 0;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            iconButton4.ForeColor = Color.Gainsboro;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButton4.IconColor = Color.Gainsboro;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 32;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 320);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(10, 0, 20, 0);
            iconButton4.Size = new Size(220, 60);
            iconButton4.TabIndex = 4;
            iconButton4.Text = "Admin";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            iconButton3.ForeColor = Color.Gainsboro;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButton3.IconColor = Color.Gainsboro;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 260);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(10, 0, 20, 0);
            iconButton3.Size = new Size(220, 60);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "Repeat/Copy";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            iconButton2.ForeColor = Color.Gainsboro;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton2.IconColor = Color.Gainsboro;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 200);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 20, 0);
            iconButton2.Size = new Size(220, 60);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "Search";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 140);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(220, 60);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "New Portfolio";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.aldi;
            btnHome.Location = new Point(3, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(203, 134);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(31, 30, 68);
            panelTitleBar.Controls.Add(iconMinimise);
            panelTitleBar.Controls.Add(iconClose);
            panelTitleBar.Controls.Add(iconMaximise);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1370, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // iconMinimise
            // 
            iconMinimise.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMinimise.BackColor = Color.FromArgb(0, 32, 96);
            iconMinimise.ForeColor = SystemColors.ButtonHighlight;
            iconMinimise.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconMinimise.IconColor = SystemColors.ButtonHighlight;
            iconMinimise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMinimise.Location = new Point(1262, 0);
            iconMinimise.Name = "iconMinimise";
            iconMinimise.Size = new Size(32, 32);
            iconMinimise.TabIndex = 5;
            iconMinimise.TabStop = false;
            iconMinimise.Click += iconMinimise_Click;
            // 
            // iconClose
            // 
            iconClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconClose.BackColor = Color.FromArgb(0, 32, 96);
            iconClose.ForeColor = SystemColors.ButtonHighlight;
            iconClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            iconClose.IconColor = SystemColors.ButtonHighlight;
            iconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconClose.Location = new Point(1338, 0);
            iconClose.Name = "iconClose";
            iconClose.Size = new Size(32, 32);
            iconClose.TabIndex = 4;
            iconClose.TabStop = false;
            iconClose.Click += iconClose_Click;
            // 
            // iconMaximise
            // 
            iconMaximise.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMaximise.BackColor = Color.FromArgb(0, 32, 96);
            iconMaximise.ForeColor = SystemColors.ButtonHighlight;
            iconMaximise.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            iconMaximise.IconColor = SystemColors.ButtonHighlight;
            iconMaximise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMaximise.Location = new Point(1300, 0);
            iconMaximise.Name = "iconMaximise";
            iconMaximise.Size = new Size(32, 32);
            iconMaximise.TabIndex = 3;
            iconMaximise.TabStop = false;
            iconMaximise.Click += iconMaximise_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleChildForm.ForeColor = SystemColors.Control;
            lblTitleChildForm.Location = new Point(53, 14);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(69, 30);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(31, 30, 68);
            iconCurrentChildForm.ForeColor = SystemColors.Control;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = SystemColors.Control;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.Location = new Point(15, 14);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(32, 32);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(26, 24, 58);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(220, 75);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1370, 9);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 84);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1370, 861);
            panelDesktop.TabIndex = 3;
            // 
            // PanelTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1590, 945);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "PanelTest";
            Text = "PanelTest";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconMinimise).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximise).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconMaximise;
        private FontAwesome.Sharp.IconPictureBox iconClose;
        private FontAwesome.Sharp.IconPictureBox iconMinimise;
    }
}