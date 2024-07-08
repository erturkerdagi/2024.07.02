using LayerBusiness.Manager;
using LayerDataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _2024._06._10.Components
{
    public class YazarinYazilari : ViewComponent
    {
        YaziYoneticisi yy = new YaziYoneticisi(new EFYazi(), new EFKategori(), new EFYazar());
        public IViewComponentResult Invoke(int id)
        {
            var yazilar = yy.YaziGetirYazaraAit(id);
            return View(yazilar);
        }
    }
}
