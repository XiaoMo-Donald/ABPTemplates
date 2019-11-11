using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace CloudAlliance.Web.Views
{
    public abstract class CloudAllianceRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CloudAllianceRazorPage()
        {
            LocalizationSourceName = CloudAllianceConsts.LocalizationSourceName;
        }
    }
}
