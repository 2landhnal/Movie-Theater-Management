namespace Movie_Theater_Management
{
    partial class Form_ticket_price
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
            comboBox_seatType = new FlatComboBox();
            label7 = new Label();
            label8 = new Label();
            textBox_price = new TextBox();
            deleteBtn = new Button();
            label1 = new Label();
            textBox_scheduleId = new TextBox();
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
            getBtn.Location = new Point(47, 312);
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
            addBtn.Location = new Point(186, 312);
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
            updateBtn.Location = new Point(341, 312);
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
            dataGridView1.Location = new Point(47, 78);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(529, 123);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(comboBox_option);
            groupBox1.Controls.Add(comboBox_seatType);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox_search);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox_price);
            groupBox1.Controls.Add(deleteBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_scheduleId);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(updateBtn);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(getBtn);
            groupBox1.Location = new Point(51, 24);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(632, 350);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ticket price";
            // 
            // comboBox_seatType
            // 
            comboBox_seatType.FormattingEnabled = true;
            comboBox_seatType.Location = new Point(138, 257);
            comboBox_seatType.Margin = new Padding(3, 2, 3, 2);
            comboBox_seatType.Name = "comboBox_seatType";
            comboBox_seatType.Size = new Size(190, 23);
            comboBox_seatType.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(341, 262);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 16;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 262);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 15;
            label8.Text = "Seat type";
            // 
            // textBox_price
            // 
            textBox_price.Location = new Point(382, 257);
            textBox_price.Margin = new Padding(3, 2, 3, 2);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(195, 23);
            textBox_price.TabIndex = 14;
            textBox_price.KeyPress += textBox_rate_KeyPress;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(494, 312);
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
            label1.Location = new Point(56, 219);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 6;
            label1.Text = "Schedule ID";
            // 
            // textBox_scheduleId
            // 
            textBox_scheduleId.Location = new Point(138, 214);
            textBox_scheduleId.Margin = new Padding(3, 2, 3, 2);
            textBox_scheduleId.Name = "textBox_scheduleId";
            textBox_scheduleId.Size = new Size(439, 23);
            textBox_scheduleId.TabIndex = 4;
            textBox_scheduleId.KeyPress += textBox_scheduleId_KeyPress;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(494, 33);
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
            comboBox_option.Location = new Point(330, 32);
            comboBox_option.Margin = new Padding(3, 2, 3, 2);
            comboBox_option.Name = "comboBox_option";
            comboBox_option.Size = new Size(148, 23);
            comboBox_option.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 37);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 35;
            label10.Text = "Search";
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(90, 32);
            textBox_search.Margin = new Padding(3, 2, 3, 2);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(218, 23);
            textBox_search.TabIndex = 34;
            // 
            // Form_ticket_price
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 400);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_ticket_price";
            Text = "MainForm";
            Load += Form_ticket_price_Load;
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
        private Label label1;
        private Button deleteBtn;
        private Label label7;
        private Label label8;
        private TextBox textBox_price;
        private TextBox textBox_scheduleId;
        private FlatComboBox comboBox_seatType;
        private Button btn_search;
        private FlatComboBox comboBox_option;
        private Label label10;
        private TextBox textBox_search;
    }
}