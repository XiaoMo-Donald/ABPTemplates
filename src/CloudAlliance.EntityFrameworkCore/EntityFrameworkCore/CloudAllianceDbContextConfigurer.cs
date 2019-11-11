using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CloudAlliance.EntityFrameworkCore
{
    public static class CloudAllianceDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CloudAllianceDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CloudAllianceDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
