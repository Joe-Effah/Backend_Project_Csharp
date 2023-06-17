

using Dapper;
using MySql.Data.MySqlClient;
using WorldServey.Models;

namespace WorldServey.Service;

public partial class CountrySurvey : ICitySurvey
{

    public async Task<IEnumerable<CityModel>> GetCityPopulation(string CityName)
    {
         try
        {
            await _dbConnection!.OpenAsync();

            var Result = await _dbConnection.QueryAsync<CityModel>
           ("SELECT * FROM City  WHERE City.Name = @CityName;",
           new { CityName = CityName });

            await _dbConnection!.CloseAsync();

            return Result;


        }
        catch (System.Exception)
        {

            throw;
        }
       
    }

    public async Task<IEnumerable<CityModel>> GetCountryCity(string CountryCode)
    {
         try
        {
            await _dbConnection!.OpenAsync();

            var Result = await _dbConnection.QueryAsync<CityModel>
           ("SELECT * FROM City  WHERE City.CountryCode = @CCode;",
           new { CCode = CountryCode });

            await _dbConnection!.CloseAsync();

            return Result;


        }
        catch (System.Exception)
        {

            throw;
        }
       
    }

    public async Task<IEnumerable<CityModel>> GetAllCity(int limit = 60)
    {
          try
        {
            await _dbConnection!.OpenAsync();

            var Result = await _dbConnection.QueryAsync<CityModel>
           ("SELECT * FROM City  LIMIT @Total;",
           new { Total = limit });

            await _dbConnection!.CloseAsync();

            return Result;


        }
        catch (System.Exception)
        {

            throw;
        }
    }

}