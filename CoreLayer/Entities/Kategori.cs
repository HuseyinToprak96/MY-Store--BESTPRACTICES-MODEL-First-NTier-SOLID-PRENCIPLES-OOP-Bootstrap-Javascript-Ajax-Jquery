﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Entities
{
   public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string Renk { get; set; }
        public List<AltKategori> altKategoriler { get; set; }
    }
}
