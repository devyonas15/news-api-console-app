using System.Text.Json.Serialization;

namespace api_call_example.DTOs;

public sealed class Source
{
    /// <summary>
    /// Source ID
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Source name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public sealed class Article
{
    /// <summary>
    /// Source of the news
    /// </summary>
    [JsonPropertyName("source")]
    public Source? Source { get; set; }

    /// <summary>
    /// Author of the news
    /// </summary>
    [JsonPropertyName("author")]
    public string? Author { get; set; }

    /// <summary>
    /// Title of the news
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// News description
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// News url
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// News image url
    /// </summary>
    [JsonPropertyName("urlToImage")]
    public string? UrlToImage { get; set; }

    /// <summary>
    /// Publish date
    /// </summary>
    [JsonPropertyName("publishedAt")]
    public string? PublishedAt { get; set; }


    /// <summary>
    /// Trimmed news content
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
}

public sealed class NewsResponse
{
    /// <summary>
    /// Status of the response
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Total records
    /// </summary>
    [JsonPropertyName("totalResults")]
    public int? TotalResults { get; set; }

    /// <summary>
    /// List of Articles
    /// </summary>
    [JsonPropertyName("articles")]
    public List<Article>? Articles { get; set; }
}