﻿using System.Xml;

namespace Param.DTOs.Pos_Plugin_Bildirim
{
    public class Pos_Plugin_BildirimResponseDTO
    {
        public XmlDocument? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}