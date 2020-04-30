using System.Collections.Generic;
using ABPCore.PhoneBook.Roles.Dto;

namespace ABPCore.PhoneBook.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
