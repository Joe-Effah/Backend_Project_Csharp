
using Microsoft.AspNetCore.Mvc;
using WorldServey.Service;

namespace WorldServey.Controllers;

[ApiController]
[Route("[controller]/api")]
public partial class SurveyController : ControllerBase
{

    private readonly ILogger _logger;

    private readonly CountrySurvey? _countrySurvey;

    public SurveyController(ILoggerFactory logger, IConfiguration config)
    {
        _countrySurvey = new CountrySurvey(config);
        _logger = logger.CreateLogger("SurveyLogger");
    }


    [HttpGet("Country/{Limit}")]
    public async Task<IActionResult> GetCountry(int Limit)
    {

        try
        {

            var countries = await _countrySurvey!.GetCountrys(Limit);

            return Ok(countries);
        }
        catch (Exception Exception)
        {

            _logger!.LogError(Exception, "Error  on {Time}", DateTime.UtcNow);
            return NotFound();

        }
    }

    [HttpGet("Country/Continents/{ContinentName}")]

    public async Task<IActionResult> GetContinentCountry(string ContinentName)
    {
        try
        {

            var countries = await _countrySurvey!.GetContinetsCountry(ContinentName);

            return Ok(countries);
        }
        catch (Exception Exception)
        {

            _logger!.LogError(Exception, "Error on {Time}", DateTime.UtcNow);
            return NotFound();

        }
    }



    [HttpGet("TotalCountries")]
    public async Task<IActionResult> GetTotalCountries()
    {
        try
        {

            var countriesTotal = await _countrySurvey!.GetTotalCountry();

            return Ok(countriesTotal);
        }
        catch (Exception Exception)
        {

            _logger!.LogError(Exception, "Error at GetContinentCountry() on {Time}", DateTime.UtcNow);
            return NotFound();

        }
    }


    [HttpGet("FindCountry/{CountryName}")]
    public async Task<IActionResult> GetCountryData(string CountryName)
    {
        try
        {

            var countryData = await _countrySurvey!.SearchCountry(CountryName);

            return Ok(countryData);
        }
        catch (Exception Exception)
        {

            _logger!.LogError(Exception, "Error at GetCountryData() on {Time}", DateTime.UtcNow);
            return NotFound();

        }
    }

    [HttpGet("GetAllCountryCode")]
    public async Task<IActionResult> GetCountryCode()
    {
        try
        {

            var countryData = await _countrySurvey!.SearchCountrysCodeAsync();

            return Ok(countryData);
        }
        catch (Exception Exception)
        {

            _logger!.LogError(Exception, "Error at GetCountryCode() on {Time}", DateTime.UtcNow);
            return NotFound();

        }
    }













}