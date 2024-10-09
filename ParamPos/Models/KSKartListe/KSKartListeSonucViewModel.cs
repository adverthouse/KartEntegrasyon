using ParamPos.DTOs.KS_Kart_Liste;

namespace ParamPos.Models.KSKartListe
{
    public class KSKartListeSonucViewModel
    {
        public List<KS_Kart_ListeDT_BilgiDTO>? DT_Bilgi { get; set; }
        public int? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}