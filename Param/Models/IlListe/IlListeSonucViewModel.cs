﻿using Param.DTOs.Il_Liste;

namespace Param.Models.IlListe
{
    public class IlListeSonucViewModel
    {
        public int Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public List<Il_ListeDTDTO>? DT { get; set; }
    }
}