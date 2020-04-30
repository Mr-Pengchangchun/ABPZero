using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ABPCore.PhoneBook.MultiTenancy;

namespace ABPCore.PhoneBook.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
