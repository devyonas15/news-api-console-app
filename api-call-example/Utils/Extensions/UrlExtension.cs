using System.Text;

namespace api_call_example.Utils.Extensions;

public static class UrlExtension
{
    /// <summary>
    /// Generate dynamic query params starting with "?" 
    /// </summary>
    /// <param name="query">any query objects</param>
    /// <returns>query params</returns>
    public static string ToQueryParams(this object query)
    {
        var sb = new StringBuilder("?");

        foreach (var key in query.GetType().GetProperties())
        {
            var value = key.GetValue(query);
            if (value is not null)
            {
                sb.Append($"{key.Name.ToLower()}={value}&");
            }
        }

        return sb.ToString().Remove(sb.ToString().Length - 1);
    }
}