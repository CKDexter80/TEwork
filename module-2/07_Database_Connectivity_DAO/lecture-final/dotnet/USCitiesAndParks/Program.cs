using Microsoft.Extensions.Configuration;
using System.IO;
using USCitiesAndParks.DAO;

namespace USCitiesAndParks
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("UnitedStates");

            //connection has server location, db name, credentials 
            ICityDao cityDao = new CitySqlDao(connectionString);
            IStateDao stateDao = new StateSqlDao(connectionString);
            IParkDao parkDao = new ParkSqlDao(connectionString);

            USCitiesAndParksCLI cli = new USCitiesAndParksCLI(cityDao, stateDao, parkDao);
            cli.RunCLI();
        }
    }
}
