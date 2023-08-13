using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace netproject.EntityFrameworkCore
{
    public static class netprojectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<netprojectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<netprojectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
