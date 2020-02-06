using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDDL.Server.DataAccess;
using BlazorDDL.Server.Interface;
using BlazorDDL.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDDL.Server.Controllers
{
    [Route("api/[controller]")]
    public class CountriesController : Controller
    {
        private readonly IDDLData objCountry;

        public CountriesController(IDDLData _objCountry)
        {
            objCountry = _objCountry;
        }

        [HttpGet]
        [Route("GetCountryList")]
        public IEnumerable<Country> GetCountryList()
        {
            return objCountry.GetAllCountries();
        }
        [HttpGet]
        [Route("GetCities/{id}")]
        public IEnumerable<Cities> GetCities(string id)
        {
            return objCountry.GetCityData(id);
        }
    }
}
