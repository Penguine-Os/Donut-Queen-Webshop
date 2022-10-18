using DonutQueen_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DonutQueen_Web.Data.Access
{
    public class DbInitializer : IDbInitializer
    {
        public void MaakLeverancierTabel(ApplicationDbContext db)
        {
            ApplicationDbContext dbContext = db;

            if (dbContext.Leveranciers.Any())
                return;

            var Leveranciers = new List<Leverancier>()
            {
                new Leverancier()
               {
                   Id= 0,
                   Naam="Het Bakkertje",
                   VoornaamContactpersoon = "Mark",
                   NaamContactpersoon = "Huygens",
                   Emailadres = "Mark.Huygens@gmail.com",
                   Straat = "Kerkstraat",
                   Huisnummer = 15,
                   PostCode = 2300
               },
                new Leverancier()
               {
                   Id= 0,
                   Naam="Uw warme bakker",
                   VoornaamContactpersoon = "Samira",
                   NaamContactpersoon = "Ben Akkra",
                   Emailadres = "uwb_Samira@hotmail.com",
                   Straat = "Grote Markt",
                   Huisnummer = 46,
                   PostCode = 2440
               },
                new Leverancier()
               {
                   Id= 0,
                   Naam="'t Banketbakkertje",
                   VoornaamContactpersoon = "Jean",
                   NaamContactpersoon = "François",
                   Emailadres = "mrjean@yahoo.com",
                   Straat = "Stationsplein",
                   Huisnummer = 5,
                   PostCode = 2500
               },
                new Leverancier()
               {
                   Id= 0,
                   Naam="Apnos groothandel",
                   VoornaamContactpersoon = "Marcel",
                   NaamContactpersoon = null,
                   Emailadres = "info@apnos.be",
                   Straat = "Industrieterrein",
                   Huisnummer = 137,
                   PostCode = 1000
               },
            };

            dbContext.Leveranciers.AddRange(Leveranciers);

            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ;
            }

            if (dbContext.LeverancierDonut.Any())
                return;


            var LevDev = new List<LeverancierDonut>()
            {
                new LeverancierDonut()
                {
                    Id = 0,
                    LeverancierId = 1,
                    DonutId = 3
                },
                new LeverancierDonut()
                {
                    Id = 0,
                    LeverancierId = 1,
                    DonutId = 4
                },
                new LeverancierDonut()
                {
                    Id = 0,
                    LeverancierId = 1,
                    DonutId = 6
                },
                new LeverancierDonut()
                {
                    Id = 0,
                    LeverancierId = 2,
                    DonutId = 4
                },
                new LeverancierDonut()
                {
                    Id = 0,
                    LeverancierId = 2,
                    DonutId = 6
                },
                new LeverancierDonut()
                {
                    Id = 0,
                    LeverancierId = 2,
                    DonutId = 8
                },
                new LeverancierDonut()
                {
                    Id = 0,
                    LeverancierId = 1,
                    DonutId = 7
                },
                new LeverancierDonut()
                {
                    Id = 0,
                    LeverancierId = 3,
                    DonutId = 9
                },
                new LeverancierDonut()
                {
                    Id = 0,
                    LeverancierId = 3,
                    DonutId = 3
                },
                new LeverancierDonut()
                {
                    Id = 0,
                    LeverancierId = 3,
                    DonutId = 10
                },
            };

            dbContext.LeverancierDonut.AddRange(LevDev);
            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}
