namespace Movie_Theater_Management
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
            timePicker = new CustomeDateTimePicker();
            datePicker = new CustomeDateTimePicker();
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
            getBtn.Location = new Point(21, 198);
            getBtn.Name = "getBtn";
            getBtn.Size = new Size(94, 29);
            getBtn.TabIndex = 0;
            getBtn.Text = "Get ";
            getBtn.UseVisualStyleBackColor = true;
            getBtn.Click += getBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(218, 198);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(396, 198);
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
            dataGridView1.Location = new Point(51, 267);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(587, 175);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(timePicker);
            groupBox1.Controls.Add(datePicker);
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
            groupBox1.Location = new Point(58, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(693, 467);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Genre";
            // 
            // timePicker
            // 
            timePicker.BorderColor = Color.PaleVioletRed;
            timePicker.BorderSize = 0;
            timePicker.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            timePicker.Location = new Point(489, 144);
            timePicker.MinimumSize = new Size(0, 35);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(131, 35);
            timePicker.SkinColor = Color.FromArgb(68, 71, 90);
            timePicker.TabIndex = 31;
            timePicker.TextColor = Color.FromArgb(189, 147, 249);
            // 
            // datePicker
            // 
            datePicker.BorderColor = Color.PaleVioletRed;
            datePicker.BorderSize = 0;
            datePicker.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            datePicker.Location = new Point(98, 144);
            datePicker.MinimumSize = new Size(0, 35);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(250, 35);
            datePicker.SkinColor = Color.FromArgb(68, 71, 90);
            datePicker.TabIndex = 30;
            datePicker.TextColor = Color.FromArgb(189, 147, 249);
            // 
            // roomID
            // 
            roomID.FormattingEnabled = true;
            roomID.Location = new Point(98, 89);
            roomID.Name = "roomID";
            roomID.Size = new Size(522, 28);
            roomID.TabIndex = 29;
            // 
            // movieID
            // 
            movieID.FormattingEnabled = true;
            movieID.Location = new Point(98, 25);
            movieID.Name = "movieID";
            movieID.Size = new Size(522, 28);
            movieID.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 159);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 27;
            label4.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 159);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 25;
            label3.Text = "Date";
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(573, 198);
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
            label2.Location = new Point(24, 97);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 7;
            label2.Text = "Room ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 6;
            label1.Text = "Movie ID";
            // 
            // Form_Schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
            Controls.Add(groupBox1);
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
    }
}