using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using netproject.EntityFrameworkCore;
using netproject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace netproject.Web.Tests
{
    [DependsOn(
        typeof(netprojectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class netprojectWebTestModule : AbpModule
    {
        public netprojectWebTestModule(netprojectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(netprojectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(netprojectWebMvcModule).Assembly);
        }
    }
}