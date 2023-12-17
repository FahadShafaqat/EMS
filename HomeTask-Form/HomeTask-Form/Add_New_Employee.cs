using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace HomeTask_Form
{
    public partial class Add_New_Employee : Form
    {
        List<Employee> empList = new List<Employee>();
        Employee_Management_System Sys;
       
        public Add_New_Employee(Employee_Management_System sys)
        {
            InitializeComponent();
            Sys = sys;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sys.AddEmployee(empList);
            this.Close();
            Console.Write("Closed");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(emp_name.Text) && !string.IsNullOrEmpty(emp_position.Text) && !string.IsNullOrEmpty(emp_salary.Text) && !string.IsNullOrEmpty(emp_id.Text))
            {
                if (int.TryParse(emp_id.Text, out _))
                {
                    MessageBox.Show("Invalid Input. Please enter a valid value for Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (int.TryParse(emp_name.Text, out _))
                {
                    MessageBox.Show("Invalid Input. Please enter a valid value for Employee Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (int.TryParse(emp_position.Text, out _))
                {
                    MessageBox.Show("Invalid Input. Please enter a valid value for Employee Postion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                if (!double.TryParse(emp_salary.Text, out _))
                {
                    MessageBox.Show("Invalid Input. Please enter a valid value for Employee Salary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    Employee emp = new Employee 
                    { 
                        EmployeeID = (emp_id.Text).ToString(),
                        EmployeeName = (emp_name.Text).ToString(),
                        EmployeePosition = (emp_position.Text).ToString(),
                        EmployeeSalary = Decimal.Parse(emp_salary.Text)
                    };
                    empList.Add(emp);
                    MessageBox.Show("Number of Rows affected 1");

                    emp_id.Text = emp_name.Text = emp_position.Text = emp_salary.Text = string.Empty;
                  
                }
            }
            else
            {
                MessageBox.Show("Please Fill all boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
