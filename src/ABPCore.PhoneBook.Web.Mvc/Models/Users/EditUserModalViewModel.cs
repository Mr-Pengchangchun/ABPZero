using System.Collections.Generic;
using System.Linq;
using ABPCore.PhoneBook.Roles.Dto;
using ABPCore.PhoneBook.Users.Dto;

namespace ABPCore.PhoneBook.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
