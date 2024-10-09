using System.Xml;

namespace Param.DTOs.MoneyPay_Islem_Sorgulama
{
    public class MoneyPay_Islem_SorgulamaResponseDTO
    {
        public XmlDocument? DT_Bilgi { get; set; }
        public string? Sonuc { get; set; }
        public string? Sonuc_Str { get; set; }
    }
}