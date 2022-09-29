using DonutQueen_DAL.Data;
using DonutQueen_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutQueen_DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDonutRepo DonutRepo { get; private set; }

        public IWinkelRepo WinkelRepo { get; private set; }

        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            DonutRepo = new DonutRepo(db);
            WinkelRepo = new WinkelRepo(db);


        }

     
    }
}
