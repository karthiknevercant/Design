using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Design.WebServiceProvider
{
    public class ResponseBase
    {
        [DeserializeAs(Name = "statusCode")]
        public int StatusCode { get; set; }

        [DeserializeAs(Name = "statusMessage")]
        public string Message { get; set; }
    }
}