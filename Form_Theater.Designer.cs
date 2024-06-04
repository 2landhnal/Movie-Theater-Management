namespace Movie_Theater_Management
{
    partial class Form_Theater
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            getBtn = new Button();
            addBtn = new Button();
            updateBtn = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label5 = new Label();
            textBox_loc = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox_lon = new TextBox();
            textBox_lat = new TextBox();
            deleteBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox_name = new TextBox();
            textBox_id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // getBtn
            // 
            getBtn.BackColor = Color.FromArgb(52, 55, 70);
            getBtn.ForeColor = SystemColors.Control;
            getBtn.Location = new Point(100, 179);
            getBtn.Name = "getBtn";
            getBtn.Size = new Size(94, 29);
            getBtn.TabIndex = 0;
            getBtn.Text = "Get ";
            getBtn.UseVisualStyleBackColor = false;
            getBtn.Click += getBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(52, 55, 70);
            addBtn.ForeColor = SystemColors.Control;
            addBtn.Location = new Point(297, 179);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(52, 55, 70);
            updateBtn.ForeColor = SystemColors.Control;
            updateBtn.Location = new Point(475, 179);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(68, 71, 90);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(68, 71, 90);
            dataGridView1.Location = new Point(49, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(68, 71, 90);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(68, 71, 90);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(68, 71, 90);
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(733, 213);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(40, 42, 54);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox_loc);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox_lon);
            groupBox1.Controls.Add(textBox_lat);
            groupBox1.Controls.Add(deleteBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_name);
            groupBox1.Controls.Add(textBox_id);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(updateBtn);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(getBtn);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(58, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(832, 461);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Theater";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(49, 143);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 20;
            label5.Text = "Location";
            // 
            // textBox_loc
            // 
            textBox_loc.BackColor = Color.FromArgb(52, 55, 70);
            textBox_loc.BorderStyle = BorderStyle.FixedSingle;
            textBox_loc.ForeColor = SystemColors.Control;
            textBox_loc.Location = new Point(115, 136);
            textBox_loc.Name = "textBox_loc";
            textBox_loc.Size = new Size(667, 27);
            textBox_loc.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(454, 89);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 16;
            label7.Text = "Longtitude";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(179, 89);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 15;
            label8.Text = "Latitude";
            // 
            // textBox_lon
            // 
            textBox_lon.BackColor = Color.FromArgb(52, 55, 70);
            textBox_lon.BorderStyle = BorderStyle.FixedSingle;
            textBox_lon.ForeColor = SystemColors.Control;
            textBox_lon.Location = new Point(541, 82);
            textBox_lon.Name = "textBox_lon";
            textBox_lon.Size = new Size(125, 27);
            textBox_lon.TabIndex = 14;
            textBox_lon.KeyPress += textBox_rate_KeyPress;
            // 
            // textBox_lat
            // 
            textBox_lat.BackColor = Color.FromArgb(52, 55, 70);
            textBox_lat.BorderStyle = BorderStyle.FixedSingle;
            textBox_lat.ForeColor = SystemColors.Control;
            textBox_lat.Location = new Point(248, 82);
            textBox_lat.Name = "textBox_lat";
            textBox_lat.Size = new Size(125, 27);
            textBox_lat.TabIndex = 13;
            textBox_lat.KeyPress += textBox_lat_KeyPress;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(52, 55, 70);
            deleteBtn.ForeColor = SystemColors.Control;
            deleteBtn.Location = new Point(652, 179);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 8;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(278, 33);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(64, 33);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 6;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // textBox_name
            // 
            textBox_name.BackColor = Color.FromArgb(52, 55, 70);
            textBox_name.BorderStyle = BorderStyle.FixedSingle;
            textBox_name.ForeColor = SystemColors.Control;
            textBox_name.Location = new Point(333, 26);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(449, 27);
            textBox_name.TabIndex = 5;
            // 
            // textBox_id
            // 
            textBox_id.BackColor = Color.FromArgb(52, 55, 70);
            textBox_id.BorderStyle = BorderStyle.FixedSingle;
            textBox_id.ForeColor = SystemColors.Control;
            textBox_id.Location = new Point(115, 26);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(125, 27);
            textBox_id.TabIndex = 4;
            // 
            // Form_Theater
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 42, 54);
            ClientSize = new Size(956, 525);
            Controls.Add(groupBox1);
            Name = "Form_Theater";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button getBtn;
        private Button addBtn;
        private Button updateBtn;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox_name;
        private TextBox textBox_id;
        private Button deleteBtn;
        private Label label5;
        private TextBox textBox_loc;
        private Label label7;
        private Label label8;
        private TextBox textBox_lon;
        private TextBox textBox_lat;
    }
}