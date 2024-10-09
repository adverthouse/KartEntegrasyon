using Param.DTOs.Pazaryeri_TP_Islem_Sorgulama;

namespace Param.Models.PazaryeriTPIslemSorgulama
{
    public class PazaryeriTPIslemSorgulamaSonucViewModel
    {
        public List<Pazaryeri_TP_Islem_SorgulamaDT_BilgiDTO>? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}