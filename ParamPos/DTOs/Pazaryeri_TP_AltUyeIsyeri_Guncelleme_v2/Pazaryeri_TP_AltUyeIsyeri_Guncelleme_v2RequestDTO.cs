﻿using TurkPosWS;

namespace ParamPos.DTOs.Pazaryeri_TP_AltUyeIsyeri_Guncelleme_v2
{
    public class Pazaryeri_TP_AltUyeIsyeri_Guncelleme_v2RequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public string GUID_AltUyeIsyeri { get; set; } = string.Empty;
        public string Ad_Soyad { get; set; } = string.Empty;
        public string Unvan { get; set; } = string.Empty;
        public string GSM_No { get; set; } = string.Empty;
        public string IBAN_No { get; set; } = string.Empty;
        public string IBAN_Unvan { get; set; } = string.Empty;
        public string Adres { get; set; } = string.Empty;
        public string Il { get; set; } = string.Empty;
        public string Ilce { get; set; } = string.Empty;
        public string EPosta { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
        public string MCC_Kod { get; set; } = string.Empty;
        public string Vergi_Daire { get; set; } = string.Empty;
        public string Bagli_Olunan_Hesap { get; set; } = string.Empty;
        public string SAPId { get; set; } = string.Empty;
        public string MageontoId { get; set; } = string.Empty;
    }
}