using System.Text.Json;
using api_call_example.DTOs;
using api_call_example.Services;

// Initiate Global HttpClient to avoid socket exhaustion by reusing the same HttpClient for each API call, ideally.
// If HttpClient wants to be isolated and be put inside NewsService only, static singleton pattern should be used.
var httpClient = new HttpClient(); 

try
{
    if (args.Length is < 2 or > 2)
    {
        throw new ArgumentException("Correct arguments must be provided. Example: dotnet run app -- {json_string} {number_of_news}");
    }

    if (!int.TryParse(args[1], out var numberOfNews) || numberOfNews < 0)
    {
        throw new ArgumentException("Second argument must be a valid positive integer");
    }

    var request = JsonSerializer.Deserialize<GetAllNewsByParamsQuery>(args[0]);

    var newsService = new NewsService();
    
    if (request != null)
    {
        var response = await newsService.GetAllNewsByParams(httpClient, request);
        
        Console.WriteLine(response is null ? "[]" : JsonSerializer.Serialize(response.Articles?.OrderByDescending(x => x.PublishedAt).Take(int.Parse(args[1]))));
    }
}
catch(Exception ex)
{
    switch (ex)
    {
        case ArgumentException:
            Console.WriteLine($"{ex.Message}");
            break;
        case JsonException:
            Console.WriteLine($"JSON supplied is not in a valid format, reason: {ex.Message}");
            break;
        case NotSupportedException:
            Console.WriteLine($"JSON Converter method not available, in details: {ex.Message}");
            break;
        case HttpRequestException:
            Console.WriteLine($"Http exception occurs due to: {ex.Message}");
            break;
        default:
            Console.WriteLine($"Unknown exception occurs due to: {ex.Message}");
            break;
    }

    Environment.Exit(1);
}