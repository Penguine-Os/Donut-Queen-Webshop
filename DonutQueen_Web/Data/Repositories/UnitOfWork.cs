using DonutQueen_Web.Data.Repositories;
using DonutQueen_Web.Data.IRepositories;
using DonutQueen_Web.Data.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutQueen_Web.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDonutRepo DonutRepo { get; private set; }

        public IWinkelRepo WinkelRepo { get; private set; }
        public ILeverancierDonutRepo LeverancierDonutRepo { get; private set; }
        public ILeverancierRepo LeverancierRepo { get; private set; }

        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            DonutRepo = new DonutRepo(db);
            WinkelRepo = new WinkelRepo(db);

            LeverancierRepo = new LeverancierRepo(db);
            LeverancierDonutRepo = new LeverancierDonutRepo(db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }


    }
}
