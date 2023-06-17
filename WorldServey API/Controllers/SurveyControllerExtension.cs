
using Microsoft.AspNetCore.Mvc;
using WorldServey.Service;

namespace WorldServey.Controllers;

public partial class SurveyController : ControllerBase
{

      [HttpGet("City/Population/{CityName}")]
    public async Task<IActionResult> GetCityPopulation(string CityName){

         try
        {

            var Cities = await _countrySurvey!.GetCityPopulation(CityName);

            return Ok(Cities);
        }
        catch (Exception Exception)
        {

            _logger!.LogError(Exception, "Error Received At GetCityPopulation() on {Time}", DateTime.UtcNow);
            return NotFound();

        }
    }

      [HttpGet("City/Country/{CountryCode}")]

     public async Task<IActionResult> GetCountriesCity(string CountryCode){

         try
        {

            var Cities = await _countrySurvey!.GetCountryCity(CountryCode);

            return Ok(Cities);
        }
        catch (Exception Exception)
        {

            _logger!.LogError(Exception, "Error GetCountriesCity()  at on {Time}", DateTime.UtcNow);
            return NotFound();

        }
    }

      [HttpGet("City/{Limit}")]
    public async Task<IActionResult> GetAllCity(int Limit){
          try
        {

            var Cities = await _countrySurvey!.GetAllCity(Limit);

            return Ok(Cities);
        }
        catch (Exception Exception)
        {

            _logger!.LogError(Exception, "Error GetCountriesCity()  at on {Time}", DateTime.UtcNow);
            return NotFound();

        }
    }
}