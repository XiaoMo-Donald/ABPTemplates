using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CloudAlliance.Controllers
{
    public abstract class CloudAllianceControllerBase: AbpController
    {
        protected CloudAllianceControllerBase()
        {
            LocalizationSourceName = CloudAllianceConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
