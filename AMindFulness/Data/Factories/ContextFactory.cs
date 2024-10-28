using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AMindFulness.Data.Factories
{
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<Context> optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseMySql("Server=sql3.freemysqlhosting.net;Database=sql3741179;User ID=sql3741179;Password=nbmBniYtSG;Port=3306;",
                new MySqlServerVersion(new Version(8, 0, 21)));

            return new Context(optionsBuilder.Options);
        }
    }
}