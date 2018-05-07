using System.Net;
using System.Reflection;

namespace OmbiSharp.Helpers
{
    internal class WebClientHelpers
    {
        internal static WebHeaderCollection GetWebHeaderCollection(string apiKey)
        {
            return new WebHeaderCollection
            {
                { "ApiKey", apiKey },
                { "Content-Type", "application/json" },
                { "User-Agent", $"{Assembly.GetExecutingAssembly().GetName().Name.Replace(" ", ".")}.v{Assembly.GetExecutingAssembly().GetName().Version}" }
            };
        }
    }
}
