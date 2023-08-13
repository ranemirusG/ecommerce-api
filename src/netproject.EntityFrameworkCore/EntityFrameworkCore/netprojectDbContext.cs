using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using netproject.Authorization.Roles;
using netproject.Authorization.Users;
using netproject.MultiTenancy;

namespace netproject.EntityFrameworkCore
{
    public class netprojectDbContext : AbpZeroDbContext<Tenant, Role, User, netprojectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public netprojectDbContext(DbContextOptions<netprojectDbContext> options)
            : base(options)
        {
        }
    }
}
