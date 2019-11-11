using Abp.Authorization;
using CloudAlliance.Authorization.Roles;
using CloudAlliance.Authorization.Users;

namespace CloudAlliance.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
