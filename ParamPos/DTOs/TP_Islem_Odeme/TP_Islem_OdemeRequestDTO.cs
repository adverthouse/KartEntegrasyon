﻿using TurkPosWS;

namespace ParamPos.DTOs.TP_Islem_Odeme
{
    public class TP_Islem_OdemeRequestDTO
    {
        public ST_WS_Guvenlik G { get; set; } = null!;
        public int SanalPOS_ID { get; set; }
        public string GUID { get; set; } = string.Empty;
        public string KK_Sahibi { get; set; } = string.Empty;
        public string KK_No { get; set; } = string.Empty;
        public string KK_SK_Ay { get; set; } = string.Empty;
        public string KK_SK_Yil { get; set; } = string.Empty;
        public string KK_CVC { get; set; } = string.Empty;
        public string KK_Sahibi_GSM { get; set; } = string.Empty;
        public string Hata_URL { get; set; } = string.Empty;
        public string Basarili_URL { get; set; } = string.Empty;
        public string Siparis_ID { get; set; } = string.Empty;
        public string Siparis_Aciklama { get; set; } = string.Empty;
        public int Taksit { get; set; }
        public string Islem_Tutar { get; set; } = string.Empty;
        public string Toplam_Tutar { get; set; } = string.Empty;
        public string Islem_Hash { get; set; } = string.Empty;
        public string Islem_ID { get; set; } = string.Empty;
        public string IPAdr { get; set; } = string.Empty;
        public string Ref_URL { get; set; } = string.Empty;
        public string Data1 { get; set; } = string.Empty;
        public string Data2 { get; set; } = string.Empty;
        public string Data3 { get; set; } = string.Empty;
        public string Data4 { get; set; } = string.Empty;
        public string Data5 { get; set; } = string.Empty;
    }
}