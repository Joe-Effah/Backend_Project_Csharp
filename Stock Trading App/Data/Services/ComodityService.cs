using Stock_Trading_App.Data.Models;
namespace Stock_Trading_App.Services;

interface IComodityService
{
    public ComoditiyModel GetComoditiesSugar();

    public ComoditiyModel GetComoditiesCrudeOil_WTI();

    public ComoditiyModel GetComoditiesCrudeOil_BRENT();

    public ComoditiyModel GetComoditiesCopper();

    public ComoditiyModel GetComoditiesCoffee();
}

