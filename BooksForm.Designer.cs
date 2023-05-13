
namespace Library_Management_System
{
    partial class BooksForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.refresh_btn = new FontAwesome.Sharp.IconButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lang_rbtn = new System.Windows.Forms.RadioButton();
            this.all_rbtn = new System.Windows.Forms.RadioButton();
            this.genre_rbtn = new System.Windows.Forms.RadioButton();
            this.title_rbtn = new System.Windows.Forms.RadioButton();
            this.litDir_rbtn = new System.Windows.Forms.RadioButton();
            this.author_rbtn = new System.Windows.Forms.RadioButton();
            this.pages_rbtn = new System.Windows.Forms.RadioButton();
            this.pub_rbtn = new System.Windows.Forms.RadioButton();
            this.year_rbtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.edit_btn = new FontAwesome.Sharp.IconButton();
            this.delete_btn = new FontAwesome.Sharp.IconButton();
            this.add_btn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1338, 443);
            this.dataGridView.TabIndex = 0;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.refresh_btn.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.refresh_btn.IconColor = System.Drawing.Color.Gainsboro;
            this.refresh_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.refresh_btn.IconSize = 44;
            this.refresh_btn.Location = new System.Drawing.Point(1266, 33);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(44, 44);
            this.refresh_btn.TabIndex = 6;
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.TopPanel.Controls.Add(this.groupBox1);
            this.TopPanel.Controls.Add(this.label2);
            this.TopPanel.Controls.Add(this.searchbox);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.refresh_btn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1338, 110);
            this.TopPanel.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lang_rbtn);
            this.groupBox1.Controls.Add(this.all_rbtn);
            this.groupBox1.Controls.Add(this.genre_rbtn);
            this.groupBox1.Controls.Add(this.title_rbtn);
            this.groupBox1.Controls.Add(this.litDir_rbtn);
            this.groupBox1.Controls.Add(this.author_rbtn);
            this.groupBox1.Controls.Add(this.pages_rbtn);
            this.groupBox1.Controls.Add(this.pub_rbtn);
            this.groupBox1.Controls.Add(this.year_rbtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(629, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 104);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lang_rbtn
            // 
            this.lang_rbtn.AutoSize = true;
            this.lang_rbtn.Location = new System.Drawing.Point(340, 75);
            this.lang_rbtn.Name = "lang_rbtn";
            this.lang_rbtn.Size = new System.Drawing.Size(130, 21);
            this.lang_rbtn.TabIndex = 18;
            this.lang_rbtn.Text = "Мова оригіналу";
            this.lang_rbtn.UseVisualStyleBackColor = true;
            // 
            // all_rbtn
            // 
            this.all_rbtn.AutoSize = true;
            this.all_rbtn.Checked = true;
            this.all_rbtn.Location = new System.Drawing.Point(6, 21);
            this.all_rbtn.Name = "all_rbtn";
            this.all_rbtn.Size = new System.Drawing.Size(112, 21);
            this.all_rbtn.TabIndex = 10;
            this.all_rbtn.TabStop = true;
            this.all_rbtn.Text = "Вся таблиця";
            this.all_rbtn.UseVisualStyleBackColor = true;
            // 
            // genre_rbtn
            // 
            this.genre_rbtn.AutoSize = true;
            this.genre_rbtn.Location = new System.Drawing.Point(340, 48);
            this.genre_rbtn.Name = "genre_rbtn";
            this.genre_rbtn.Size = new System.Drawing.Size(66, 21);
            this.genre_rbtn.TabIndex = 17;
            this.genre_rbtn.Text = "Жанр";
            this.genre_rbtn.UseVisualStyleBackColor = true;
            // 
            // title_rbtn
            // 
            this.title_rbtn.AutoSize = true;
            this.title_rbtn.Location = new System.Drawing.Point(6, 49);
            this.title_rbtn.Name = "title_rbtn";
            this.title_rbtn.Size = new System.Drawing.Size(69, 21);
            this.title_rbtn.TabIndex = 11;
            this.title_rbtn.Text = "Назва";
            this.title_rbtn.UseVisualStyleBackColor = true;
            // 
            // litDir_rbtn
            // 
            this.litDir_rbtn.AutoSize = true;
            this.litDir_rbtn.Location = new System.Drawing.Point(340, 21);
            this.litDir_rbtn.Name = "litDir_rbtn";
            this.litDir_rbtn.Size = new System.Drawing.Size(172, 21);
            this.litDir_rbtn.TabIndex = 16;
            this.litDir_rbtn.Text = "Літературний напрям";
            this.litDir_rbtn.UseVisualStyleBackColor = true;
            // 
            // author_rbtn
            // 
            this.author_rbtn.AutoSize = true;
            this.author_rbtn.Location = new System.Drawing.Point(7, 75);
            this.author_rbtn.Name = "author_rbtn";
            this.author_rbtn.Size = new System.Drawing.Size(68, 21);
            this.author_rbtn.TabIndex = 12;
            this.author_rbtn.Text = "Автор";
            this.author_rbtn.UseVisualStyleBackColor = true;
            // 
            // pages_rbtn
            // 
            this.pages_rbtn.AutoSize = true;
            this.pages_rbtn.Location = new System.Drawing.Point(158, 75);
            this.pages_rbtn.Name = "pages_rbtn";
            this.pages_rbtn.Size = new System.Drawing.Size(147, 21);
            this.pages_rbtn.TabIndex = 15;
            this.pages_rbtn.Text = "Кількість сторінок";
            this.pages_rbtn.UseVisualStyleBackColor = true;
            // 
            // pub_rbtn
            // 
            this.pub_rbtn.AutoSize = true;
            this.pub_rbtn.Location = new System.Drawing.Point(158, 21);
            this.pub_rbtn.Name = "pub_rbtn";
            this.pub_rbtn.Size = new System.Drawing.Size(115, 21);
            this.pub_rbtn.TabIndex = 13;
            this.pub_rbtn.Text = "Видавництво";
            this.pub_rbtn.UseVisualStyleBackColor = true;
            // 
            // year_rbtn
            // 
            this.year_rbtn.AutoSize = true;
            this.year_rbtn.Location = new System.Drawing.Point(158, 48);
            this.year_rbtn.Name = "year_rbtn";
            this.year_rbtn.Size = new System.Drawing.Size(107, 21);
            this.year_rbtn.TabIndex = 14;
            this.year_rbtn.Text = "Рік видання";
            this.year_rbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(448, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Виберіть критерій \r\nдля пошуку:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchbox.ForeColor = System.Drawing.Color.Black;
            this.searchbox.Location = new System.Drawing.Point(150, 27);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(281, 44);
            this.searchbox.TabIndex = 8;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пошук:";
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(94)))));
            this.BottomPanel.Controls.Add(this.edit_btn);
            this.BottomPanel.Controls.Add(this.delete_btn);
            this.BottomPanel.Controls.Add(this.add_btn);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 443);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1338, 100);
            this.BottomPanel.TabIndex = 8;
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.edit_btn.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.edit_btn.IconColor = System.Drawing.Color.PaleGreen;
            this.edit_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.edit_btn.IconSize = 56;
            this.edit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_btn.Location = new System.Drawing.Point(869, 17);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(356, 71);
            this.edit_btn.TabIndex = 7;
            this.edit_btn.Text = "Редагувати запис";
            this.edit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.delete_btn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.delete_btn.IconColor = System.Drawing.Color.Red;
            this.delete_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delete_btn.IconSize = 50;
            this.delete_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_btn.Location = new System.Drawing.Point(473, 17);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(322, 71);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "Видалити запис";
            this.delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.add_btn.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.add_btn.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.add_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add_btn.IconSize = 56;
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.Location = new System.Drawing.Point(106, 17);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(285, 71);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Додати запис";
            this.add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView);
            this.panel3.Controls.Add(this.BottomPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1338, 543);
            this.panel3.TabIndex = 9;
            // 
            // BooksForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1338, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TopPanel);
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книги";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private FontAwesome.Sharp.IconButton refresh_btn;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton add_btn;
        private FontAwesome.Sharp.IconButton delete_btn;
        private FontAwesome.Sharp.IconButton edit_btn;
        private System.Windows.Forms.RadioButton lang_rbtn;
        private System.Windows.Forms.RadioButton genre_rbtn;
        private System.Windows.Forms.RadioButton litDir_rbtn;
        private System.Windows.Forms.RadioButton pages_rbtn;
        private System.Windows.Forms.RadioButton year_rbtn;
        private System.Windows.Forms.RadioButton pub_rbtn;
        private System.Windows.Forms.RadioButton author_rbtn;
        private System.Windows.Forms.RadioButton title_rbtn;
        private System.Windows.Forms.RadioButton all_rbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

