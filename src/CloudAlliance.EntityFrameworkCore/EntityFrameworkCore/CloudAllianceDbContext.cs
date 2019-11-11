using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CloudAlliance.Authorization.Roles;
using CloudAlliance.Authorization.Users;
using CloudAlliance.MultiTenancy;

namespace CloudAlliance.EntityFrameworkCore
{
    public class CloudAllianceDbContext : AbpZeroDbContext<Tenant, Role, User, CloudAllianceDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CloudAllianceDbContext(DbContextOptions<CloudAllianceDbContext> options)
            : base(options)
        {
        }
    }
}
