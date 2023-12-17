using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_Form
{
    public class Employee_Management_System
    {
        string connectionstring = "Data Source=DESKTOP-L7U2DJC\\SQLEXPRESS;Initial Catalog=Employee_Management;Integrated Security=True;";
       
        public void AddEmployee(List<Employee> emp)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                if(emp != null)
                {

                    foreach (Employee employee in emp)
                    {
                        string insertQuery = "INSERT INTO Employees(EmployeeID, Employee_Name, Employee_Position, Employee_Salary) VALUES (@Emp_id,@Emp_Nam,@Emp_Pos,@Emp_Sal)";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Emp_id", employee.EmployeeID);
                            command.Parameters.AddWithValue("@Emp_Nam", employee.EmployeeName);
                            command.Parameters.AddWithValue("@Emp_Pos", employee.EmployeePosition);
                            command.Parameters.AddWithValue("@Emp_Sal", employee.EmployeeSalary);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                
            }
        }
        public void AddEmployee(Employee emp)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                
                        string insertQuery = "INSERT INTO Employees(EmployeeID, Employee_Name, Employee_Position, Employee_Salary) VALUES (@Emp_id,@Emp_Nam,@Emp_Pos,@Emp_Sal)";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Emp_id", emp.EmployeeID);
                            command.Parameters.AddWithValue("@Emp_Nam", emp.EmployeeName);
                            command.Parameters.AddWithValue("@Emp_Pos", emp.EmployeePosition);
                            command.Parameters.AddWithValue("@Emp_Sal", emp.EmployeeSalary);
                            command.ExecuteNonQuery();
                        }
                    

            }
        }


        public List<Employee> GetAllEmployees()
        {
            List<Employee> emp = new List<Employee>();

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string query = "SELECT * FROM Employees";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Employee em = new Employee
                            {
                                EmployeeID = (reader["EmployeeID"]).ToString(),
                                EmployeeName = (reader["Employee_Name"]).ToString(),
                                EmployeePosition = (reader["Employee_Position"]).ToString(),
                                EmployeeSalary = Convert.ToDecimal(reader["Employee_Salary"])
                            };
                            emp.Add(em);
                        }
                    }
                }
            }
            return emp;
        }

        public void DeleteEmployee(Employee emp)
        {
            using(SqlConnection  connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                string query = "DELETE FROM Employees WHERE (EmployeeID = @empid)";
                using(SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@empid", emp.EmployeeID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
