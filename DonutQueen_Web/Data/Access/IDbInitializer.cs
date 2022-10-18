namespace DonutQueen_Web.Data.Access
{
    public interface IDbInitializer
    {
        void MaakLeverancierTabel(ApplicationDbContext db);
    }
}