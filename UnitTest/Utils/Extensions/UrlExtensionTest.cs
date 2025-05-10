using api_call_example.DTOs;
using api_call_example.Utils.Extensions;

namespace UnitTest.Utils.Extensions;

public sealed class UrlExtensionTest
{
    [Fact]
    public void GivenQuery_ToQueryParams_ShouldReturnCorrectQueryParams()
    {
        var query = new GetAllNewsByParamsQuery
        {
            Q = "test",
            SortBy = "terms",
            ApiKey = "apikey"
        };

        const string expectedResponse = "?q=test&sortby=terms&apikey=apikey";
        var result = query.ToQueryParams();

        Assert.Equal(expectedResponse, result);
    }
}