using System.Text.Json.Serialization;

namespace api_call_example.DTOs;

public sealed class GetAllNewsByParamsQuery
{
    /// <summary>
    /// Gets or sets the news keyword
    /// </summary>
    [JsonPropertyName("q")]
    public string Q { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the start date, default is an empty string
    /// </summary>
    [JsonPropertyName("from")]
    public string? From { get; set; }

    /// <summary>
    /// Gets or sets the end date
    /// </summary>
    [JsonPropertyName("to")]
    public string? To { get; set; }

    /// <summary>
    /// Gets or sets the sorting term
    /// </summary>
    [JsonPropertyName("sortBy")]
    public string? SortBy { get; set; }

    /// <summary>
    /// Gets or sets the API KEY, default is the API Key
    /// </summary>
    [JsonPropertyName("apiKey")]
    public string ApiKey { get; set; } = string.Empty;
}