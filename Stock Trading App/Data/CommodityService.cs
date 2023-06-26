
using System.Text;
using Stock_Trading_App.Data.Models;
using Stock_Trading_App.Services;

namespace Stock_Trading_App.Data;

class CommodityService : IComodityService
{
    private readonly HttpClient _HttpClient;

    private StringBuilder? Query;

    private string? API_KEY { get; set; }



    public CommodityService(HttpClient httpClient,IConfiguration config){
            _HttpClient = httpClient;

       API_KEY =  config.GetSection("ALPHA_VANTAGE_API_KEY").GetValue<string>("KEY");

    }

    public async Task<ComoditiyModel> GetComodity(string ComodityName)
    {
          Query = new StringBuilder($"https://www.alphavantage.co/query?function={ComodityName}&interval=monthly&apikey={API_KEY}");

        try
        {
         var Results =  await _HttpClient.GetFromJsonAsync<ComoditiyModel>(Query.ToString());
            
            return Results!;
        }
        catch (System.Exception)
        {
            
            throw;
        }

    }
}

 