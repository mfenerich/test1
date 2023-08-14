using System;
using System.IO;
using System.Xml.Serialization;
using DTOs.SoapDTOs.Request;
using DTOs.SoapDTOs.Response;
using Generated;

namespace HelloPubSub.Utils
{
    public static class SoapXmlUtility
    {
        public static string GenerateXmlFromRequest(string sku)
        {
            
            var request = new ProductStockRequest
            {
                messageHeader = new ProductStockRequestMessageHeader
                {
                    clientId = "S1", // TODO: Get from config
                    clientName = "SparrowVentures", // TODO: Get from config
                    token = "35137be5-1823-44fd-a660-8c99ed7a6d83" // TODO: Get from config
                },
                requestProductStock = new ProductStockRequestRequestProductStock
                {
                    onlyStockItems = true,
                    itemNo = sku
                }
            };
            
            var envelope = new RequestEnvelope
            {
                Body = new RequestEnvelopeBody
                {
                    productStock = new ProductStock 
                    {
                        productStockRequest = request
                    }
                }
            };

            var serializer = new XmlSerializer(typeof(RequestEnvelope));
            var ns = new XmlSerializerNamespaces();
            ns.Add("soap", "http://schemas.xmlsoap.org/soap/envelope/");
            ns.Add("", "http://schemas.xmlsoap.org/soap/envelope/");

            using var writer = new StringWriter();
            serializer.Serialize(writer, envelope, ns);
            return writer.ToString();
        }

        public static productStockResponse DeserializeXmlToResponse(string receivedXml)
        {
            var deserializer = new XmlSerializer(typeof(ResponseEnvelope));

            using var reader = new StringReader(receivedXml);
            try 
            {
                var envelope = (ResponseEnvelope)deserializer.Deserialize(reader);
                //return envelope?.Body.productStockResponse.response;
                return envelope?.Body.productStockResponse;
            } 
            catch (InvalidOperationException ex) 
            {
                Console.WriteLine($"Error during deserialization: {ex.Message}");

                if (ex.InnerException != null) 
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }

                throw;
            }
        }
    }
}