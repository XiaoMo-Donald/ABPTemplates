using System.Threading.Tasks;
using Abp.Application.Services;
using CloudAlliance.Authorization.Accounts.Dto;

namespace CloudAlliance.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
