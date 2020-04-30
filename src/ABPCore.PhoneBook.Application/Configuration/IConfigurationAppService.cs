using System.Threading.Tasks;
using ABPCore.PhoneBook.Configuration.Dto;

namespace ABPCore.PhoneBook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
