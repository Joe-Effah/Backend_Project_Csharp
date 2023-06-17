

using Dapper;
using MySql.Data.MySqlClient;
using WorldServey.Models;

namespace WorldServey.Service;

public partial class CountrySurvey : ICountrySurvey
{

    private readonly MySqlConnection? _dbConnection;

    public CountrySurvey(IConfiguration config)
    {
        _dbConnection = new MySqlConnection(config.GetConnectionString("WorldDB"));
        
    }

    public async Task<IEnumerable<CountryModel>> GetContinetsCountry(string ContinentsName)
    {
        try
        {
            await _dbConnection!.OpenAsync();

            var Result = await _dbConnection.QueryAsync<CountryModel>
           ("SELECT * FROM COUNTRY  WHERE Country.Continent = @ContinentName;",
           new { ContinentName = ContinentsName });

            await _dbConnection!.CloseAsync();

            return (IEnumerable<CountryModel>)Result;


        }
        catch (System.Exception)
        {

            throw;
        }



    }

    public async Task<IEnumerable<CountryModel>> GetCountrys(int limit = 50)
    {
        try
        {
            await _dbConnection!.OpenAsync();

            var Results = await _dbConnection.QueryAsync<CountryModel>
             ("SELECT * FROM COUNTRY  LIMIT @Limit", new { Limit = limit });

            await _dbConnection!.CloseAsync();

            return (IEnumerable<CountryModel>)Results;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<IEnumerable<int>> GetTotalCountry()
    {
        

     try
        {
            await _dbConnection!.OpenAsync();

            var Results = await _dbConnection.QueryAsync<int>
             ("SELECT COUNT(NAME) FROM country;");

            await _dbConnection!.CloseAsync();

            return Results;
        }
        catch (Exception)
        {
            throw;
        }
       
    }

    public async Task<IEnumerable<CountryModel>> SearchCountry(string CountryName)
    {
         try
        {
            await _dbConnection!.OpenAsync();

            var Results = await _dbConnection.QueryAsync<CountryModel>
             ("SELECT  * FROM country  WHERE country.Name=@CName",new{CName = CountryName});

            await _dbConnection!.CloseAsync();

            return (IEnumerable<CountryModel>)Results;
        }
        catch (Exception)
        {
            throw;
        }

       
    }

    public async Task<IEnumerable<dynamic>> SearchCountrysCodeAsync()
    {
         try
        {
            await _dbConnection!.OpenAsync();

            var Results = await _dbConnection.QueryAsync("SELECT Code,Name,Continent,Population FROM country");

            await _dbConnection!.CloseAsync();

            return Results;
        }
        catch (Exception)
        {
            throw;
        }
       
    }

}