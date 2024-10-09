using Param.DTOs.BIN_SanalPos;

namespace Param.Models.BINSanalPos
{
    public class BINSanalPosSonucViewModel
    {
        public List<BIN_SanalPosDT_BilgiDTO>? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}