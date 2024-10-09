using Param.DTOs.Pazaryeri_TP_AltUyeIsyeri_Liste;

namespace Param.Models.PazaryeriTPAltUyeIsyeriListe
{
    public class PazaryeriTPAltUyeIsyeriListeSonucViewModel
    {
        public int Toplam_Kayit { get; set; }
        public List<Pazaryeri_TP_AltUyeIsyeri_ListeDT_BilgiDTO>? DT_Bilgi { get; set; }
        public int Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
        public string? GUID_AltUyeIsyeri { get; set; }
    }
}