﻿using TurkPosWSTEST;

namespace Param.DTOs.TP_Ozel_Oran_Liste
{
    public class TP_Ozel_Oran_ListeRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID { get; set; } = string.Empty;
    }
}