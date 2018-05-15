using Abp.Authorization;
using eOKUCore.Authorization.Roles;
using eOKUCore.Authorization.Users;

namespace eOKUCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
