
namespace Stock_Trading_App.Data.Models;



public class MarketData
{
   
public string? market_type  {get;set;}	
public string? Counrty	{get;set;}	
public string? primary_exchanges	 {get;set;}	
public DateTime local_open	{get;set;}	
public DateTime local_close	{get;set;}	
public string? current_status	{get;set;}	
public string? notes	{get;set;}	
    
}

public class MarketShareModel
{
public string? api_Message { get; set; }

public IEnumerable<IEnumerable<MarketData>>?  listOfMarketData{get;set;}
}