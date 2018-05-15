using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using eOKUCore.Configuration;

namespace eOKUCore.Web.Host.Startup
{
    [DependsOn(
       typeof(eOKUCoreWebCoreModule))]
    public class eOKUCoreWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public eOKUCoreWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(eOKUCoreWebHostModule).GetAssembly());
        }
    }
}
