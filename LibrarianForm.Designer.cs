
namespace Library_Management_System
{
    partial class LibrarianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.booksBtn = new FontAwesome.Sharp.IconButton();
            this.authorsBtn = new FontAwesome.Sharp.IconButton();
            this.genresBtn = new FontAwesome.Sharp.IconButton();
            this.publisherBtn = new FontAwesome.Sharp.IconButton();
            this.usersBtn = new FontAwesome.Sharp.IconButton();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.titleChildLbl = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.windowRestoreBtn = new FontAwesome.Sharp.IconButton();
            this.minimizeBtn = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelMenu.Controls.Add(this.usersBtn);
            this.panelMenu.Controls.Add(this.publisherBtn);
            this.panelMenu.Controls.Add(this.genresBtn);
            this.panelMenu.Controls.Add(this.authorsBtn);
            this.panelMenu.Controls.Add(this.booksBtn);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 953);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panel1.Size = new System.Drawing.Size(250, 140);
            this.panel1.TabIndex = 0;
            // 
            // booksBtn
            // 
            this.booksBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.booksBtn.FlatAppearance.BorderSize = 0;
            this.booksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.booksBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.booksBtn.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.booksBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.booksBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.booksBtn.IconSize = 42;
            this.booksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booksBtn.Location = new System.Drawing.Point(0, 140);
            this.booksBtn.Name = "booksBtn";
            this.booksBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.booksBtn.Size = new System.Drawing.Size(250, 70);
            this.booksBtn.TabIndex = 1;
            this.booksBtn.Text = "Книги";
            this.booksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.booksBtn.UseVisualStyleBackColor = true;
            this.booksBtn.Click += new System.EventHandler(this.booksBtn_Click);
            // 
            // authorsBtn
            // 
            this.authorsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorsBtn.FlatAppearance.BorderSize = 0;
            this.authorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorsBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorsBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.authorsBtn.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.authorsBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.authorsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.authorsBtn.IconSize = 42;
            this.authorsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authorsBtn.Location = new System.Drawing.Point(0, 210);
            this.authorsBtn.Name = "authorsBtn";
            this.authorsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.authorsBtn.Size = new System.Drawing.Size(250, 70);
            this.authorsBtn.TabIndex = 2;
            this.authorsBtn.Text = "Автори";
            this.authorsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authorsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.authorsBtn.UseVisualStyleBackColor = true;
            this.authorsBtn.Click += new System.EventHandler(this.authorsBtn_Click);
            // 
            // genresBtn
            // 
            this.genresBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.genresBtn.FlatAppearance.BorderSize = 0;
            this.genresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genresBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genresBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.genresBtn.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.genresBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.genresBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.genresBtn.IconSize = 42;
            this.genresBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genresBtn.Location = new System.Drawing.Point(0, 280);
            this.genresBtn.Name = "genresBtn";
            this.genresBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.genresBtn.Size = new System.Drawing.Size(250, 70);
            this.genresBtn.TabIndex = 3;
            this.genresBtn.Text = "Жанри";
            this.genresBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.genresBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.genresBtn.UseVisualStyleBackColor = true;
            this.genresBtn.Click += new System.EventHandler(this.genresBtn_Click);
            // 
            // publisherBtn
            // 
            this.publisherBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.publisherBtn.FlatAppearance.BorderSize = 0;
            this.publisherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publisherBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.publisherBtn.IconChar = FontAwesome.Sharp.IconChar.HouseFlag;
            this.publisherBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.publisherBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.publisherBtn.IconSize = 42;
            this.publisherBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.publisherBtn.Location = new System.Drawing.Point(0, 350);
            this.publisherBtn.Name = "publisherBtn";
            this.publisherBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.publisherBtn.Size = new System.Drawing.Size(250, 70);
            this.publisherBtn.TabIndex = 4;
            this.publisherBtn.Text = "Видавництва";
            this.publisherBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.publisherBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.publisherBtn.UseVisualStyleBackColor = true;
            this.publisherBtn.Click += new System.EventHandler(this.publisherBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersBtn.FlatAppearance.BorderSize = 0;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.usersBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.usersBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.usersBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.usersBtn.IconSize = 42;
            this.usersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersBtn.Location = new System.Drawing.Point(0, 420);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.usersBtn.Size = new System.Drawing.Size(250, 70);
            this.usersBtn.TabIndex = 5;
            this.usersBtn.Text = "Користувачі";
            this.usersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.Location = new System.Drawing.Point(0, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(250, 140);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeBtn.TabIndex = 1;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.panelTitleBar.Controls.Add(this.minimizeBtn);
            this.panelTitleBar.Controls.Add(this.windowRestoreBtn);
            this.panelTitleBar.Controls.Add(this.closeBtn);
            this.panelTitleBar.Controls.Add(this.titleChildLbl);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1400, 100);
            this.panelTitleBar.TabIndex = 1;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(114)))), ((int)(((byte)(252)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(114)))), ((int)(((byte)(252)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(39, 31);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // titleChildLbl
            // 
            this.titleChildLbl.AutoSize = true;
            this.titleChildLbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleChildLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.titleChildLbl.Location = new System.Drawing.Point(96, 31);
            this.titleChildLbl.Name = "titleChildLbl";
            this.titleChildLbl.Size = new System.Drawing.Size(104, 37);
            this.titleChildLbl.TabIndex = 1;
            this.titleChildLbl.Text = "Home";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(250, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1400, 853);
            this.panelDesktop.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(481, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 24;
            this.closeBtn.Location = new System.Drawing.Point(1372, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 24);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // windowRestoreBtn
            // 
            this.windowRestoreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowRestoreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.windowRestoreBtn.FlatAppearance.BorderSize = 0;
            this.windowRestoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowRestoreBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.windowRestoreBtn.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.windowRestoreBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.windowRestoreBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.windowRestoreBtn.IconSize = 24;
            this.windowRestoreBtn.Location = new System.Drawing.Point(1341, 3);
            this.windowRestoreBtn.Name = "windowRestoreBtn";
            this.windowRestoreBtn.Size = new System.Drawing.Size(25, 24);
            this.windowRestoreBtn.TabIndex = 3;
            this.windowRestoreBtn.UseVisualStyleBackColor = false;
            this.windowRestoreBtn.Click += new System.EventHandler(this.windowRestoreBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeBtn.IconSize = 24;
            this.minimizeBtn.Location = new System.Drawing.Point(1310, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(25, 24);
            this.minimizeBtn.TabIndex = 4;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // LibrarianForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1650, 953);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "LibrarianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarianForm";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton booksBtn;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton usersBtn;
        private FontAwesome.Sharp.IconButton publisherBtn;
        private FontAwesome.Sharp.IconButton genresBtn;
        private FontAwesome.Sharp.IconButton authorsBtn;
        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label titleChildLbl;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton closeBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private FontAwesome.Sharp.IconButton windowRestoreBtn;
    }
}