using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace eOKUCore.EntityFrameworkCore
{
    public static class eOKUCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<eOKUCoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<eOKUCoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
