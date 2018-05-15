using System.Threading.Tasks;
using eOKUCore.Configuration.Dto;

namespace eOKUCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
