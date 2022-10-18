using DonutQueen_Web.Data.Repositories;
using DonutQueen_Web.Data.IRepositories;
using DonutQueen_Web.Data.Access;
using DonutQueen_Models;

namespace DonutQueen_Web.Data.Repositories
{
    public class LeverancierRepo : GenericRepo<Leverancier>, ILeverancierRepo
    {
        ApplicationDbContext _db;
        public LeverancierRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }


}
