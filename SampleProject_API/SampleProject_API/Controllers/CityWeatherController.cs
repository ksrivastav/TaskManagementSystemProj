using ApplicationLayer.ServicesContracts;
using Microsoft.AspNetCore.Mvc;
using SampleAPI_Core.Entities;

namespace SampleProject_API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CityWeatherController : Controller
    {
        ICitySerivce<City> citySerivce;
        IWeatherService<Weather> weatherService;
        public CityWeatherController(ICitySerivce<City> _citySerivce, IWeatherService<Weather> _weatherService)
        {
            this.citySerivce= _citySerivce;

            this.weatherService = _weatherService;


        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //get
        // /cities
        // /cities/{id}


        [HttpGet(Name = "CityWeather")]
        public async Task<IActionResult> CityWeather()
        {
            var result = await this.weatherService.getAllWeather();
            return Ok(result);

        }

        [HttpGet(Name = "Cities")]
        public async Task<IActionResult>Cities()
        {
            var result = await this.citySerivce.getAllCity();

            return Ok(result);

        }




    }
}
