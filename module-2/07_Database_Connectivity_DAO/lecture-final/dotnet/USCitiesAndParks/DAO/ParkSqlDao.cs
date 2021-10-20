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
            throw new NotImplementedException();
        }

        public Park CreatePark(Park park)
        {
            throw new NotImplementedException();
        }

        public void UpdatePark(Park park)
        {
            throw new NotImplementedException();
        }

        public void DeletePark(int parkId)
        {
            throw new NotImplementedException();
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
            //park.ParkId = Convert.ToInt32(reader[""]) //do we need id or not
            park.ParkName = Convert.ToString(reader["park_name"]);
            park.DateEstablished = Convert.ToDateTime(reader["date_established"]);
            park.HasCamping = Convert.ToBoolean(reader["has_camping"]);
            park.Area = Convert.ToDecimal(reader["area"]);

            return park;
        }
    }
}
