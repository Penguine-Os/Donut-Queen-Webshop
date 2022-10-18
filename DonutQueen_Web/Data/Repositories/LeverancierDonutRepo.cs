using DonutQueen_Web.Data.Access;
using DonutQueen_Models;
using DonutQueen_Web.Data.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace DonutQueen_Web.Data.Repositories
{
    public class LeverancierDonutRepo : GenericRepo<LeverancierDonut>, ILeverancierDonutRepo
    {
        ApplicationDbContext _db;
        public LeverancierDonutRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public List<LeverancierDonut> GetDonutPerLeverancier() 
        {
            var donutsPerLeveranciers = _db.LeverancierDonut
                .Include(x => x.Leverancier)
                .Include(y => y.Donut)
                .OrderBy(z => z.Leverancier.Naam)
                .ToList();

            return donutsPerLeveranciers;
        }
    }


}
