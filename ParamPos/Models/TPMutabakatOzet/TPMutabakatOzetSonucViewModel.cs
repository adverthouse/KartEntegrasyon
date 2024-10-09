using ParamPos.DTOs.TP_Mutabakat_Ozet;

namespace ParamPos.Models.TPMutabakatOzet
{
    public class TPMutabakatOzetSonucViewModel
    {
        public TP_Mutabakat_OzetDT_BilgiDTO? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}