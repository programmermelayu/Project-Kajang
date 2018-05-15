using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace eOKUCore.Controllers
{
    public abstract class eOKUCoreControllerBase: AbpController
    {
        protected eOKUCoreControllerBase()
        {
            LocalizationSourceName = eOKUCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
