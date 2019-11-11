using System.Threading.Tasks;
using CloudAlliance.Configuration.Dto;

namespace CloudAlliance.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
