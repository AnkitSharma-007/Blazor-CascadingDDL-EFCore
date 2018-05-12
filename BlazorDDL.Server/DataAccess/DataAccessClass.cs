using BlazorDDL.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDDL.Server.DataAccess
{
    public class DataAccessClass
    {
        myTestDBContext db = new myTestDBContext();

        public IEnumerable<Country> GetAllCountries()
        {
            try
            {
                return db.Country.ToList();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Cities> GetCityData(string id)
        {
            try
            {
                List<Cities> lstCity = new List<Cities>();
                lstCity = (from CityName in db.Cities where CityName.CountryId == id select CityName).ToList();

                return lstCity;
            }
            catch
            {
                throw;
            }
        }
    }
}
