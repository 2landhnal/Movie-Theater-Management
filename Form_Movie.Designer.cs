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
            comboBox_option = new FlatComboBox();
            btn_search = new Button();
            label10 = new Label();
            textBox_search = new TextBox();
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
            getBtn.Location = new Point(199, 466);
            getBtn.Margin = new Padding(3, 2, 3, 2);
            getBtn.Name = "getBtn";
            getBtn.Size = new Size(82, 22);
            getBtn.TabIndex = 0;
            getBtn.Text = "Get ";
            getBtn.UseVisualStyleBackColor = true;
            getBtn.Click += getBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(371, 466);
            addBtn.Margin = new Padding(3, 2, 3, 2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(82, 22);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(527, 466);
            updateBtn.Margin = new Padding(3, 2, 3, 2);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(82, 22);
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
            dataGridView1.Location = new Point(44, 80);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(861, 160);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox_option);
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox_search);
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
            groupBox1.Location = new Point(51, 21);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(948, 503);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Movie";
            // 
            // comboBox_option
            // 
            comboBox_option.FormattingEnabled = true;
            comboBox_option.Location = new Point(502, 34);
            comboBox_option.Margin = new Padding(3, 2, 3, 2);
            comboBox_option.Name = "comboBox_option";
            comboBox_option.Size = new Size(148, 23);
            comboBox_option.TabIndex = 29;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(682, 35);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(82, 22);
            btn_search.TabIndex = 26;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(56, 40);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 25;
            label10.Text = "Search";
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(133, 35);
            textBox_search.Margin = new Padding(3, 2, 3, 2);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(340, 23);
            textBox_search.TabIndex = 24;
            // 
            // dateTimePicker
            // 
            dateTimePicker.BorderColor = Color.PaleVioletRed;
            dateTimePicker.BorderSize = 0;
            dateTimePicker.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker.Location = new Point(702, 257);
            dateTimePicker.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker.MinimumSize = new Size(4, 35);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(203, 35);
            dateTimePicker.SkinColor = Color.FromArgb(68, 71, 90);
            dateTimePicker.TabIndex = 23;
            dateTimePicker.TextColor = Color.FromArgb(189, 147, 249);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 378);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 22;
            label9.Text = "Overview";
            // 
            // textBox_overview
            // 
            textBox_overview.Location = new Point(101, 376);
            textBox_overview.Margin = new Padding(3, 2, 3, 2);
            textBox_overview.Multiline = true;
            textBox_overview.Name = "textBox_overview";
            textBox_overview.Size = new Size(804, 79);
            textBox_overview.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 345);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 20;
            label5.Text = "Poster";
            // 
            // textBox_poster
            // 
            textBox_poster.Location = new Point(101, 340);
            textBox_poster.Margin = new Padding(3, 2, 3, 2);
            textBox_poster.Name = "textBox_poster";
            textBox_poster.Size = new Size(804, 23);
            textBox_poster.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 306);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 18;
            label6.Text = "Streaming";
            // 
            // textBox_streaming
            // 
            textBox_streaming.Location = new Point(527, 301);
            textBox_streaming.Margin = new Padding(3, 2, 3, 2);
            textBox_streaming.Name = "textBox_streaming";
            textBox_streaming.Size = new Size(110, 23);
            textBox_streaming.TabIndex = 17;
            textBox_streaming.TextChanged += textBox_streaming_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(242, 306);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 16;
            label7.Text = "Rate";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 306);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 15;
            label8.Text = "Language";
            // 
            // textBox_rate
            // 
            textBox_rate.Location = new Point(288, 301);
            textBox_rate.Margin = new Padding(3, 2, 3, 2);
            textBox_rate.Name = "textBox_rate";
            textBox_rate.Size = new Size(110, 23);
            textBox_rate.TabIndex = 14;
            textBox_rate.KeyPress += textBox_rate_KeyPress;
            // 
            // textBox_language
            // 
            textBox_language.Location = new Point(101, 301);
            textBox_language.Margin = new Padding(3, 2, 3, 2);
            textBox_language.Name = "textBox_language";
            textBox_language.Size = new Size(110, 23);
            textBox_language.TabIndex = 13;
            textBox_language.TextChanged += textBox_language_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(632, 263);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 12;
            label4.Text = "Release";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(702, 306);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 10;
            label3.Text = "Runtime";
            label3.Click += label3_Click;
            // 
            // textBox_runtime
            // 
            textBox_runtime.Location = new Point(763, 301);
            textBox_runtime.Margin = new Padding(3, 2, 3, 2);
            textBox_runtime.Name = "textBox_runtime";
            textBox_runtime.Size = new Size(141, 23);
            textBox_runtime.TabIndex = 9;
            textBox_runtime.KeyPress += textBox_runtime_KeyPress;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(682, 466);
            deleteBtn.Margin = new Padding(3, 2, 3, 2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(82, 22);
            deleteBtn.TabIndex = 8;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 263);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 7;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 263);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 6;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // textBox_Title
            // 
            textBox_Title.Location = new Point(289, 257);
            textBox_Title.Margin = new Padding(3, 2, 3, 2);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(321, 23);
            textBox_Title.TabIndex = 5;
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(101, 257);
            textBox_ID.Margin = new Padding(3, 2, 3, 2);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(110, 23);
            textBox_ID.TabIndex = 4;
            // 
            // Form_Movie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 553);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Movie";
            Text = "MainForm";
            Load += Form_Movie_Load;
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
        private Button btn_search;
        private Label label10;
        private TextBox textBox_search;
        private FlatComboBox comboBox_option;
    }
}