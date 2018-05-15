using Microsoft.AspNetCore.Antiforgery;
using eOKUCore.Controllers;

namespace eOKUCore.Web.Host.Controllers
{
    public class AntiForgeryController : eOKUCoreControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
