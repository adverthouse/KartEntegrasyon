using TurkPosWS;
using ParamPos.DTOs.TP_Islem_Odeme_WKS;

namespace ParamPos.Models.TPIslemOdemeOnProvWKS
{
    public class TPIslemOdemeOnProvWKSSonucViewModel
    {
        public ST_TP_Islem_Odeme_OnProv? SonucNonSecure { get; set; }
        public TP_Islem_Odeme_WKSPostDTO? Sonuc3DSecure { get; set; }
    }
}