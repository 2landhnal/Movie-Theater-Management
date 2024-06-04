namespace Movie_Theater_Management
{
    public class CustomColorTable : ProfessionalColorTable
    {
        //a bunch of other overrides...

        public override Color MenuItemSelected
        {
            get { return Helper.fadeColor; }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Helper.fadeColor; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Helper.fadeColor; }
        }

        public override Color MenuItemBorder
        {
            get { return Color.Transparent; }
        }

        public override Color ToolStripDropDownBackground
        {
            get { return Helper.backColor2; }
        }
        public override Color ToolStripBorder => Color.Transparent;
        /// <summary>
        /// Gets the starting color of the gradient used when 
        /// a top-level System.Windows.Forms.ToolStripMenuItem is pressed.
        /// </summary>
        public override Color MenuItemPressedGradientBegin => Helper.backColor2;

        /// <summary>
        /// Gets the end color of the gradient used when a top-level 
        /// System.Windows.Forms.ToolStripMenuItem is pressed.
        /// </summary>
        public override Color MenuItemPressedGradientEnd => Helper.backColor2;

        /// <summary>
        /// Gets the border color to use with a 
        /// System.Windows.Forms.ToolStripMenuItem.
        /// </summary>

        /// <summary>
        /// Gets the starting color of the gradient used in the image 
        /// margin of a System.Windows.Forms.ToolStripDropDownMenu.
        /// </summary>
        public override Color ImageMarginGradientBegin => Color.DimGray;

        /// <summary>
        /// Gets the middle color of the gradient used in the image 
        /// margin of a System.Windows.Forms.ToolStripDropDownMenu.
        /// </summary>
        public override Color ImageMarginGradientMiddle => Color.DimGray;

        /// <summary>
        /// Gets the end color of the gradient used in the image 
        /// margin of a System.Windows.Forms.ToolStripDropDownMenu.
        /// </summary>
        public override Color ImageMarginGradientEnd => Color.DimGray;

        /// <summary>
        /// Gets the color to use to for shadow effects on 
        /// the System.Windows.Forms.ToolStripSeparator.
        /// </summary>
        public override Color SeparatorDark => Color.Black;

        /// <summary>
        /// Gets the color that is the border color to use 
        /// on a System.Windows.Forms.MenuStrip.
        /// </summary>
        public override Color MenuBorder => Color.White;

        /*public override Color ToolStripContentPanelGradientBegin
        {
            get { return Color.Red; }
        }

        public override Color ToolStripContentPanelGradientEnd
        {
            get { return Color.Red; }
        }

        public override Color ToolStripPanelGradientBegin
        {
            get { return Color.Green; }
        }
        public override Color ToolStripPanelGradientEnd
        {
            get { return Color.Yellow; }
        }

        public override Color ToolStripGradientBegin
        {
            get { return Color.Aqua; }
        }
        public override Color ToolStripGradientMiddle
        {
            get { return Color.Aqua; }
        }
        public override Color ToolStripGradientEnd
        {
            get { return Color.Aqua; }
        }
        public override Color MenuStripGradientBegin
        {
            get { return Color.Aquamarine; }
        }
        public override Color MenuStripGradientEnd
        {
            get { return Color.Aquamarine; }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.AliceBlue; }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.AliceBlue; }
        }
        public override Color StatusStripGradientBegin
        {
            get { return Color.Orange; }
        }
        public override Color StatusStripGradientEnd
        {
            get { return Color.Orange; }
        }
        public override Color ButtonSelectedGradientBegin
        {
            get { return Color.Blue; }
        }
        public override Color ButtonSelectedGradientEnd
        {
            get { return Color.Blue; }
        }
        public override Color ButtonSelectedHighlight
        {
            get { return Color.OliveDrab; }
        }

        public override Color StatusStripBorder => Color.RebeccaPurple;*/
    }
    public class RendererEx : ToolStripProfessionalRenderer
    {

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            //base.OnRenderMenuItemBackground(e);
            e.Item.BackColor = Color.Black;
        }
    }
}
