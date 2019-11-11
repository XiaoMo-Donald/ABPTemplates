using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CloudAlliance.Configuration;
using CloudAlliance.Web;

namespace CloudAlliance.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CloudAllianceDbContextFactory : IDesignTimeDbContextFactory<CloudAllianceDbContext>
    {
        public CloudAllianceDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CloudAllianceDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CloudAllianceDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CloudAllianceConsts.ConnectionStringName));

            return new CloudAllianceDbContext(builder.Options);
        }
    }
}
