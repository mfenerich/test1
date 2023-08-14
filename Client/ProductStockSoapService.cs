using System;
using System.Net.Http;
using System.Threading.Tasks;
using Generated;
using HelloPubSub.Utils;
using HttpRequestMessage = System.Net.Http.HttpRequestMessage;

namespace Client;

public class ProductStockSoapService
{
    private readonly HttpClient _client;

    public ProductStockSoapService(HttpClient client)
    {
        _client = client;
    }

    public async Task<productStockResponse> SendSoapRequestAsync()
    {
        try
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://soap-test02.ms-direct.ch/services/MS_DataHandlingDynamic/msDataHandling");
            request.Headers.Add("SOAPAction", "document/https://soap-test02.ms-direct.ch/:productStock");
            request.Headers.Add("Authorization", "Basic bXBAbXNkVFNUOkdrWGZNVTFrRFU5WlhPSmVHN2Iw");
                
            request.Content = new StringContent(SoapXmlUtility.GenerateXmlFromRequest("14-0000"), null, "text/xml");
            
            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            
            var respMock = @"<?xml version=""1.0"" encoding=""utf-8""?>
                <soap:Envelope xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                  <soap:Body>
                    <productStockResponse xmlns=""http://ms-direct.ch/soap/msSoapDataHandling"">
                      <messageHeader>
                        <clientId>string</clientId>
                        <clientName>string</clientName>
                        <token>string</token>
                      </messageHeader>
                      <productStockItems>
                        <productStockItem>
                          <itemNo>string</itemNo>
                          <calculatetQuantity>13</calculatetQuantity>
                          <qtyOnScrappingStore>4</qtyOnScrappingStore>
                          <statusDatum>2022-10-11T05:24:30.734Z</statusDatum>
                          <blocked>true</blocked>
                          <qtyOnPurchOrder>33</qtyOnPurchOrder>
                          <expectedReceiptDate>string</expectedReceiptDate>
                          <vendorItemNo>string</vendorItemNo>
                          <qtyOnExternalStock>50</qtyOnExternalStock>
                          <qtyOnLocalStock>78</qtyOnLocalStock>
                          <qtyOnSalesOrder>68</qtyOnSalesOrder>
                          <ean>string</ean>
                        </productStockItem>
                      </productStockItems>
                      <error>
                        <errorCode>string</errorCode>
                        <errorMessage>string</errorMessage>
                      </error>
                    </productStockResponse>
                  </soap:Body>
                </soap:Envelope>";
            
            //var responseObj = SoapXmlUtility.DeserializeXmlToResponse(await response.Content.ReadAsStringAsync());
            var responseObj = SoapXmlUtility.DeserializeXmlToResponse(respMock);
            return responseObj;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}