using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RoleBasedAuth.Controllers
{
    public class ManagerController : Controller
    {
        [Authorize(Roles="Manager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
