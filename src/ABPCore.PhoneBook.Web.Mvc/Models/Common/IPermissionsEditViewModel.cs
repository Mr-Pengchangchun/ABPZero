using System.Collections.Generic;
using ABPCore.PhoneBook.Roles.Dto;

namespace ABPCore.PhoneBook.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}