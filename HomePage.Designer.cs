namespace Movie_Theater_Management
{
    partial class HomePage
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
            components = new System.ComponentModel.Container();
            home_panel = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            theater_btn = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            movie_btn = new ToolStripMenuItem();
            genre_btn = new ToolStripMenuItem();
            scheduleToolStripMenuItem = new ToolStripMenuItem();
            paymentMethodToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            home_panel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // home_panel
            // 
            home_panel.AutoSize = true;
            home_panel.BackColor = Color.FromArgb(40, 42, 54);
            home_panel.ColumnCount = 1;
            home_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.5640078F));
            home_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.43599F));
            home_panel.Controls.Add(menuStrip1, 0, 0);
            home_panel.Dock = DockStyle.Fill;
            home_panel.Location = new Point(0, 0);
            home_panel.Name = "home_panel";
            home_panel.RowCount = 2;
            home_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.53564167F));
            home_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 92.4643555F));
            home_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            home_panel.Size = new Size(1078, 491);
            home_panel.TabIndex = 4;
            home_panel.AutoSizeChanged += home_panel_AutoSizeChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(68, 71, 90);
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { theater_btn, movie_btn, genre_btn, scheduleToolStripMenuItem, paymentMethodToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 2, 0, 2);
            menuStrip1.Size = new Size(1078, 37);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // theater_btn
            // 
            theater_btn.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            theater_btn.ForeColor = SystemColors.Control;
            theater_btn.Name = "theater_btn";
            theater_btn.Size = new Size(73, 24);
            theater_btn.Text = "Theater";
            theater_btn.Click += theater_btn_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = Color.Black;
            toolStripMenuItem2.BackgroundImageLayout = ImageLayout.None;
            toolStripMenuItem2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuItem2.ForeColor = SystemColors.Control;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(136, 26);
            toolStripMenuItem2.Text = "Search";
            // 
            // movie_btn
            // 
            movie_btn.ForeColor = SystemColors.Control;
            movie_btn.Name = "movie_btn";
            movie_btn.Size = new Size(64, 24);
            movie_btn.Text = "Movie";
            movie_btn.Click += movie_btn_Click;
            // 
            // genre_btn
            // 
            genre_btn.ForeColor = SystemColors.Control;
            genre_btn.Name = "genre_btn";
            genre_btn.Size = new Size(62, 24);
            genre_btn.Text = "Genre";
            genre_btn.Click += genre_btn_Click;
            // 
            // scheduleToolStripMenuItem
            // 
            scheduleToolStripMenuItem.ForeColor = SystemColors.Control;
            scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            scheduleToolStripMenuItem.Size = new Size(83, 24);
            scheduleToolStripMenuItem.Text = "Schedule";
            scheduleToolStripMenuItem.Click += scheduleToolStripMenuItem_Click;
            // 
            // paymentMethodToolStripMenuItem
            // 
            paymentMethodToolStripMenuItem.ForeColor = SystemColors.Control;
            paymentMethodToolStripMenuItem.Name = "paymentMethodToolStripMenuItem";
            paymentMethodToolStripMenuItem.Size = new Size(135, 24);
            paymentMethodToolStripMenuItem.Text = "Payment Method";
            paymentMethodToolStripMenuItem.Click += paymentMethodToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1078, 491);
            Controls.Add(home_panel);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "HomePage";
            Text = "Theater Management";
            home_panel.ResumeLayout(false);
            home_panel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel home_panel;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem theater_btn;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem movie_btn;
        private ToolStripMenuItem genre_btn;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private ToolStripMenuItem paymentMethodToolStripMenuItem;
    }
}