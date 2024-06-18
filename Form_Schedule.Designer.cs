﻿namespace Movie_Theater_Management
{
    partial class Form_Schedule
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
            btn_search = new Button();
            comboBox_option = new FlatComboBox();
            timePicker = new CustomeDateTimePicker();
            label10 = new Label();
            datePicker = new CustomeDateTimePicker();
            textBox_search = new TextBox();
            roomID = new FlatComboBox();
            movieID = new FlatComboBox();
            label4 = new Label();
            label3 = new Label();
            deleteBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // getBtn
            // 
            getBtn.Location = new Point(18, 352);
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
            addBtn.Location = new Point(191, 352);
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
            updateBtn.Location = new Point(346, 352);
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
            dataGridView1.Location = new Point(45, 79);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(514, 131);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(comboBox_option);
            groupBox1.Controls.Add(timePicker);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(datePicker);
            groupBox1.Controls.Add(textBox_search);
            groupBox1.Controls.Add(roomID);
            groupBox1.Controls.Add(movieID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(deleteBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(updateBtn);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(getBtn);
            groupBox1.Location = new Point(51, 24);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(606, 396);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Schedule";
            // 
            // btn_search
            // 
            btn_search.Location = new Point(485, 31);
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
            comboBox_option.Location = new Point(321, 30);
            comboBox_option.Margin = new Padding(3, 2, 3, 2);
            comboBox_option.Name = "comboBox_option";
            comboBox_option.Size = new Size(148, 23);
            comboBox_option.TabIndex = 37;
            // 
            // timePicker
            // 
            timePicker.BorderColor = Color.PaleVioletRed;
            timePicker.BorderSize = 0;
            timePicker.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            timePicker.Location = new Point(428, 312);
            timePicker.Margin = new Padding(3, 2, 3, 2);
            timePicker.MinimumSize = new Size(4, 35);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(115, 35);
            timePicker.SkinColor = Color.FromArgb(68, 71, 90);
            timePicker.TabIndex = 31;
            timePicker.TextColor = Color.FromArgb(189, 147, 249);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 35);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 35;
            label10.Text = "Search";
            // 
            // datePicker
            // 
            datePicker.BorderColor = Color.PaleVioletRed;
            datePicker.BorderSize = 0;
            datePicker.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            datePicker.Location = new Point(86, 312);
            datePicker.Margin = new Padding(3, 2, 3, 2);
            datePicker.MinimumSize = new Size(4, 35);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(219, 35);
            datePicker.SkinColor = Color.FromArgb(68, 71, 90);
            datePicker.TabIndex = 30;
            datePicker.TextColor = Color.FromArgb(189, 147, 249);
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(110, 30);
            textBox_search.Margin = new Padding(3, 2, 3, 2);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(189, 23);
            textBox_search.TabIndex = 34;
            // 
            // roomID
            // 
            roomID.FormattingEnabled = true;
            roomID.Location = new Point(86, 271);
            roomID.Margin = new Padding(3, 2, 3, 2);
            roomID.Name = "roomID";
            roomID.Size = new Size(457, 23);
            roomID.TabIndex = 29;
            // 
            // movieID
            // 
            movieID.FormattingEnabled = true;
            movieID.Location = new Point(86, 223);
            movieID.Margin = new Padding(3, 2, 3, 2);
            movieID.Name = "movieID";
            movieID.Size = new Size(457, 23);
            movieID.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 323);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 27;
            label4.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 323);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 25;
            label3.Text = "Date";
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(501, 352);
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
            label2.Location = new Point(21, 277);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 7;
            label2.Text = "Room ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 229);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Movie ID";
            // 
            // Form_Schedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 446);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Schedule";
            Text = "MainForm";
            Load += Form_Schedule_Load;
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
        private Button deleteBtn;
        private Label label3;
        private Label label4;
        private FlatComboBox roomID;
        private FlatComboBox movieID;
        private CustomeDateTimePicker datePicker;
        private CustomeDateTimePicker timePicker;
        private Button btn_search;
        private FlatComboBox comboBox_option;
        private Label label10;
        private TextBox textBox_search;
    }
}