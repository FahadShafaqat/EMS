using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Security.Principal;

namespace HomeTask_Form
{
    public partial class Main : Form
    {
        private Employee_Management_System Sys;
        private List<Employee> Employees = new List<Employee>();
        public Main(Employee_Management_System ys)
        {
            InitializeComponent();
            Sys = ys;
            Employees = new List<Employee>();

            LoadEmployees();
        }
        private void LoadEmployees()
        {
            if (Sys != null)
            {
                Employees = Sys.GetAllEmployees();
                if (GridViewEmployees != null)
                {
                    GridViewEmployees.DataSource = Employees;
                }
                else
                {
                    MessageBox.Show("Data Grid is not Intialized");
                }
            }
            else
            {
                MessageBox.Show("Employees Management System is not Initialize");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (Add_New_Employee res = new HomeTask_Form.Add_New_Employee(Sys))
            {
                res.ShowDialog();
            }
            LoadEmployees();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Update_Employee res = new HomeTask_Form.Update_Employee(Sys, Employees)) { res.ShowDialog(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(Delete_Employee res = new HomeTask_Form.Delete_Employee(Sys,Employees)) {  res.ShowDialog(); }
        }
    }
}
