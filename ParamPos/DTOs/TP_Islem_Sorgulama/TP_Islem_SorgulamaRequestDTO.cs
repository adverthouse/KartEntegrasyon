﻿using TurkPosWS;

namespace ParamPos.DTOs.TP_Islem_Sorgulama
{
    public class TP_Islem_SorgulamaRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
        public string Dekont_ID { get; set; } = string.Empty;
        public string Siparis_ID { get; set; } = string.Empty;
        public string Islem_ID { get; set; } = string.Empty;
    }
}