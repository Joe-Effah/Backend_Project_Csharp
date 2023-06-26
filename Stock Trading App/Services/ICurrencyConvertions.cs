
using Stock_Trading_App.Data.Models;

namespace Stock_Trading_App.Services;


interface ICurrencyServices
{
  
 
    public Task<ExchangeRate> ConvertFiatCurrency(string CurrencyFrom,string CurrencyTo);

    public Task<ExchangeRate> ConvertCryptoCurrencyAsync(string CurrencyFrom,string CurrencyTo);

    


}