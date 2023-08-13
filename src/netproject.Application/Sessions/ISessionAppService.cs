using System.Threading.Tasks;
using Abp.Application.Services;
using netproject.Sessions.Dto;

namespace netproject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
