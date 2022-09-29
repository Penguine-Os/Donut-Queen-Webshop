using DonutQueen_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutQueen_DAL.IRepositories
{
    public interface IUnitOfWork
    {
        public IDonutRepo DonutRepo { get; }
        public IWinkelRepo WinkelRepo { get; }
        
    }
}
