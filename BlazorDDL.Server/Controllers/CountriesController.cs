using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDDL.Server.DataAccess;
using BlazorDDL.Shared.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorDDL.Server.Controllers
{
    public class CountriesController : Controller
    { 
        DataAccessClass objemployee = new DataAccessClass();

        [HttpGet]
        [Route("api/Countries/GetCountryList")]
        public IEnumerable<Country> GetCountryList()
        {
            return objemployee.GetAllCountries();
        }

        [HttpGet]
        [Route("api/Countries/GetCities/{id}")]
        public IEnumerable<Cities> GetCities(string id)
        {
            return objemployee.GetCityData(id);
        }
    }
}
