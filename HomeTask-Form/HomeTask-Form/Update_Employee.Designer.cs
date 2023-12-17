namespace HomeTask_Form
{
    partial class Update_Employee
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
            emp_position = new ComboBox();
            emp_salary = new TextBox();
            emp_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            emp_id = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // emp_position
            // 
            emp_position.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp_position.FormattingEnabled = true;
            emp_position.Location = new Point(389, 321);
            emp_position.Name = "emp_position";
            emp_position.Size = new Size(281, 40);
            emp_position.TabIndex = 21;
            // 
            // emp_salary
            // 
            emp_salary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp_salary.Location = new Point(389, 397);
            emp_salary.Name = "emp_salary";
            emp_salary.Size = new Size(281, 39);
            emp_salary.TabIndex = 20;
            // 
            // emp_name
            // 
            emp_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp_name.Location = new Point(389, 242);
            emp_name.Name = "emp_name";
            emp_name.Size = new Size(281, 39);
            emp_name.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(177, 403);
            label4.Name = "label4";
            label4.Size = new Size(166, 28);
            label4.TabIndex = 18;
            label4.Text = "Employee Salary:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(177, 327);
            label3.Name = "label3";
            label3.Size = new Size(185, 28);
            label3.TabIndex = 17;
            label3.Text = "Employee Position:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(177, 248);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 16;
            label2.Text = "Employee Name:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(426, 520);
            button2.Name = "button2";
            button2.Size = new Size(151, 61);
            button2.TabIndex = 15;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(259, 520);
            button1.Name = "button1";
            button1.Size = new Size(151, 61);
            button1.TabIndex = 14;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 33);
            label1.Name = "label1";
            label1.Size = new Size(248, 38);
            label1.TabIndex = 0;
            label1.Text = "Update Employee";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 89);
            panel1.TabIndex = 13;
            // 
            // emp_id
            // 
            emp_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp_id.Location = new Point(389, 171);
            emp_id.Name = "emp_id";
            emp_id.Size = new Size(281, 39);
            emp_id.TabIndex = 23;
            emp_id.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(177, 177);
            label5.Name = "label5";
            label5.Size = new Size(132, 28);
            label5.TabIndex = 22;
            label5.Text = "Employee ID:";
            // 
            // Update_Employee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 646);
            Controls.Add(emp_id);
            Controls.Add(label5);
            Controls.Add(emp_position);
            Controls.Add(emp_salary);
            Controls.Add(emp_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Update_Employee";
            Text = "Update_Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox emp_position;
        private TextBox emp_salary;
        private TextBox emp_name;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel1;
        private TextBox emp_id;
        private Label label5;
    }
}