using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Blogs
{
    public class PostSqlDao : IPostDao
    {
        private readonly string connectionString;

        public PostSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IList<Post> GetAllPosts()
        {
            IList<Post> allPosts = new List<Post>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT p.id, p.name, p.body, p.published, p.created " +
                        "FROM posts p";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Post post = new Post();

                        post.Body = Convert.ToString(reader["body"]);
                        post.Created = Convert.ToDateTime(reader["created"]);
                        post.Id = Convert.ToInt64(reader["id"]);
                        post.IsPublished = Convert.ToBoolean(reader["published"]);
                        post.Name = Convert.ToString(reader["name"]);

                        allPosts.Add(post);
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }

            return allPosts;
        }

        public void Save(Post newPost)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "INSERT INTO posts (name, body, published, created) " +
                        "VALUES(@name, @body, @published, @created)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    
                    cmd.Parameters.AddWithValue("@name", newPost.Name);
                    cmd.Parameters.AddWithValue("@body", newPost.Body);
                    cmd.Parameters.AddWithValue("@published", newPost.IsPublished);
                    cmd.Parameters.AddWithValue("@created", newPost.Created);

                    SqlDataReader reader = cmd.ExecuteReader();


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}