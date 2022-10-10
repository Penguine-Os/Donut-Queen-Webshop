using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutQueen_DAL.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
        {
            public ApplicationDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DonutQueenDb;Trusted_Connection=True");

                return new ApplicationDbContext(optionsBuilder.Options);
            }
        
    }
}
