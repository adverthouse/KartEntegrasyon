﻿namespace Param.DTOs.TP_Islem_Odeme_OnProv_WMD
{
    public class TP_Islem_Odeme_OnProv_WMDResponseDTO
    {
        public long? Islem_ID { get; set; }
        public string? Islem_GUID { get; set; }
        public string? UCD_HTML { get; set; }
        public string? UCD_MD { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public string? Bank_Trans_ID { get; set; }
        public string? Bank_AuthCode { get; set; }
        public string? Bank_HostMsg { get; set; }
        public int? Banka_Sonuc_Kod { get; set; }
        public string? Bank_Extra { get; set; }
        public string? Siparis_ID { get; set; }
        public string? Bank_HostRefNum { get; set; }
        public string? Ext_Data { get; set; }
    }
}