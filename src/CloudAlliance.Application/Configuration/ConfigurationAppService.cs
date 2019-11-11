using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CloudAlliance.Configuration.Dto;

namespace CloudAlliance.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CloudAllianceAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
