using System.Xml.Serialization;
using Generated;

namespace DTOs.SoapDTOs.Response;

[XmlRoot("Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public class ResponseEnvelope
{
    [XmlElement("Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public object Header { get; set; }

    [XmlElement("Body"/*, Namespace = "http://schemas.xmlsoap.org/soap/envelope/"*/)]
    public SoapBody Body { get; set; }
}

public class SoapBody
{
    [XmlElement("productStockResponse", Namespace = "http://ms-direct.ch/soap/msSoapDataHandling")]
    public productStockResponse productStockResponse { get; set; }
}
        
public class ProductStockResponseBody {
    public productStockResponse response { get; set; }
}