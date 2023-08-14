using System.Xml.Serialization;
using Generated;

namespace DTOs.SoapDTOs.Request;

[XmlRoot("Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public class RequestEnvelope
{
    public RequestEnvelopeBody Body { get; set; }
}

public class RequestEnvelopeBody
{
    [XmlElement(Namespace = "http://ms-direct.ch/soap/msSoapDataHandling")]
    public ProductStock productStock { get; set; }
}

[XmlRoot("productStock", Namespace = "http://ms-direct.ch/soap/msSoapDataHandling")]
public class ProductStock
{
    [XmlElement("productStockRequest")]
    public ProductStockRequest productStockRequest { get; set; }
}