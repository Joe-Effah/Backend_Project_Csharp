
using Stock_Trading_App.Data.Models;
using Stock_Trading_App.Services;

namespace Stock_Trading_App.Data;


class TradingService : ITradingServices
{
     public CurrencyModel ConvertForexCurrency(string CurrencyFrom,string CurrencyTo)
     {
        return new CurrencyModel {currencyFromCode = "james Boond"};
     }

    public CurrencyModel ConvertCryptoCurrency(string CurrencyFrom,string CurrencyTo)
    {

        return new CurrencyModel {currencyFromCode = "james Boond"};

    }

    public  Task<string> TestMethod()
    {
        return Task.Run<string>(()=>"kofi is A Good Boy");
    }

    public ComoditiyModel GetComoditiesSugar()
    {
        throw new NotImplementedException();
    }

    public ComoditiyModel GetComoditiesCrudeOil_WTI()
    {
        throw new NotImplementedException();
    }

    public ComoditiyModel GetComoditiesCrudeOil_BRENT()
    {
        throw new NotImplementedException();
    }

    public ComoditiyModel GetComoditiesCopper()
    {
        throw new NotImplementedException();
    }

    public ComoditiyModel GetComoditiesCoffee()
    {
        throw new NotImplementedException();
    }

 
}
 