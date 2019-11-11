using System.Collections.Generic;
using CloudAlliance.Roles.Dto;
using CloudAlliance.Users.Dto;

namespace CloudAlliance.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
