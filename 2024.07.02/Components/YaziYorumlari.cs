using LayerBusiness.Manager;
using LayerDataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _2024._06._10.Components
{
    public class YaziYorumlari : ViewComponent
    {
        YorumYoneticisi yy = new YorumYoneticisi(new EFYorum());
        public IViewComponentResult Invoke(int id)
        {
            var yorumlar = yy.YaziYorumlariniGetir(id);
            return View(yorumlar);
        }
    }
}