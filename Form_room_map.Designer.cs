namespace Movie_Theater_Management
{
    partial class Form_room_map
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
            filePicker = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            deleteBtn = new Button();
            label1 = new Label();
            textBox_ID = new TextBox();
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
            getBtn.Location = new Point(56, 303);
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
            addBtn.Location = new Point(182, 303);
            addBtn.Margin = new Padding(3, 2, 3, 2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(82, 22);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // filePicker
            // 
            filePicker.Location = new Point(318, 260);
            filePicker.Margin = new Padding(3, 2, 3, 2);
            filePicker.Name = "filePicker";
            filePicker.Size = new Size(82, 22);
            filePicker.TabIndex = 2;
            filePicker.Text = "Room map";
            filePicker.UseVisualStyleBackColor = true;
            filePicker.Click += filePickerBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 90);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(396, 160);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(deleteBtn);
            groupBox1.Controls.Add(comboBox_option);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_search);
            groupBox1.Controls.Add(textBox_ID);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(filePicker);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(getBtn);
            groupBox1.Location = new Point(51, 20);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(462, 338);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Room map";
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(318, 303);
            deleteBtn.Margin = new Padding(3, 2, 3, 2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(82, 22);
            deleteBtn.TabIndex = 8;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 265);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(101, 260);
            textBox_ID.Margin = new Padding(3, 2, 3, 2);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(181, 23);
            textBox_ID.TabIndex = 4;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(182, 61);
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
            comboBox_option.Location = new Point(303, 32);
            comboBox_option.Margin = new Padding(3, 2, 3, 2);
            comboBox_option.Name = "comboBox_option";
            comboBox_option.Size = new Size(148, 23);
            comboBox_option.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 37);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 35;
            label10.Text = "Search";
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(92, 32);
            textBox_search.Margin = new Padding(3, 2, 3, 2);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(189, 23);
            textBox_search.TabIndex = 34;
            // 
            // Form_room_map
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 389);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_room_map";
            Text = "MainForm";
            Load += Form_room_map_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button getBtn;
        private Button addBtn;
        private Button filePicker;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox_ID;
        private Button deleteBtn;
        private Button btn_search;
        private FlatComboBox comboBox_option;
        private Label label10;
        private TextBox textBox_search;
    }
}