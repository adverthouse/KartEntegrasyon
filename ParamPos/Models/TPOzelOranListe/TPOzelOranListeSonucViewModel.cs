﻿using ParamPos.DTOs.TP_Ozel_Oran_Liste;

namespace ParamPos.Models.TPOzelOranListe
{
    public class TPOzelOranListeSonucViewModel
    {
        public List<TP_Ozel_Oran_ListeDT_BilgiDTO>? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}