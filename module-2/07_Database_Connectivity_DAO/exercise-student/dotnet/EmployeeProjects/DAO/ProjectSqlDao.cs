using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class ProjectSqlDao : IProjectDao
    {
        private readonly string connectionString;

        public ProjectSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Project GetProject(int projectId)
        {
            Project project = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlStatement =
                        "SELECT project_id, name, from_date, to_date " +
                        "FROM project " +
                        "WHERE project_id = @projectId;";

                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);
                    cmd.Parameters.AddWithValue("@projectId", projectId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        project = CreateProjectFromReader(reader);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

            return project;

        }

        public IList<Project> GetAllProjects()
        {
            IList<Project> projects = new List<Project>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlStatement =
                        "SELECT " +
                            "project_id, " +
                            "name, " +
                            "from_date, " +
                            "to_date " +
                        "FROM project";

                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Project project = CreateProjectFromReader(reader);
                        projects.Add(project);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return projects;
        }

        public Project CreateProject(Project newProject)
        {
            int newProjectId;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlStatement =
                        "INSERT INTO project (name, from_date, to_date) " +
                        "OUTPUT INSERTED.project_id " +
                        "VALUES (@name, @from_date, @to_date);";
                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);

                    cmd.Parameters.AddWithValue("@name", newProject.Name);
                    cmd.Parameters.AddWithValue("@from_date", newProject.FromDate);
                    cmd.Parameters.AddWithValue("@to_date", newProject.ToDate);

                    newProjectId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception)
            {

                throw;
            }

            return GetProject(newProjectId);
        }

        public void DeleteProject(int projectId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlStatement =
                        "DELETE FROM project_employee " +
                        "WHERE project_id = @projectId;";

                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);
                    cmd.Parameters.AddWithValue("@projectId", projectId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlStatement =
                        "DELETE FROM project " +
                        "WHERE project_id = @projectId;";

                    SqlCommand cmd = new SqlCommand(sqlStatement, conn);
                    cmd.Parameters.AddWithValue("@projectId", projectId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private Project CreateProjectFromReader(SqlDataReader reader)
        {
            Project project = new Project();

            project.ProjectId = Convert.ToInt32(reader["project_id"]);
            project.Name = Convert.ToString(reader["name"]);
            project.FromDate = Convert.ToDateTime(reader["from_date"]);
            project.ToDate = Convert.ToDateTime(reader["to_date"]);

            return project;
        }

    }
}
