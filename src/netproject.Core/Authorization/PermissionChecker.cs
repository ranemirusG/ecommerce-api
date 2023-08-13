using Abp.Authorization;
using netproject.Authorization.Roles;
using netproject.Authorization.Users;

namespace netproject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
