using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask_Form
{
    public partial class Delete_Employee : Form
    {
        Employee_Management_System Sys;
        List<Employee> employees;
        public Delete_Employee(Employee_Management_System sys, List<Employee> emps)
        {
            InitializeComponent();
            Sys = sys;
            employees = emps;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool c = false;
            foreach (Employee emp in employees)
            {
                if (emp.EmployeeID == (emp_id.Text).ToString())
                {
                    Sys.DeleteEmployee(emp);
                    c = true;
                    MessageBox.Show($"Employee With ID: {emp_id.Text} has been deleted.");
                    emp_id.Text = string.Empty;
                    break;
                }
            }
            if (!c) { MessageBox.Show($"Employee With ID: {emp_id.Text} do not exist."); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
