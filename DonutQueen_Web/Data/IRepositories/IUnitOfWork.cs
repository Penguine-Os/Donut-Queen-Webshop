using DonutQueen_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutQueen_Web.Data.IRepositories
{
    public interface IUnitOfWork
    {
        public IDonutRepo DonutRepo { get; }
        public IWinkelRepo WinkelRepo { get; }
        ILeverancierRepo LeverancierRepo { get; }
        ILeverancierDonutRepo LeverancierDonutRepo { get; }

        void Save();
    }
}
