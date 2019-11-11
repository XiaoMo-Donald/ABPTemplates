using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CloudAlliance.Roles.Dto;
using CloudAlliance.Users.Dto;

namespace CloudAlliance.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
