using Stock_Trading_App.Data.Models;
namespace Stock_Trading_App.Services;

interface IComodityService
{
    public Task<ComoditiyModel> GetComodity(string ComodityName);
}

