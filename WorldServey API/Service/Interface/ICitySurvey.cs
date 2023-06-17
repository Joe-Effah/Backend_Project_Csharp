using WorldServey.Models;

namespace WorldServey.Service;


public interface ICitySurvey
{
  public Task<IEnumerable<CityModel>>GetAllCity(int limit = 60);

   public Task<IEnumerable<CityModel>>GetCountryCity(string CountryName);   

   public Task<IEnumerable<CityModel>>GetCityPopulation(string CountryCode);
}