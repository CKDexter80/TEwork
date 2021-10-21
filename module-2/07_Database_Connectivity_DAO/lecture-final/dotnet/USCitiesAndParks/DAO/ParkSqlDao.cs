using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using USCitiesAndParks.Models;

namespace USCitiesAndParks.DAO
{
    public class ParkSqlDao : IParkDao
    {
        private readonly string connectionString;

        public ParkSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Park GetPark(int parkId)
        {
            Park park = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                string sql = "SELECT park_name, date_established, area, has_camping FROM park WHERE park_id = @park_id;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@park_id", parkId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    park = CreateParkFromReader(reader);
                }

                return park;
            }
        }

        public IList<Park> GetParksByState(string stateAbbreviation)
        {
            IList<Park> parks = new List<Park>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT p.park_id, p.park_name, p.date_established, p.area, p.has_camping " +
                                "FROM park p " +
                                "JOIN park_state ps ON ps.park_id = p.park_id " +
                                "WHERE ps.state_abbreviation = @state_abbreviation";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@state_abbreviation", stateAbbreviation);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Park p = CreateParkFromReader(reader);
                    parks.Add(p);
                }
            }

            return parks;

        }

        public Park CreatePark(Park park)
        {
            Park createdPark = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO park (park_name, date_established, area, has_camping) " +
                    "OUTPUT INSERTED.park_id " +
                    "VALUES (@parkname, @dateestablished, @area, @hascamping);";
                SqlCommand cmd = new SqlCommand(sql , conn);
                cmd.Parameters.AddWithValue("@parkname", park.ParkName);
                cmd.Parameters.AddWithValue("@dateestablished", park.DateEstablished);
                cmd.Parameters.AddWithValue("@area", park.Area);
                cmd.Parameters.AddWithValue("@hascamping", park.HasCamping);

                int createdParkId = Convert.ToInt32(cmd.ExecuteScalar());
                createdPark = GetPark(createdParkId);

            }

            return createdPark;
        }

        public void UpdatePark(Park park)
        {
            throw new NotImplementedException();
        }

        public void DeletePark(int parkId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM park_state WHERE park_id = @parkid; " +
                             "DELETE FROM park WHERE park_id = @parkid;";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@parkid", parkId);

                cmd.ExecuteNonQuery();

            }
        }

        public void AddParkToState(int parkId, string state_abbreviation)
        {
            throw new NotImplementedException();
        }

        public void RemoveParkFromState(int parkId, string state_abbreviation)
        {
            throw new NotImplementedException();
        }

        private Park CreateParkFromReader(SqlDataReader reader)
        {
            // park_name, date_established, area, has_camping 

            Park park = new Park();
            park.ParkId = Convert.ToInt32(reader["park_id"]); //do we need id or not
            park.ParkName = Convert.ToString(reader["park_name"]);
            park.DateEstablished = Convert.ToDateTime(reader["date_established"]);
            park.HasCamping = Convert.ToBoolean(reader["has_camping"]);
            park.Area = Convert.ToDecimal(reader["area"]);

            return park;
        }
    }
}
