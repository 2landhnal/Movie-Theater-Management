namespace Movie_Theater_Management
{
    public partial class HomePage : Form
    {
        Form currentChildForm = null;
        public HomePage()
        {
            InitializeComponent();

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            Form_Movie movieForm = new Form_Movie();
            //Cursor.Position = this.PointToScreen(new Point(0, 0));
            OpenChildForm(movieForm);
            var coms = Helper.GetAllToolStripMenuItems(this).ToList();
            foreach (var v in coms)
            {
                v.DisplayStyle = ToolStripItemDisplayStyle.Text;
                v.BackColor = Helper.backColor2;
            }
            //this.menuStrip1.Renderer = new RendererEx();
            this.menuStrip1.BackColor = Helper.backColor2;
            this.menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            this.menuStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
            //menuStrip1.
        }

        void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            home_panel.Controls.Add(childForm, 1, 1);
            childForm.BringToFront();
            childForm.Show();
            Helper.setStyle(childForm);
        }

        /* private void timer1_Tick(object sender, EventArgs e)
         {
             expander.Height += 30 * (expand ? 1 : -1);
             if (expander.Height >= expander.MaximumSize.Height)
             {
                 expander.Height = expander.MaximumSize.Height;
                 timer1.Stop();
             }
             if (expander.Height <= expander.MinimumSize.Height)
             {
                 expander.Height = expander.MinimumSize.Height;
                 timer1.Stop();
             }
         }

         private void expander_Click(object sender, EventArgs e)
         {
             expand = !expand;
             timer1.Start();
         }*/

        private void home_panel_AutoSizeChanged(object sender, EventArgs e)
        {
            //this.AutoSize = true;
        }


        private void theater_btn_Click(object sender, EventArgs e)
        {
            Form_Theater newForm = new Form_Theater();
            //Cursor.Position = this.PointToScreen(new Point(0, 0));
            OpenChildForm(newForm);

        }

        private void movie_btn_Click(object sender, EventArgs e)
        {
            Form_Movie newForm = new Form_Movie();
            //Cursor.Position = this.PointToScreen(new Point(0, 0));
            OpenChildForm(newForm);

        }

        private void genre_btn_Click(object sender, EventArgs e)
        {
            Form_Genre newForm = new Form_Genre();
            //Cursor.Position = this.PointToScreen(new Point(0, 0));
            OpenChildForm(newForm);

        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Schedule newForm = new Form_Schedule();
            //Cursor.Position = this.PointToScreen(new Point(0, 0));
            OpenChildForm(newForm);

        }

        private void paymentMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Payment newForm = new Form_Payment();
            //Cursor.Position = this.PointToScreen(new Point(0, 0));
            OpenChildForm(newForm);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
