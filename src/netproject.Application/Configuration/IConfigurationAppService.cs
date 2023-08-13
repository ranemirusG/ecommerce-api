using System.Threading.Tasks;
using netproject.Configuration.Dto;

namespace netproject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
