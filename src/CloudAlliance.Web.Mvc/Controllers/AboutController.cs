using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using CloudAlliance.Controllers;

namespace CloudAlliance.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : CloudAllianceControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
