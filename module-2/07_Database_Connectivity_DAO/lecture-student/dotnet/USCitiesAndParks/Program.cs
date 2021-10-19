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

            // connection string: server location; db name; credentials (username, password)
            ICityDao cityDao = new CitySqlDao(@"Server=.\SQLEXPRESS;Database=UnitedStates;Trusted_Connection=True;");
            IStateDao stateDao = new StateSqlDao(@"Server=.\SQLEXPRESS;Database=UnitedStates;Trusted_Connection=True;");
            IParkDao parkDao = new ParkSqlDao(@"Server=.\SQLEXPRESS;Database=UnitedStates;Trusted_Connection=True;");

            USCitiesAndParksCLI cli = new USCitiesAndParksCLI(cityDao, stateDao, parkDao);
            cli.RunCLI();
        }
    }
}
