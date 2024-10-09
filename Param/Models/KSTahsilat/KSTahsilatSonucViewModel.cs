using TP_KS;
using Param.DTOs.KS_Tahsilat;

namespace Param.Models.KSTahsilat
{
    public class KSTahsilatSonucViewModel
    {
        public ST_TP_Islem_Odeme? Sonuc { get; set; }
        public KS_TahsilatPOSTDTO? SonucPOST { get; set; }
    }
}