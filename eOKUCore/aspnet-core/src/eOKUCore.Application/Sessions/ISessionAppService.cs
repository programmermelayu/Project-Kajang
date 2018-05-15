using System.Threading.Tasks;
using Abp.Application.Services;
using eOKUCore.Sessions.Dto;

namespace eOKUCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
