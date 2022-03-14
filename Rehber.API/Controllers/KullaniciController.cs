using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rehber.API.Data.Concrate;
using Rehber.Entities.Concrete;
using Rehber.Entities.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rehber.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : Controller
    {
        [HttpPost("Ekle")]
        public IActionResult Ekle(KullaniciEkleVM data) 
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Ad = data.Ad;
            kullanici.SoyAd = data.SoyAd;
            kullanici.Telefon = data.Telefon;
            kullanici.Aktif = true;
            kullanici.OlusturmaTarih = DateTime.Now;
                
            new KullaniciRepository().Ekle(kullanici);
            return Json(kullanici);
        }

        [HttpGet("Listele")]
        public IActionResult Listele()
        {
            List<Kullanici> kullanicilar = new KullaniciRepository().Liste();
            return Json(kullanicilar);
        }

    }
}
