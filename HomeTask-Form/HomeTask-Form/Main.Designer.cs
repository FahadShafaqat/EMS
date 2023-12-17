namespace HomeTask_Form
{
    partial class Main
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            GridViewEmployees = new DataGridView();
            emp_id = new DataGridViewTextBoxColumn();
            emp_Name = new DataGridViewTextBoxColumn();
            emp_position = new DataGridViewTextBoxColumn();
            emp_salary = new DataGridViewTextBoxColumn();
            button4 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 89);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 35);
            label1.Name = "label1";
            label1.Size = new Size(430, 38);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(0, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(1016, 18);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 95);
            button1.Name = "button1";
            button1.Size = new Size(204, 61);
            button1.TabIndex = 2;
            button1.Text = "Add New Employee";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(276, 95);
            button2.Name = "button2";
            button2.Size = new Size(205, 61);
            button2.TabIndex = 3;
            button2.Text = "Update Employee";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(533, 95);
            button3.Name = "button3";
            button3.Size = new Size(199, 61);
            button3.TabIndex = 4;
            button3.Text = "Delete Employee";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(GridViewEmployees);
            panel3.Location = new Point(0, 179);
            panel3.Name = "panel3";
            panel3.Size = new Size(1016, 573);
            panel3.TabIndex = 5;
            // 
            // GridViewEmployees
            // 
            GridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewEmployees.Columns.AddRange(new DataGridViewColumn[] { emp_id, emp_Name, emp_position, emp_salary });
            GridViewEmployees.Dock = DockStyle.Fill;
            GridViewEmployees.Location = new Point(0, 0);
            GridViewEmployees.Name = "GridViewEmployees";
            GridViewEmployees.RowHeadersWidth = 62;
            GridViewEmployees.Size = new Size(1016, 573);
            GridViewEmployees.TabIndex = 0;
            // 
            // emp_id
            // 
            emp_id.HeaderText = "Employee ID";
            emp_id.MinimumWidth = 8;
            emp_id.Name = "emp_id";
            emp_id.Width = 250;
            // 
            // emp_Name
            // 
            emp_Name.HeaderText = "Employee Name";
            emp_Name.MinimumWidth = 8;
            emp_Name.Name = "emp_Name";
            emp_Name.Width = 250;
            // 
            // emp_position
            // 
            emp_position.HeaderText = "Employee Position";
            emp_position.MinimumWidth = 8;
            emp_position.Name = "emp_position";
            emp_position.Width = 250;
            // 
            // emp_salary
            // 
            emp_salary.HeaderText = "Employee Salary";
            emp_salary.MinimumWidth = 8;
            emp_salary.Name = "emp_salary";
            emp_salary.Width = 250;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(796, 95);
            button4.Name = "button4";
            button4.Size = new Size(199, 61);
            button4.TabIndex = 6;
            button4.Text = "View Employees";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 751);
            Controls.Add(button4);
            Controls.Add(panel3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridViewEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel3;
        private DataGridView GridViewEmployees;
        private DataGridViewTextBoxColumn emp_id;
        private DataGridViewTextBoxColumn emp_Name;
        private DataGridViewTextBoxColumn emp_position;
        private DataGridViewTextBoxColumn emp_salary;
        private Button button4;
    }
}
