using System.Threading.Tasks;
using Abp.Application.Services;
using ABPCore.PhoneBook.Authorization.Accounts.Dto;

namespace ABPCore.PhoneBook.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
