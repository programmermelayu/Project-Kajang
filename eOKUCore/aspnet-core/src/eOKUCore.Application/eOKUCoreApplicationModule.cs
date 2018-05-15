using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using eOKUCore.Authorization;

namespace eOKUCore
{
    [DependsOn(
        typeof(eOKUCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class eOKUCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<eOKUCoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(eOKUCoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
