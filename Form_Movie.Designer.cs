namespace Movie_Theater_Management
{
    partial class Form_Movie
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
            getBtn = new Button();
            addBtn = new Button();
            updateBtn = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            dateTimePicker = new CustomeDateTimePicker();
            label9 = new Label();
            textBox_overview = new TextBox();
            label5 = new Label();
            textBox_poster = new TextBox();
            label6 = new Label();
            textBox_streaming = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox_rate = new TextBox();
            textBox_language = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox_runtime = new TextBox();
            deleteBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox_Title = new TextBox();
            textBox_ID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // getBtn
            // 
            getBtn.Location = new Point(227, 294);
            getBtn.Name = "getBtn";
            getBtn.Size = new Size(94, 29);
            getBtn.TabIndex = 0;
            getBtn.Text = "Get ";
            getBtn.UseVisualStyleBackColor = true;
            getBtn.Click += getBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(424, 294);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(602, 294);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 329);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(984, 213);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox_overview);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox_poster);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox_streaming);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox_rate);
            groupBox1.Controls.Add(textBox_language);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox_runtime);
            groupBox1.Controls.Add(deleteBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_Title);
            groupBox1.Controls.Add(textBox_ID);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(updateBtn);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(getBtn);
            groupBox1.Location = new Point(58, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1083, 548);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Movie";
            // 
            // dateTimePicker
            // 
            dateTimePicker.BorderColor = Color.PaleVioletRed;
            dateTimePicker.BorderSize = 0;
            dateTimePicker.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker.Location = new Point(802, 26);
            dateTimePicker.MinimumSize = new Size(0, 35);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(231, 35);
            dateTimePicker.SkinColor = Color.FromArgb(68, 71, 90);
            dateTimePicker.TabIndex = 23;
            dateTimePicker.TextColor = Color.FromArgb(189, 147, 249);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 187);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 22;
            label9.Text = "Overview";
            // 
            // textBox_overview
            // 
            textBox_overview.Location = new Point(115, 184);
            textBox_overview.Multiline = true;
            textBox_overview.Name = "textBox_overview";
            textBox_overview.Size = new Size(918, 104);
            textBox_overview.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 143);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 20;
            label5.Text = "Poster";
            // 
            // textBox_poster
            // 
            textBox_poster.Location = new Point(115, 136);
            textBox_poster.Name = "textBox_poster";
            textBox_poster.Size = new Size(918, 27);
            textBox_poster.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(519, 91);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 18;
            label6.Text = "Streaming";
            // 
            // textBox_streaming
            // 
            textBox_streaming.Location = new Point(602, 84);
            textBox_streaming.Name = "textBox_streaming";
            textBox_streaming.Size = new Size(125, 27);
            textBox_streaming.TabIndex = 17;
            textBox_streaming.TextChanged += textBox_streaming_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(277, 91);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 16;
            label7.Text = "Rate";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 91);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 15;
            label8.Text = "Language";
            // 
            // textBox_rate
            // 
            textBox_rate.Location = new Point(329, 84);
            textBox_rate.Name = "textBox_rate";
            textBox_rate.Size = new Size(125, 27);
            textBox_rate.TabIndex = 14;
            textBox_rate.KeyPress += textBox_rate_KeyPress;
            // 
            // textBox_language
            // 
            textBox_language.Location = new Point(115, 84);
            textBox_language.Name = "textBox_language";
            textBox_language.Size = new Size(125, 27);
            textBox_language.TabIndex = 13;
            textBox_language.TextChanged += textBox_language_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(722, 33);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 12;
            label4.Text = "Release";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(802, 91);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 10;
            label3.Text = "Runtime";
            label3.Click += label3_Click;
            // 
            // textBox_runtime
            // 
            textBox_runtime.Location = new Point(872, 84);
            textBox_runtime.Name = "textBox_runtime";
            textBox_runtime.Size = new Size(161, 27);
            textBox_runtime.TabIndex = 9;
            textBox_runtime.KeyPress += textBox_runtime_KeyPress;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(779, 294);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 8;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 33);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 7;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 33);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 6;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // textBox_Title
            // 
            textBox_Title.Location = new Point(330, 26);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(366, 27);
            textBox_Title.TabIndex = 5;
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(115, 26);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(125, 27);
            textBox_ID.TabIndex = 4;
            // 
            // Form_Movie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 617);
            Controls.Add(groupBox1);
            Name = "Form_Movie";
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
        private TextBox textBox_Title;
        private TextBox textBox_ID;
        private Button deleteBtn;
        private Label label3;
        private TextBox textBox_runtime;
        private Label label4;
        private Label label5;
        private TextBox textBox_poster;
        private Label label6;
        private TextBox textBox_streaming;
        private Label label7;
        private Label label8;
        private TextBox textBox_rate;
        private TextBox textBox_language;
        private Label label9;
        private TextBox textBox_overview;
        private CustomeDateTimePicker dateTimePicker;
    }
}