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
            movie_btn = new ToolStripMenuItem();
            genre_btn = new ToolStripMenuItem();
            scheduleToolStripMenuItem = new ToolStripMenuItem();
            paymentMethodToolStripMenuItem = new ToolStripMenuItem();
            roomToolStripMenuItem = new ToolStripMenuItem();
            roomMapToolStripMenuItem = new ToolStripMenuItem();
            ticketPricceToolStripMenuItem = new ToolStripMenuItem();
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
            home_panel.Margin = new Padding(3, 2, 3, 2);
            home_panel.Name = "home_panel";
            home_panel.RowCount = 2;
            home_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.53564167F));
            home_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 92.4643555F));
            home_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            home_panel.Size = new Size(943, 368);
            home_panel.TabIndex = 4;
            home_panel.AutoSizeChanged += home_panel_AutoSizeChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(68, 71, 90);
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { theater_btn, movie_btn, genre_btn, scheduleToolStripMenuItem, paymentMethodToolStripMenuItem, roomToolStripMenuItem, roomMapToolStripMenuItem, ticketPricceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 2, 0, 2);
            menuStrip1.Size = new Size(943, 27);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // theater_btn
            // 
            theater_btn.ForeColor = SystemColors.Control;
            theater_btn.Name = "theater_btn";
            theater_btn.Size = new Size(58, 23);
            theater_btn.Text = "Theater";
            theater_btn.Click += theater_btn_Click;
            // 
            // movie_btn
            // 
            movie_btn.ForeColor = SystemColors.Control;
            movie_btn.Name = "movie_btn";
            movie_btn.Size = new Size(52, 23);
            movie_btn.Text = "Movie";
            movie_btn.Click += movie_btn_Click;
            // 
            // genre_btn
            // 
            genre_btn.ForeColor = SystemColors.Control;
            genre_btn.Name = "genre_btn";
            genre_btn.Size = new Size(50, 23);
            genre_btn.Text = "Genre";
            genre_btn.Click += genre_btn_Click;
            // 
            // scheduleToolStripMenuItem
            // 
            scheduleToolStripMenuItem.ForeColor = SystemColors.Control;
            scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            scheduleToolStripMenuItem.Size = new Size(67, 23);
            scheduleToolStripMenuItem.Text = "Schedule";
            scheduleToolStripMenuItem.Click += scheduleToolStripMenuItem_Click;
            // 
            // paymentMethodToolStripMenuItem
            // 
            paymentMethodToolStripMenuItem.ForeColor = SystemColors.Control;
            paymentMethodToolStripMenuItem.Name = "paymentMethodToolStripMenuItem";
            paymentMethodToolStripMenuItem.Size = new Size(111, 23);
            paymentMethodToolStripMenuItem.Text = "Payment Method";
            paymentMethodToolStripMenuItem.Click += paymentMethodToolStripMenuItem_Click;
            // 
            // roomToolStripMenuItem
            // 
            roomToolStripMenuItem.ForeColor = SystemColors.Control;
            roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            roomToolStripMenuItem.Size = new Size(51, 23);
            roomToolStripMenuItem.Text = "Room";
            roomToolStripMenuItem.Click += roomToolStripMenuItem_Click;
            // 
            // roomMapToolStripMenuItem
            // 
            roomMapToolStripMenuItem.Name = "roomMapToolStripMenuItem";
            roomMapToolStripMenuItem.Size = new Size(78, 23);
            roomMapToolStripMenuItem.Text = "Room map";
            roomMapToolStripMenuItem.Click += roomMapToolStripMenuItem_Click;
            // 
            // ticketPricceToolStripMenuItem
            // 
            ticketPricceToolStripMenuItem.Name = "ticketPricceToolStripMenuItem";
            ticketPricceToolStripMenuItem.Size = new Size(79, 23);
            ticketPricceToolStripMenuItem.Text = "Ticket Price";
            ticketPricceToolStripMenuItem.Click += ticketPricceToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(943, 368);
            Controls.Add(home_panel);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
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
        private ToolStripMenuItem movie_btn;
        private ToolStripMenuItem genre_btn;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private ToolStripMenuItem paymentMethodToolStripMenuItem;
        private ToolStripMenuItem roomToolStripMenuItem;
        private ToolStripMenuItem roomMapToolStripMenuItem;
        private ToolStripMenuItem ticketPricceToolStripMenuItem;
    }
}