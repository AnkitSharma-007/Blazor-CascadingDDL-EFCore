using BlazorDDL.Shared.Models;
using System.Collections.Generic;

namespace BlazorDDL.Server.Interface
{
    public interface IDDLData
    {
        public IEnumerable<Country> GetAllCountries();
        public IEnumerable<Cities> GetCityData(string id);
    }
}
