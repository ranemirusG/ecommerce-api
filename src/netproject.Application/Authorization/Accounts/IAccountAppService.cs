using System.Threading.Tasks;
using Abp.Application.Services;
using netproject.Authorization.Accounts.Dto;

namespace netproject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
