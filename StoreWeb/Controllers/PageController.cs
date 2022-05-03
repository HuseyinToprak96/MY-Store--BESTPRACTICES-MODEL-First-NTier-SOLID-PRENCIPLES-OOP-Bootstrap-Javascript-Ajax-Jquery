﻿using CoreLayer.Entities;
using CoreLayer.Interfaces.Services;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StoreWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StoreWeb.Controllers
{
    public class PageController : Controller
    {
        private readonly IService<Cinsiyet> _Cinsiyetservice;
        private readonly IKategoriService _kategoriService;
        private readonly IUrunService _urunService;

        public PageController(IService<Cinsiyet> cinsiyetservice, IKategoriService kategoriService, IUrunService urunService)
        {
            _Cinsiyetservice = cinsiyetservice;
            _kategoriService = kategoriService;
            _urunService = urunService;
        }

        public async Task<IActionResult> Index()
        {
            VMIndex vMIndex = new VMIndex();
            vMIndex.Urunler = await _urunService.getAllAsync();
            vMIndex.Kategoriler = await _kategoriService.KategoriyeAitDetaylar();
            vMIndex.Cinsiyetler = await _Cinsiyetservice.getAllAsync();
            vMIndex.BitmesiYakinUrunler = await _urunService.BitmesiYakin();
            vMIndex.EnCokSatanlar = await _urunService.EncokSatan();
            vMIndex.FavoriUrunlar = _urunService.FavoriUrunler().Result;
            vMIndex.YeniGelenler = await _urunService.Yeni4Urun();
            return View(vMIndex);
        }
        public IActionResult Hakkimizda() => View();
        public IActionResult İletisim() => View();
        public IActionResult Magazalarimiz() => View();
        public IActionResult Vizyon() => View();
        public IActionResult Kurumsal() => View();
        public IActionResult İnsanKaynaklari() => View();
        public IActionResult Tarihce() => View();
        public IActionResult Kariyer() => View();
        public IActionResult KurumsalAkademi() => View();
        public IActionResult KariyerFirsatlari() => View();
        public IActionResult Basarilar() => View();
        public IActionResult Koleksiyonlar() => View();
    }
}
