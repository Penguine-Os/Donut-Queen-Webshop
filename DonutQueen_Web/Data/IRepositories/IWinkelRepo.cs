using DonutQueen_Models;

namespace DonutQueen_Web.Data.IRepositories
{
    public interface IWinkelRepo
    {
        IEnumerable<Winkel> GetAll();
        IEnumerable<Winkel> GetByName(string name);
    }
}
