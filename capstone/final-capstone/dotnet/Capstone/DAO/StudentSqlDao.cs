using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class StudentSqlDao : IStudentSqlDao
    {
        private readonly string connectionString;
        public StudentSqlDao(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT [first-name] as firstname, [last-name] as lastname, quote FROM students", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var student = new Student();

                        student.FirstName = Convert.ToString(reader["firstname"]);
                        student.LastName = Convert.ToString(reader["lastname"]);
                        student.Quote = Convert.ToString(reader["quote"]);
                        students.Add(student);
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return students;
        }

    }
}
