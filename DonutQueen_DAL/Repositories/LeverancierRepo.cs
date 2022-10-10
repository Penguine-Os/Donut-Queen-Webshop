using DonutQueen_DAL.Data;
using DonutQueen_DAL.IRepositories;
using DonutQueen_Models;

namespace DonutQueen_DAL.Repositories
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
