using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class EmployeeSqlDao : IEmployeeDao
    {
        private readonly string connectionString;

        public EmployeeSqlDao(string connString)
        {
            connectionString = connString;
        }

        public IList<Employee> GetAllEmployees()
        {
            IList<Employee> employees = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT employee_id, " +
                    "department_id, " +
                    "first_name, " +
                    "last_name, " +
                    "birth_date, " +
                    "hire_date " +
                    "FROM employee;";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employees.Add(employee);
                }

            }

            return employees;
        }

        public IList<Employee> SearchEmployeesByName(string firstNameSearch, string lastNameSearch)
        {
            IList<Employee> employeesByName = new List<Employee>();
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT employee_id, " +
                    "department_id, " +
                    "first_name, " +
                    "last_name, " +
                    "birth_date, " +
                    "hire_date " +
                    "FROM employee " +
                    "WHERE first_name LIKE '%' + @firstNameSearch + '%' " +
                    "AND last_name LIKE '%' + @lastNameSearch + '%';";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@firstNameSearch", firstNameSearch);
                cmd.Parameters.AddWithValue("@lastNameSearch", lastNameSearch);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employeesByName.Add(employee);
                }
            }            

            return employeesByName;
        }

        public IList<Employee> GetEmployeesByProjectId(int projectId)
        {
            IList<Employee> employeesByProject = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT employee.employee_id, " +
                    "employee.department_id, " +
                    "employee.first_name, " +
                    "employee.last_name, " +
                    "employee.birth_date, " +
                    "employee.hire_date " +
                    "FROM employee " +
                    "JOIN project_employee ON employee.employee_id = project_employee.employee_id " +
                    "WHERE project_employee.project_id = @projectId;";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@projectId", projectId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    employeesByProject.Add(employee);
                }
            }

            return employeesByProject;
        }

        public void AddEmployeeToProject(int projectId, int employeeId)
        {

        }

        public void RemoveEmployeeFromProject(int projectId, int employeeId)
        {

        }

        public IList<Employee> GetEmployeesWithoutProjects()
        {
            return new List<Employee>();
        }

        private Employee CreateEmployeeFromReader(SqlDataReader reader)
        {
            Employee employee = new Employee();

            employee.EmployeeId = Convert.ToInt32(reader["employee_id"]);
            employee.DepartmentId = Convert.ToInt32(reader["department_id"]);
            employee.FirstName = Convert.ToString(reader["first_name"]);
            employee.LastName = Convert.ToString(reader["last_name"]);
            employee.BirthDate = Convert.ToDateTime(reader["birth_date"]);
            employee.HireDate = Convert.ToDateTime(reader["hire_date"]);

            return employee;
        }

    }
}
