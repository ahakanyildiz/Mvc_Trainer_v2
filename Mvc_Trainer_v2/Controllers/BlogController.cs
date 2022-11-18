using Microsoft.AspNetCore.Mvc;
using Mvc_Trainer_v2.Models;

namespace Mvc_Trainer_v2.Controllers
{
    public class BlogController : Controller
    {
        static List<Sehir> Sehirler = new List<Sehir>()
        {
            new Sehir()
            {
                Id=1,
                SehirAd="İstanbul",
                Aciklama="Türkiyenin en kalabalık şehri",
                ImgSrc="https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1b/33/f6/60/caption.jpg?w=700&h=500&s=1"
            },
              new Sehir()
            {
                Id=2,
                SehirAd="Ankara",
                Aciklama="Türkiyenin başkenti",
                ImgSrc="https://uo.asbu.edu.tr/sites/idari_birimler/uo.asbu.edu.tr/files/inline-images/Ankara.jpg"
            },
        };

        public IActionResult Index()
        {
            List<Sehir> list = Sehirler.ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult AddBlog()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(Sehir sehir)
        {
            var lastSehir = Sehirler.LastOrDefault();
            sehir.Id = lastSehir.Id + 1;
            Sehirler.Add(sehir);
            return RedirectToAction("Index");
        }

    }
}
