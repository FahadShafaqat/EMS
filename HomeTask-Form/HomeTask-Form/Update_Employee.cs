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
using System.Diagnostics.Eventing.Reader;
namespace HomeTask_Form
{
    public partial class Update_Employee : Form
    {
        private Employee_Management_System Sys;
        private List<Employee> Employees;
        public Update_Employee(Employee_Management_System sys,List<Employee> e)
        {
            InitializeComponent();
            Sys = sys;
            Employees = e;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool c = false;
            Employee em = new Employee {EmployeeID = (emp_id.Text).ToString(), EmployeeName = (emp_name.Text).ToString(),EmployeePosition = (emp_position.Text).ToString(), EmployeeSalary = decimal.Parse(emp_salary.Text) };
            foreach(Employee ee in Employees)
            {
                if(ee.EmployeeID == ((emp_id.Text).ToString()))
                {
                    Sys.DeleteEmployee(ee);
                    Sys.AddEmployee(em);
                    MessageBox.Show("Update Successfully");
                    c = true;
                    break;
                }
                
            }
            if(!c) { MessageBox.Show($"The User with this {emp_id.Text} do not exists."); }
        }
    }
}
