using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ABPCore.PhoneBook.Controllers;

namespace ABPCore.PhoneBook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
