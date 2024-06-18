namespace Movie_Theater_Management
{
    partial class Form_Room
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
            comboBox_theaterId = new FlatComboBox();
            label7 = new Label();
            label8 = new Label();
            textBox_name = new TextBox();
            textBox_type = new TextBox();
            deleteBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox_index = new TextBox();
            btn_search = new Button();
            comboBox_option = new FlatComboBox();
            label10 = new Label();
            textBox_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // getBtn
            // 
            getBtn.Location = new Point(47, 343);
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
            addBtn.Location = new Point(161, 343);
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
            updateBtn.Location = new Point(280, 343);
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
            dataGridView1.Location = new Point(14, 75);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(494, 160);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(comboBox_theaterId);
            groupBox1.Controls.Add(comboBox_option);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox_search);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox_name);
            groupBox1.Controls.Add(textBox_type);
            groupBox1.Controls.Add(deleteBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_index);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(updateBtn);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(getBtn);
            groupBox1.Location = new Point(51, 19);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(526, 383);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Room";
            // 
            // comboBox_theaterId
            // 
            comboBox_theaterId.FormattingEnabled = true;
            comboBox_theaterId.Location = new Point(321, 244);
            comboBox_theaterId.Margin = new Padding(3, 2, 3, 2);
            comboBox_theaterId.Name = "comboBox_theaterId";
            comboBox_theaterId.Size = new Size(166, 23);
            comboBox_theaterId.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(232, 294);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 16;
            label7.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 294);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 15;
            label8.Text = "Room Type";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(280, 288);
            textBox_name.Margin = new Padding(3, 2, 3, 2);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(207, 23);
            textBox_name.TabIndex = 14;
            // 
            // textBox_type
            // 
            textBox_type.Location = new Point(134, 288);
            textBox_type.Margin = new Padding(3, 2, 3, 2);
            textBox_type.Name = "textBox_type";
            textBox_type.Size = new Size(70, 23);
            textBox_type.TabIndex = 13;
            textBox_type.KeyPress += textBox_type_KeyPress;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(404, 343);
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
            label2.Location = new Point(248, 250);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "Theater ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 250);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 6;
            label1.Text = "Room Index";
            // 
            // textBox_index
            // 
            textBox_index.Location = new Point(134, 245);
            textBox_index.Margin = new Padding(3, 2, 3, 2);
            textBox_index.Name = "textBox_index";
            textBox_index.Size = new Size(110, 23);
            textBox_index.TabIndex = 4;
            textBox_index.KeyPress += textBox_index_KeyPress;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(426, 31);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(82, 22);
            btn_search.TabIndex = 36;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // comboBox_option
            // 
            comboBox_option.FormattingEnabled = true;
            comboBox_option.Location = new Point(267, 32);
            comboBox_option.Margin = new Padding(3, 2, 3, 2);
            comboBox_option.Name = "comboBox_option";
            comboBox_option.Size = new Size(148, 23);
            comboBox_option.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 37);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 35;
            label10.Text = "Search";
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(57, 32);
            textBox_search.Margin = new Padding(3, 2, 3, 2);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(189, 23);
            textBox_search.TabIndex = 34;
            // 
            // Form_Room
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 447);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Room";
            Text = "MainForm";
            Load += Form_Room_Load;
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
        private TextBox textBox_index;
        private Button deleteBtn;
        private Label label7;
        private Label label8;
        private TextBox textBox_name;
        private TextBox textBox_type;
        private FlatComboBox comboBox_theaterId;
        private Button btn_search;
        private FlatComboBox comboBox_option;
        private Label label10;
        private TextBox textBox_search;
    }
}