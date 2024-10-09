using ParamPos.DTOs.TP_Islem_Izleme;

namespace ParamPos.Models.TPIslemIzleme
{
    public class TPIslemIzlemeSonucViewModel
    {
        public List<TP_Islem_IzlemeDT_BilgiDTO>? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}