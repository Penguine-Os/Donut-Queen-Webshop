using DonutQueen_Models;

namespace DonutQueen_Web.Data.IRepositories
{
    public interface ILeverancierDonutRepo : IGenericRepo<LeverancierDonut>
    {
        List<LeverancierDonut> GetDonutPerLeverancier();
    }
}