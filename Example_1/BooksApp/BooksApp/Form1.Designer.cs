namespace BooksApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 171);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(520, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(520, 31);
            textBox2.TabIndex = 5;
            // 
            // button
            // 
            button.Location = new Point(12, 227);
            button.Name = "button";
            button.Size = new Size(118, 60);
            button.TabIndex = 7;
            button.Text = "Insert (newRecord)";
            button.UseVisualStyleBackColor = true;
            button.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(136, 227);
            button1.Name = "button1";
            button1.Size = new Size(118, 60);
            button1.TabIndex = 8;
            button1.Text = "Update (editRecord)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(260, 227);
            button2.Name = "button2";
            button2.Size = new Size(140, 60);
            button2.TabIndex = 9;
            button2.Text = "Delete (deleteRecord)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(406, 227);
            button3.Name = "button3";
            button3.Size = new Size(118, 60);
            button3.TabIndex = 10;
            button3.Text = "Search (getRecord)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 306);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(636, 261);
            dataGridView1.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(530, 227);
            button4.Name = "button4";
            button4.Size = new Size(118, 60);
            button4.TabIndex = 12;
            button4.Text = "Show All (listRecord)";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(128, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(520, 31);
            textBox3.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 659);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private TextBox textBox3;
    }
}