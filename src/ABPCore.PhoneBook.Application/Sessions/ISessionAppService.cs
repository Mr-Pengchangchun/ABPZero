using System.Threading.Tasks;
using Abp.Application.Services;
using ABPCore.PhoneBook.Sessions.Dto;

namespace ABPCore.PhoneBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
