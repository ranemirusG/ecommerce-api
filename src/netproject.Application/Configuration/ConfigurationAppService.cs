using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using netproject.Configuration.Dto;

namespace netproject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : netprojectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
