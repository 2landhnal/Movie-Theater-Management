namespace Movie_Theater_Management
{
    partial class Form_Genre
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
            deleteBtn = new Button();
            label2 = new Label();
            label10 = new Label();
            label1 = new Label();
            textBox_search = new TextBox();
            textBox_Name = new TextBox();
            textBox_ID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // getBtn
            // 
            getBtn.Location = new Point(18, 285);
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
            addBtn.Location = new Point(191, 285);
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
            updateBtn.Location = new Point(346, 285);
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
            dataGridView1.Location = new Point(44, 71);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(514, 160);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(comboBox_option);
            groupBox1.Controls.Add(deleteBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_search);
            groupBox1.Controls.Add(textBox_Name);
            groupBox1.Controls.Add(textBox_ID);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(updateBtn);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(getBtn);
            groupBox1.Location = new Point(51, 32);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(606, 328);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Genre";
            // 
            // btn_search
            // 
            btn_search.Location = new Point(476, 30);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(82, 22);
            btn_search.TabIndex = 32;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // comboBox_option
            // 
            comboBox_option.FormattingEnabled = true;
            comboBox_option.Location = new Point(312, 29);
            comboBox_option.Margin = new Padding(3, 2, 3, 2);
            comboBox_option.Name = "comboBox_option";
            comboBox_option.Size = new Size(148, 23);
            comboBox_option.TabIndex = 33;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(501, 285);
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
            label2.Location = new Point(356, 253);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 34);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 31;
            label10.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 253);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 6;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(101, 29);
            textBox_search.Margin = new Padding(3, 2, 3, 2);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(189, 23);
            textBox_search.TabIndex = 30;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(402, 248);
            textBox_Name.Margin = new Padding(3, 2, 3, 2);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(110, 23);
            textBox_Name.TabIndex = 5;
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(101, 248);
            textBox_ID.Margin = new Padding(3, 2, 3, 2);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(110, 23);
            textBox_ID.TabIndex = 4;
            // 
            // Form_Genre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 414);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Genre";
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
        private TextBox textBox_Name;
        private TextBox textBox_ID;
        private Button deleteBtn;
        private Button btn_search;
        private FlatComboBox comboBox_option;
        private Label label10;
        private TextBox textBox_search;
    }
}