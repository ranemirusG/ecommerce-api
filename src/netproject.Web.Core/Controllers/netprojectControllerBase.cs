using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace netproject.Controllers
{
    public abstract class netprojectControllerBase: AbpController
    {
        protected netprojectControllerBase()
        {
            LocalizationSourceName = netprojectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
