﻿using System.Xml;

namespace ParamPos.DTOs.TP_Islem_Sorgulama
{
    public class TP_Islem_SorgulamaResponseDTO
    {
        public XmlDocument? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}