
using WorldServey.Models;

namespace WorldServey.Service;

interface ICountrySurvey
{
   public Task<IEnumerable<int>> GetTotalCountry();
   public Task<IEnumerable<CountryModel>> SearchCountry(string CountryName);
   public Task<IEnumerable<dynamic>> SearchCountrysCodeAsync();
   public  Task<IEnumerable<CountryModel>> GetCountrys(int limit = 50);
   public  Task<IEnumerable<CountryModel>> GetContinetsCountry(string ContinentsName);

}