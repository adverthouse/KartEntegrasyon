﻿using System.Xml;

namespace ParamPos.DTOs.Il_Liste
{
    public class Il_ListeResponseDTO
    {
        public int? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public XmlDocument? DT { get; set; }
    }
}