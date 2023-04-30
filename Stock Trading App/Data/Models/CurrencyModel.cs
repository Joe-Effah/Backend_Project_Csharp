
namespace Stock_Trading_App.Data.Models;


public class CurrencyModel
{
    public string? currencyFromCode {get; set;}
    public string? currencyFromName  {get; set;}
    public string? currencyToCode  {get; set;}
    public string? currencyToName  {get; set;}
    public int currencyToExchangeRate  {get; set;}
    public DateTime timeCaptured {get; set;}	
    public string? timeZone  {get; set;}

    public string? BidPrice {get; set;}
    public string? AskPrice   {get; set;}
   
}
