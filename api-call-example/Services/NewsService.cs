using System.Text.Json;
using api_call_example.Constants;
using api_call_example.DTOs;
using api_call_example.Utils.Extensions;

namespace api_call_example.Services;

public sealed class NewsService
{
    /// <summary>
    /// Get All News By Parameters
    /// </summary>
    /// <param name="client"></param>
    /// <param name="query">query parameters.</param>
    /// <returns>News Response as literal strings.</returns>
    /// <exception cref="HttpRequestException">When the request fails</exception>
    /// <exception cref="ArgumentException">When the JSON result is null</exception>
    /// <exception cref="JsonException">When the JSON result to deserialise is an invalid JSON</exception>
    public async Task<NewsResponse?> GetAllNewsByParams(HttpClient client, GetAllNewsByParamsQuery query)
    { 
        var httpResponse = await client.GetAsync($"{UrlConstant.BaseUrl}{UrlConstant.AllUrlsEndpoint}{query.ToQueryParams()}");
        httpResponse.EnsureSuccessStatusCode();

        var jsonData = await httpResponse.Content.ReadAsStringAsync();

        var result = JsonSerializer.Deserialize<NewsResponse>(jsonData);
        
        return result;
    }
}