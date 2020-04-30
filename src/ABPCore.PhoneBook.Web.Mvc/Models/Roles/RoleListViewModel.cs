using System.Collections.Generic;
using ABPCore.PhoneBook.Roles.Dto;

namespace ABPCore.PhoneBook.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
