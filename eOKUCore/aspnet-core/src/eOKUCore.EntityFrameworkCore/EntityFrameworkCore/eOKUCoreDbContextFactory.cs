using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using eOKUCore.Configuration;
using eOKUCore.Web;

namespace eOKUCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class eOKUCoreDbContextFactory : IDesignTimeDbContextFactory<eOKUCoreDbContext>
    {
        public eOKUCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<eOKUCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            eOKUCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(eOKUCoreConsts.ConnectionStringName));

            return new eOKUCoreDbContext(builder.Options);
        }
    }
}
