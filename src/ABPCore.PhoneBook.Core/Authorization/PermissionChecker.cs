using Abp.Authorization;
using ABPCore.PhoneBook.Authorization.Roles;
using ABPCore.PhoneBook.Authorization.Users;

namespace ABPCore.PhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
