using AracIhaleDemo01.Models.Entities;
using AracIhaleDemo01.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AracIhaleDemo01.Controllers
{
    public class AracController : Controller
    {
        private readonly AracIhaleDemo01Entities context;

        public AracController(AracIhaleDemo01Entities _context)
        {
            context = _context;
        }

        public IActionResult AracEkle()
        {
            //var result = (from a in context.Arac
            //              select new AracEkleDTO
            //              {

            //              });
            return View();
        }
        [HttpGet]
        public IActionResult AracList()
        {
            var status = (from a in context.AracStatu
                          where a.IsActive == 1
                          select new AracStatuDTO
                          {
                              AracStatuID = a.AracStatuID,
                              AracStatuAdi = a.AracStatuAdi
                          }).ToList();

            var models = (from a in context.AracDetay
                          where a.IsActive == 1 && a.GrupAdi == "Model"
                          select new AracModelDTO
                          {
                              AracModelID = a.AracDetayID,
                              AracModelAdi = a.Value
                          }).ToList();

            var markas = (from a in context.AracDetay
                          where a.IsActive == 1 && a.GrupAdi == "Marka"
                          select new AracMarkaDTO
                          {
                              AracMarkaID = a.AracDetayID,
                              AracMarkaAdi = a.Value
                          }).ToList();

            ViewBag.AracMarkalari = new SelectList(markas, "AracMarkaID", "AracMarkaAdi");
            ViewBag.AracModelleri = new SelectList(models, "AracModelID", "AracModelAdi");
            ViewBag.AracStatuleri = new SelectList(status, "AracStatuID", "AracStatuAdi");

            if (TempData["aracList"] != null)
            {
                var serilizeData = TempData["aracList"].ToString();
                List<AracDTO> aracList = JsonSerializer.Deserialize<List<AracDTO>>(serilizeData);
                ViewBag.aracList = aracList;
                TempData["aracList"] = null;
            }
            return View();
        }

        [HttpPost]
        public IActionResult AracListPost(int aracMarkaId, int aracModelId, int aracStatuId)
        {
            List<AracDTO> aracList = (from a in context.Arac
                        join ad in context.AracDetay on a.MarkaId equals ad.AracDetayID
                        join k in context.Kullanici on a.CreatedBy equals k.KullaniciID
                        join s in context.AracStatu on a.AracStatuID equals s.AracStatuID
                        join x in context.AracDetay on a.ModelId equals x.AracDetayID
                        where a.IsActive == 1
                        select new AracDTO
                        {
                            AracID = a.AracID,
                            AracMarka = ad.Value,
                            AracMarkaID=a.MarkaId,
                            KaydedenKullaniciID = k.KullaniciID,
                            KaydedenKullanici = k.KullaniciAdi,
                            KaydetmeZamani = a.CreatedDate,
                            Statu = s.AracStatuAdi,
                            AracStatuID=a.AracStatuID,
                            AracModel = x.Value,
                            AracModelID=a.ModelId
                        }).ToList();

            if (aracMarkaId != 0)
            {
                aracList = aracList.Where(a => a.AracMarkaID == aracMarkaId).ToList();
            }
            if (aracStatuId != 0)
            {
                aracList = aracList.Where(a => a.AracStatuID == aracStatuId).ToList();
            }
            if (aracModelId != 0)
            {
                aracList = aracList.Where(a => a.AracModelID == aracModelId).ToList();
            }

            string serilizeData = JsonSerializer.Serialize(aracList);

            TempData["aracList"] = serilizeData;

            return RedirectToAction("aracList");
        }




    }
}
