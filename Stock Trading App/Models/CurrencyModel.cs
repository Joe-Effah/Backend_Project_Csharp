
using System.Text.Json.Serialization;

namespace Stock_Trading_App.Data.Models;


public class CurrencyModel
{
    [JsonPropertyName("1. From_Currency Code")]
    public string? currencyFromCode {get; set;}

     [JsonPropertyName("2. From_Currency Name")]
    public string? currencyFromName  {get; set;}
     [JsonPropertyName("3. To_Currency Code")]
    public string? currencyToCode  {get; set;}
     [JsonPropertyName("4. To_Currency Name")]
    public string? currencyToName  {get; set;}

     [JsonPropertyName("5. Exchange Rate")]
    public string? currencyToExchangeRate  {get; set;}

     [JsonPropertyName("6. Last Refreshed")]
    public string? timeCaptured {get; set;}

     [JsonPropertyName("7. Time Zone")]
    public string? timeZone  {get; set;}

     [JsonPropertyName("8. Bid Price")]
    public string? BidPrice {get; set;}
    
     [JsonPropertyName("9. Ask Price")]
    public string? AskPrice   {get; set;}
   
}

public class ExchangeRate
{
    [JsonPropertyName("Realtime Currency Exchange Rate")]
    public CurrencyModel? CurrentRate {get; set;}
}
