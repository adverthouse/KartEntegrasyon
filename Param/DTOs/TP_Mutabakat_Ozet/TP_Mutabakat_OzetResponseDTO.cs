using System.Xml;

namespace Param.DTOs.TP_Mutabakat_Ozet
{
    public class TP_Mutabakat_OzetResponseDTO
    {
        public XmlDocument? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}