using ParamPos.DTOs.TP_Ozel_Oran_SK_Liste;

namespace ParamPos.Models.TPOzelOranSKListe
{
    public class TPOzelOranSKListeSonucViewModel
    {
        public List<TP_Ozel_Oran_SK_ListeDT_BilgiDTO>? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}