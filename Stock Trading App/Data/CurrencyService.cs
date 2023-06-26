
using System.Text;
using Stock_Trading_App.Data.Models;
using Stock_Trading_App.Services;
using Newtonsoft.Json;

namespace Stock_Trading_App.Data;


class CurrencyService : ICurrencyServices
{
    private readonly HttpClient _HttpClient;
    private StringBuilder? Query;

    private string? API_KEY { get; set; }



    public CurrencyService(HttpClient client,IConfiguration config){
        _HttpClient = client;
       API_KEY =  config.GetSection("ALPHA_VANTAGE_API_KEY").GetValue<string>("KEY");
    }



    public async Task<ExchangeRate> ConvertCryptoCurrencyAsync(string CurrencyFrom, string CurrencyTo)
    {
        Query = new StringBuilder($"https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency={CurrencyFrom}&to_currency={CurrencyTo}&apikey={API_KEY}");

        try
        {
         var Results =  await _HttpClient.GetFromJsonAsync<ExchangeRate>(Query.ToString());
            
            return Results!;
        }
        catch (System.Exception)
        {
            
            throw;
        }


    }


    public async Task<ExchangeRate> ConvertFiatCurrency(string CurrencyFrom, string CurrencyTo)
    {
        Query = new StringBuilder($"https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency={CurrencyFrom}&to_currency={CurrencyTo}&apikey={API_KEY}");

        try
        {
         var Results =  await _HttpClient.GetFromJsonAsync<ExchangeRate>(Query.ToString());
            
            return Results!;
        }
        catch (System.Exception)
        {
            
            throw;
        }

    }
}

