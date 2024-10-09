using TurkPosWSTEST;
using Param.DTOs.Pos_Odeme;

namespace Param.Models.PosOdeme
{
    public class PosOdemeSonucViewModel
    {
        public ST_TP_Islem_Odeme? SonucNonSecure { get; set; }
        public Pos_OdemePostDTO? Sonuc3DSecure { get; set; }
    }
}