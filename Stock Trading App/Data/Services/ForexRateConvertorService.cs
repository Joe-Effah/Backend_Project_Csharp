
using Stock_Trading_App.Data.Models;

namespace Stock_Trading_App.Services;


interface ITradingServices
{
  public  Task<string> TestMethod();
    public CurrencyModel ConvertForexCurrency(string CurrencyFrom,string CurrencyTo);

    public CurrencyModel ConvertCryptoCurrency(string CurrencyFrom,string CurrencyTo);

    public ComoditiyModel GetComoditiesSugar();

    public ComoditiyModel GetComoditiesCrudeOil_WTI();

    public ComoditiyModel GetComoditiesCrudeOil_BRENT();

    public ComoditiyModel GetComoditiesCopper();

    public ComoditiyModel GetComoditiesCoffee();


}