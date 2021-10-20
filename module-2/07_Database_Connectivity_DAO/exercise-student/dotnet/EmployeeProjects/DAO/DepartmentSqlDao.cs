using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class DepartmentSqlDao : IDepartmentDao
    {
        private readonly string connectionString;

        public DepartmentSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Department GetDepartment(int departmentId)
        {
            Department department = null;

            try
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlStatement =
                        "SELECT department_id, name " +
                        "FROM department " +
                        "WHERE department_id = @departmentId;";
                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);
                    cmd.Parameters.AddWithValue("@departmentID", departmentId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        department = CreateDepartmentFromReader(reader);
                    }

                }

            }

            catch (Exception)
            {

                throw;
            }

            return department;
        }

        public IList<Department> GetAllDepartments()
        {
            IList<Department> departments = new List<Department>();

            try
            {


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlStatement =
                        "SELECT department_id, name " +
                        "FROM department;";
                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Department department = CreateDepartmentFromReader(reader);
                        departments.Add(department);
                    }

                }

            }

            catch (Exception)
            {

                throw;
            }

            return departments;

        }

        public void UpdateDepartment(Department updatedDepartment)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlStatement =
                        "UPDATE department " +
                        "SET name = @name " +
                        "WHERE department_id = @department_id;";
                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);
                    cmd.Parameters.AddWithValue("@department_id", updatedDepartment.DepartmentId);
                    cmd.Parameters.AddWithValue("@name", updatedDepartment.Name);

                    cmd.ExecuteNonQuery();
                }

            }

            catch (Exception)
            {

                throw;
            }

        }

        private Department CreateDepartmentFromReader(SqlDataReader reader)
        {
            Department department = new Department();

            department.DepartmentId = Convert.ToInt32(reader["department_id"]);
            department.Name = Convert.ToString(reader["name"]);

            return department;
        }

    }
}
