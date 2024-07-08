using LayerBusiness.Manager;
using LayerDataAccess.EntityFramework;
using LayerEntity.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using System.Web.Helpers;

namespace _2024._06._10.Controllers
{
    public class BultenController : Controller
    {
        BultenYoneticisi by = new BultenYoneticisi(new EFBulten());
        public IActionResult BultenKullaniciEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BultenKullaniciEkle(Bulten bulten)
        {
            by.BultenKullanicisiEkle(bulten);
            return Redirect("~/Yazi/Yazilar");
        }

        public IActionResult BultenMailGonder()
        {
            var bultenKullanicilari = by.BultenKullanicilariniGetir();
            foreach (var bulten in bultenKullanicilari)
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Burası aynı kalacak
                client.Credentials = new NetworkCredential("erturkerdagi@gmail.com", "asasas");
                client.EnableSsl = true;
                MailMessage msj = new MailMessage(); //Yeni bir MailMesajı oluşturuyoruz
                msj.From = new MailAddress(bulten.Email, bulten.AdSoyad); //iletişim kısmında girilecek mail buaraya gelecektir
                msj.To.Add("erturkerdagi@gmail.com"); //Buraya kendi mail adresimizi yazıyoruz
                msj.Subject = "Blog Bülten"; //Buraya iletişim sayfasında gelecek konu ve mail adresini mail içeriğine yazacaktır
                msj.Body = "Deneme"; //Mail içeriği burada aktarılacakır
                client.Send(msj); //Clien sent kısmında gönderme işlemi gerçeklecektir.
                //Bu kısımdan itibaren sizden kullanıcıya gidecek mail bilgisidir 
                MailMessage msj1 = new MailMessage();
                msj1.From = new MailAddress("Kendimailadresiniz", "İstediğini bir ad yazabilirsiniz");
                msj1.To.Add("erturkerdagi@gmail.com"); //Buraua iletişim sayfasında gelecek mail adresi gelecktir.
                msj1.Subject = "Mail'inize Cevap";
                msj1.Body = "Size En kısa zamanda Döneceğiz. Teşekkür Ederiz Bizi tercih ettiğiniz için";
                client.Send(msj1);
                ViewBag.Succes = "teşekkürler Mailniz başarı bir şekilde gönderildi"; //Bu kısımlarda ise kullanıcıya bilgi vermek amacı ile olur
            }
            return View();
        }
    }
}