using Abp.AutoMapper;
using ABPCore.PhoneBook.Roles.Dto;
using ABPCore.PhoneBook.Web.Models.Common;

namespace ABPCore.PhoneBook.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
