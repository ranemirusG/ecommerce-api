using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using netproject.Authorization;

namespace netproject
{
    [DependsOn(
        typeof(netprojectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class netprojectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<netprojectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(netprojectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
