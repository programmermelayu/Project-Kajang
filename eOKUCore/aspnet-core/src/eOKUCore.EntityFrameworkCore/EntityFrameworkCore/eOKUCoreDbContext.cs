using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using eOKUCore.Authorization.Roles;
using eOKUCore.Authorization.Users;
using eOKUCore.MultiTenancy;

namespace eOKUCore.EntityFrameworkCore
{
    public class eOKUCoreDbContext : AbpZeroDbContext<Tenant, Role, User, eOKUCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public eOKUCoreDbContext(DbContextOptions<eOKUCoreDbContext> options)
            : base(options)
        {
        }
    }
}
