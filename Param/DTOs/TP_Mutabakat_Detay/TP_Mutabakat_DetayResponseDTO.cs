using System.Xml;

namespace Param.DTOs.TP_Mutabakat_Detay
{
    public class TP_Mutabakat_DetayResponseDTO
    {
        public XmlDocument? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}