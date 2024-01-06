using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace GraphQL.RealEstateManager.Utilities
{
    public class GraphQLQuery
    {
        public string? OperationName { get; set; }
        public string? NamedQuery { get; set; }
        public string? Query { get; set; }
        //public JsonElement Variables { get; set; }
        public JObject? Variables { get; set; }
    }
}
