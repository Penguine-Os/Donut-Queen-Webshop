using DonutQueen_DAL.Data;
using DonutQueen_DAL.IRepositories;
using DonutQueen_Models;

namespace DonutQueen_DAL.Repositories
{
    public class WinkelRepo : IWinkelRepo
    {
       private ApplicationDbContext _dbContext;

        public WinkelRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        IEnumerable<Winkel> AlleWinkels = new List<Winkel>()
            {
                new Winkel()
                {
                    Id = 1,
                    Naam = "Campus Lier",
                    Straat = "Antwerpsestraat",
                    Nummer = 99,
                    Postcode = 2500,
                    Gemeente = "Lier",
                    Latitude = 51.1336114,
                    Longitude = 4.5666362


                },

                new Winkel()
                {
                    Id = 1,
                    Naam = "Campus Turnhout",
                    Straat = "Campus Blairon",
                    Nummer = 800,
                    Postcode = 2300,
                    Gemeente = "Turnhout",
                    Latitude = 51.317218,
                    Longitude = 4.9291412


                },

                new Winkel()
                {
                    Id = 1,
                    Naam = "Campus Geel",
                    Straat = "Kleinhoefstraat",
                    Nummer = 4,
                    Postcode = 2440,
                    Gemeente = "Geel",
                    Latitude = 51.1568249,
                    Longitude = 4.9676239


                }

            };

        public IEnumerable<Winkel> GetAll()
        {
            return AlleWinkels;
        }

        public IEnumerable<Winkel> GetByName(string name)
        {
            var test = AlleWinkels.Where(x => x.Naam.Contains(name,StringComparison.OrdinalIgnoreCase));
            return test;
        }
        public WinkelRepo()
        {

        }
       
    }
}
