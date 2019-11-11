using Abp.AspNetCore.Mvc.ViewComponents;

namespace CloudAlliance.Web.Views
{
    public abstract class CloudAllianceViewComponent : AbpViewComponent
    {
        protected CloudAllianceViewComponent()
        {
            LocalizationSourceName = CloudAllianceConsts.LocalizationSourceName;
        }
    }
}
