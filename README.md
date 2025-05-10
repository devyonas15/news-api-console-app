# News API Console App

## Purpose
To interact with News API's everything Endpoint to get news according to subset of parameters, i.e. https://newsapi.org/v2/everything?q=tesla&from=2025-04-10&sortBy=publishedAt&apikey=[YOUR_API_KEY]

## Command to run
```
dotnet run app [json_params] [number_of_news_to_get]
```

## Tech Stack and Libraries
- .NET 8
- **HttpClient** for making HTTP call
- **XUnit** and **Moq** for mocking unit tests

## Remaining Scope
- **[minor]** Unit test for the service layer, after the abstraction of HttpClient has been done.


