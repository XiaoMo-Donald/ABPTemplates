using Microsoft.AspNetCore.Antiforgery;
using CloudAlliance.Controllers;

namespace CloudAlliance.Web.Host.Controllers
{
    public class AntiForgeryController : CloudAllianceControllerBase
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
