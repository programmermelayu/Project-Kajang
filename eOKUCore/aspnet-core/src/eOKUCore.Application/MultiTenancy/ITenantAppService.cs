using Abp.Application.Services;
using Abp.Application.Services.Dto;
using eOKUCore.MultiTenancy.Dto;

namespace eOKUCore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
