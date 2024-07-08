using LayerBusiness.Manager;
using LayerDataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _2024._06._10.Controllers
{
    public class YorumController : Controller
    {
        YorumYoneticisi yy = new YorumYoneticisi(new EFYorum());
        public IActionResult AdminYorumListeleme()
        {
            if (HttpContext.Session.GetString("AdminKullaniciID") == null)
            {
                return Redirect("~/Kullanici/AdminLogin");
            }
            else
            {
                return View(yy.YorumGetir());
            }
        }
    }
}
