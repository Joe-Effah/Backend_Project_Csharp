
using Stock_Trading_App.Data.Models;

namespace Stock_Trading_App.Services;


interface ICurrencyServices
{
  
 
    public CurrencyModel ConvertForexCurrency(string CurrencyFrom,string CurrencyTo);

    public CurrencyModel ConvertCryptoCurrency(string CurrencyFrom,string CurrencyTo);

    


}