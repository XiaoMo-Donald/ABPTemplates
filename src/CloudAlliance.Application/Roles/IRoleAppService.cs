using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CloudAlliance.Roles.Dto;

namespace CloudAlliance.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
