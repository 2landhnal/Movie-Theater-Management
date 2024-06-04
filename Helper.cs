using Firebase.Database;
using System.Globalization;

namespace Movie_Theater_Management
{
    internal class Helper
    {

        public static string globalTimeFormat = "yyyy-MM-dd";
        public static Color viotlet = Color.FromArgb(189, 147, 249);
        public static Color fadeColor = Color.FromArgb(68, 71, 90);
        public static Color backColor2 = Color.FromArgb(33, 34, 44);
        public static Color backColor = Color.FromArgb(40, 42, 54);

        public static IEnumerable<Control> GetAllControls(Control root)
        {
            var stack = new Stack<Control>();
            stack.Push(root);

            while (stack.Any())
            {
                var next = stack.Pop();
                foreach (Control child in next.Controls)
                    stack.Push(child);

                yield return next;
            }
        }
        public static IEnumerable<ToolStripMenuItem> GetAllToolStripMenuItems(Form form)
        {
            var menuItems = new List<ToolStripMenuItem>();

            // Get all controls in the form
            var controls = GetAllControls(form);

            // Iterate over all controls to find MenuStrip and ContextMenuStrip
            foreach (var control in controls)
            {
                if (control is MenuStrip menuStrip)
                {
                    menuItems.AddRange(GetMenuItems(menuStrip.Items));
                }
                else if (control is ContextMenuStrip contextMenuStrip)
                {
                    menuItems.AddRange(GetMenuItems(contextMenuStrip.Items));
                }
            }

            return menuItems;
        }

        private static IEnumerable<ToolStripMenuItem> GetMenuItems(ToolStripItemCollection items)
        {
            foreach (var item in items)
            {
                if (item is ToolStripMenuItem menuItem)
                {
                    yield return menuItem;

                    // Recursively get sub-items
                    foreach (var subItem in GetMenuItems(menuItem.DropDownItems))
                    {
                        yield return subItem;
                    }
                }
            }
        }

        public static void setStyle(Control root)
        {
            var dtgs = GetAllControls(root).Where(x => x is DataGridView).ToList();
            foreach (var v in dtgs)
            {
                ((DataGridView)v).EnableHeadersVisualStyles = false;
                ((DataGridView)v).ColumnHeadersDefaultCellStyle.BackColor = fadeColor;
                ((DataGridView)v).ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                ((DataGridView)v).ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                ((DataGridView)v).BackgroundColor = fadeColor;
                ((DataGridView)v).RowHeadersVisible = false;
                ((DataGridView)v).GridColor = viotlet;
                ((DataGridView)v).DefaultCellStyle.BackColor = fadeColor;
                ((DataGridView)v).DefaultCellStyle.ForeColor = Color.White;
            }


            var labels = GetAllControls(root).Where(x => x is Label).ToList();
            foreach (var v in labels)
            {
                v.ForeColor = Color.White;
            }

            var txtBoxs = GetAllControls(root).Where(x => x is TextBox).ToList();
            foreach (var v in txtBoxs)
            {
                //v.MinimumSize = new Size(35, 35);
                //((TextBox)v).TextAlign = HorizontalAlignment.Center;
                //((TextBox)v).AutoSize = false;
                //v.Height = (int)(MathF.Max(v.Height, 35));
                v.ForeColor = Color.White;
                v.BackColor = fadeColor;
                ((TextBox)v).BorderStyle = BorderStyle.FixedSingle;
            }

            var btns = GetAllControls(root).Where(x => x is Button).ToList();
            foreach (var v in btns)
            {
                ((Button)v).FlatStyle = FlatStyle.Flat;
                ((Button)v).FlatAppearance.BorderSize = 0;
                v.ForeColor = Color.White;
                v.BackColor = fadeColor;
            }

            var dtps = GetAllControls(root).Where(x => x is DateTimePicker).ToList();
            foreach (var v in btns)
            {
                v.ForeColor = Color.White;
                v.BackColor = fadeColor;
            }

            var grbs = GetAllControls(root).Where(x => x is GroupBox).ToList();
            foreach (var v in grbs)
            {
                v.Paint += drawGroupBoxEvent;
            }

            var cbbs = GetAllControls(root).Where(x => x is FlatComboBox).ToList();
            foreach (var v in cbbs)
            {
                v.ForeColor = Color.White;
                v.BackColor = fadeColor;
                //((FlatComboBox)v).BorderColor = Color.Transparent;
                ((FlatComboBox)v).ButtonColor = Helper.fadeColor;
                v.Height = (int)(MathF.Max(v.Height, 35));
            }

            root.BackColor = backColor;
        }

        public static List<T> getAllElementOfType<T>(Control root)
        {
            return root.Controls.OfType<T>().Where(x => x is T).ToList();
        }

        static public void drawGroupBoxEvent(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.White, viotlet);
        }
        static public string ToTitleCase(string str)
        {
            var firstword = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.Split(' ')[0].ToLower());
            str = str.Replace(str.Split(' ')[0], firstword);
            return str;
        }
        static public int FromTimeToMinutes(DateTime dt)
        {
            int res = 0;
            res += dt.Minute;
            res += dt.Hour * 60;
            return res;
        }

        static public int RoundDown(int val, int deletmeter)
        {
            val -= (val % deletmeter);
            return val;
        }
        static public int RoundUp(int val, int deletmeter)
        {
            val += (deletmeter - val % deletmeter);
            return val;
        }
        static public async Task<IReadOnlyCollection<FirebaseObject<T>>?> GetDataTable<T>(string tableName)
        {
            try
            {
                var _client = Firebase_Connect.client;
                if (_client == null) return null;
                var result = await _client
                  .Child(tableName)
                  .OnceAsync<T>();
                //MessageBox.Show("2");
                return result;
            }
            catch (Exception ex)
            {
                var _client = Firebase_Connect.client;
                if (_client == null) return null;
                var result = await _client
                  .Child(tableName)
                  .OnceAsListAsync<T>();
                List<FirebaseObject<T>> res = new List<FirebaseObject<T>>();
                foreach (var item in result)
                {
                    if (item == null || item.Object == null) continue;
                    res.Add(item);
                }
                //MessageBox.Show("1");
                return res;
            }
        }

        static public DateTime getDate(string releaseDate)
        {
            return DateTime.ParseExact(releaseDate, globalTimeFormat,
                System.Globalization.CultureInfo.InvariantCulture);
        }
        static public String getDateGlobalFormat(DateTime dt)
        {
            return dt.ToString(globalTimeFormat, CultureInfo.InvariantCulture);
        }

        static public void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(box.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }
    }
}
