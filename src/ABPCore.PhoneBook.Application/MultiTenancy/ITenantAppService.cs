using Abp.Application.Services;
using ABPCore.PhoneBook.MultiTenancy.Dto;

namespace ABPCore.PhoneBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

