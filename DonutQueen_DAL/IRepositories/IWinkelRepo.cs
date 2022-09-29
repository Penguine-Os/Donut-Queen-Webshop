using DonutQueen_Models;

namespace DonutQueen_DAL.IRepositories
{
    public interface IWinkelRepo
    {
        IEnumerable<Winkel> GetAll();
        IEnumerable<Winkel> GetByName(string name);
    }
}
