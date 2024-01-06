using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace GraphQL.RealEstateManager.Utilities
{
    public static class JOBjectExtensions
    {
        public static Inputs ConvertToInputs(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
                return new Inputs(new Dictionary<string, object>());

            var jObject = JObject.Parse(json);
            var dictionary = jObject.ToObject<Dictionary<string, object>>();
            return new Inputs(dictionary!);
        }

        //public static Inputs ConvertToInputs(string json)
        //{
        //    if (string.IsNullOrWhiteSpace(json)) 
        //        return new Inputs(new Dictionary<string, object>());

        //    var dictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
        //    return new Inputs(dictionary);
        //}
    }
}
