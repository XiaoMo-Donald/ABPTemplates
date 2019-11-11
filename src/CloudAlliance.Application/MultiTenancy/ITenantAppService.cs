using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CloudAlliance.MultiTenancy.Dto;

namespace CloudAlliance.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
