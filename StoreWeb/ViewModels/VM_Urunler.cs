﻿using CoreLayer.Entities;
using System.Collections.Generic;
using X.PagedList;

namespace StoreWeb.ViewModels
{
    public class VM_Urunler
    {
        //public IPagedList<Urun> Urunler { get; set; }
        public List<Urun> Urunler { get; set; }
        public List<AltKategori> AltKategoris { get; set; }
        public List<Kategori> kategoriler { get; set; }
        public List<KimeGore> kimeGore { get; set; }
    }
}
