using TP_KS;
using ParamPos.DTOs.KS_Tahsilat;

namespace ParamPos.Models.KSTahsilat
{
    public class KSTahsilatSonucViewModel
    {
        public ST_TP_Islem_Odeme? Sonuc { get; set; }
        public KS_TahsilatPOSTDTO? SonucPOST { get; set; }
    }
}