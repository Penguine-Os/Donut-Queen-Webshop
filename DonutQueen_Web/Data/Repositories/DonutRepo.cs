using DonutQueen_Web.Data.Repositories;
using DonutQueen_Web.Data.IRepositories;
using DonutQueen_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonutQueen_Web.Data.Access;

namespace DonutQueen_Web.Data.Repositories
{
    public class DonutRepo : GenericRepo<Donut>, IDonutRepo
    {
        ApplicationDbContext _dbContext;

        //IEnumerable<Donut> Donuts = new List<Donut>()
        //{
        //    new Donut
        //    {
        //        Id = 1,
        //        Naam = "Banana pudding",
        //        Topping = "Koek kruimels",
        //        Glazuur = "Banaan",
        //        Vulling = "Banana creme",
        //        Omschrijving = "Donut gevuld met banana creme vulling, versierd met koek kruimels.",
        //        IsVegan = false,
        //        Afbeelding = "Banana_pudding.jpg"
        //    },
        //    new Donut
        //    {
        //        Id = 2,
        //        Naam = "Bluey",
        //        Topping = "Blauwe hagelslag",
        //        Glazuur = "Geen",
        //        Vulling = "Geen",
        //        Omschrijving = "Klassieke donut met blauwe hagelslag.",
        //        IsVegan = true,
        //        Afbeelding = "Bluey.jpg"
        //    },
        //    new Donut
        //    {
        //        Id = 3,
        //        Naam = "Chocolate rainbow",
        //        Topping = "Rainbow hagelslag",
        //        Glazuur = "Chocolade",
        //        Vulling = "Geen",
        //        Omschrijving = "Chocolade donut met gekleurde hagelslag.",
        //        IsVegan = false,
        //        Afbeelding = "Chocolate_rainbow.jpg"
        //    },
        //    new Donut
        //    {
        //        Id = 4,
        //        Naam = "Kitkat star",
        //        Topping = "Kitkat reep",
        //        Glazuur = "Chocolade",
        //        Vulling = "Chocolade",
        //        Omschrijving = "Donut gevuld met chocolade vulling, versierd met chocolade glazuur en een kitkat reep.",
        //        IsVegan = false,
        //        Afbeelding = "Kitkat_star.jpg"
        //    },
        //    new Donut
        //    {
        //        Id = 5,
        //        Naam = "Pinky",
        //        Topping = "Roze hagelslag",
        //        Glazuur = "Geen",
        //        Vulling = "Geen",
        //        Omschrijving = "Klassieke donut met roze hagelslag.",
        //        IsVegan = true,
        //        Afbeelding = "Pinky.jpg"
        //    },
        //    new Donut
        //    {
        //        Id = 6,
        //        Naam = "Stroopwafel",
        //        Topping = "Stroop-wafel + Caramel",
        //        Glazuur = "Chocolade",
        //        Vulling = "Caramel",
        //        Omschrijving = "Donut gevuld met caramel vulling, versierd met chocolade, een stroopwafel koekje en caramel.",
        //        IsVegan = false,
        //        Afbeelding = "Stroopwafel.png"
        //    },
        //    new Donut
        //    {
        //        Id = 7,
        //        Naam = "Red velvet",
        //        Topping = "Red velvet",
        //        Glazuur = "Geen",
        //        Vulling = "Cheese-cake",
        //        Omschrijving = "Donut gevuld met cheesecake vulling, versierd met red velvet kruimels.",
        //        IsVegan = false,
        //        Afbeelding = "Red_velvet.jpg"
        //    },
        //    new Donut
        //    {
        //        Id = 8,
        //        Naam = "Strawberry Cheesecake",
        //        Topping = "Koek kruimels",
        //        Glazuur = "Roze chocolade",
        //        Vulling = "Cheese-cake",
        //        Omschrijving = "Donut gevuld met cheesecake, versierd met roze chocolade en koek kruimels.",
        //        IsVegan = false,
        //        Afbeelding = "Strawberry_Cheesecake.jpg"
        //    },
        //    new Donut
        //    {
        //        Id = 9,
        //        Naam = "Strawberry swirl",
        //        Topping = "Geen",
        //        Glazuur = "Aardbei",
        //        Vulling = "Aardbei",
        //        Omschrijving = "Donut gevuld met aardbei vulling, versierd met aardbei glazuur.",
        //        IsVegan = false,
        //        Afbeelding = "Strawberry_swirl.png"
        //    },
        //    new Donut
        //    {
        //        Id = 10,
        //        Naam = "Pistache",
        //        Topping = "Pistache nootjes",
        //        Glazuur = "Pistache",
        //        Vulling = "Geen",
        //        Omschrijving = "Pistache donut met aan de bovenkant pistache nootjes.",
        //        IsVegan = false,
        //        Afbeelding = "Pistache.png"
        //    },

        //};
        //public IEnumerable<Donut> GetAll()
        //{

        //    return _dbContext.Donuts;
        //}

        //public Donut GetById(int id)
        //{
        //    if (id == 0 || id > _dbContext.Donuts.Count())
        //        return new Donut();

        //    return _dbContext.Donuts.Where(x => x.Id == id).First();
        //}
        //public IEnumerable<Donut> SearchByName(string name)
        //{
        //    if (string.IsNullOrWhiteSpace(name))
        //        return Enumerable.Empty<Donut>();

        //    return _dbContext.Donuts.Where(x => x.Naam.Contains(name, StringComparison.OrdinalIgnoreCase));
        //}

        //public void BulkInsert(IEnumerable<Donut> donuts)
        //{

        //    _dbContext.Donuts.AddRange(donuts);
        //    _dbContext.SaveChangesAsync();

        //}



        public DonutRepo(ApplicationDbContext db) : base(db)
        {
            _dbContext = db;
        }

    }
}
