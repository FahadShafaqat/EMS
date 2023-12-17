namespace HomeTask_Form
{
    partial class Add_New_Employee
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
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            emp_name = new TextBox();
            emp_salary = new TextBox();
            emp_position = new ComboBox();
            emp_id = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(259, 454);
            button1.Name = "button1";
            button1.Size = new Size(151, 61);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 89);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 32);
            label1.Name = "label1";
            label1.Size = new Size(274, 38);
            label1.TabIndex = 0;
            label1.Text = "Add New Employee";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(426, 454);
            button2.Name = "button2";
            button2.Size = new Size(151, 61);
            button2.TabIndex = 5;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(179, 214);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 6;
            label2.Text = "Employee Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(179, 293);
            label3.Name = "label3";
            label3.Size = new Size(185, 28);
            label3.TabIndex = 7;
            label3.Text = "Employee Position:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(179, 369);
            label4.Name = "label4";
            label4.Size = new Size(166, 28);
            label4.TabIndex = 8;
            label4.Text = "Employee Salary:";
            // 
            // emp_name
            // 
            emp_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp_name.Location = new Point(391, 208);
            emp_name.Name = "emp_name";
            emp_name.Size = new Size(281, 39);
            emp_name.TabIndex = 9;
            // 
            // emp_salary
            // 
            emp_salary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp_salary.Location = new Point(391, 363);
            emp_salary.Name = "emp_salary";
            emp_salary.Size = new Size(281, 39);
            emp_salary.TabIndex = 11;
            // 
            // emp_position
            // 
            emp_position.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp_position.FormattingEnabled = true;
            emp_position.Location = new Point(391, 287);
            emp_position.Name = "emp_position";
            emp_position.Size = new Size(281, 40);
            emp_position.TabIndex = 12;
            // 
            // emp_id
            // 
            emp_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emp_id.Location = new Point(391, 141);
            emp_id.Name = "emp_id";
            emp_id.Size = new Size(281, 39);
            emp_id.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(179, 147);
            label5.Name = "label5";
            label5.Size = new Size(132, 28);
            label5.TabIndex = 13;
            label5.Text = "Employee ID:";
            // 
            // Add_New_Employee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 671);
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
            Name = "Add_New_Employee";
            Text = "Add_New_Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox emp_name;
        private TextBox emp_salary;
        private ComboBox emp_position;
        private TextBox emp_id;
        private Label label5;
    }
}