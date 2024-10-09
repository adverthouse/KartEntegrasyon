using Param.DTOs.TP_Mutabakat_Ozet;

namespace Param.Models.TPMutabakatOzet
{
    public class TPMutabakatOzetSonucViewModel
    {
        public TP_Mutabakat_OzetDT_BilgiDTO? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}