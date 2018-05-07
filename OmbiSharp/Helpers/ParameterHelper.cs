using System.Collections.Generic;

namespace OmbiSharp.Helpers
{
    internal class ParameterHelper
    {
        internal static string BuildParameterString(Dictionary<string, object> keyValuePairs)
        {
            if (keyValuePairs.Count == 0) return null;

            string output = null;
            bool firstParam = true;

            foreach (var keyValue in keyValuePairs)
            {
                if (firstParam)
                {
                    output += $"?{keyValue.Key}={keyValue.Value.ToString()}";
                    firstParam = false;
                    continue;
                }

                output += $"&{keyValue.Key}={keyValue.Value.ToString()}";
            }

            return output;
        }
    }
}
