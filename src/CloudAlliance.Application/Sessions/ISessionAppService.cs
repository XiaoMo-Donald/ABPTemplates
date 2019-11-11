using System.Threading.Tasks;
using Abp.Application.Services;
using CloudAlliance.Sessions.Dto;

namespace CloudAlliance.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
