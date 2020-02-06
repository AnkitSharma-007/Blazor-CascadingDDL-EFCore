using BlazorDDL.Server.Interface;
using BlazorDDL.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorDDL.Server.DataAccess
{
    public class DataAccessLayer : IDDLData
    {
        private myTestDBContext db;

        public DataAccessLayer(myTestDBContext _db)
        {
            db = _db;
        }
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
