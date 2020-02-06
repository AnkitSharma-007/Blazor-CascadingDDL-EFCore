using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDDL.Shared.Models
{
    public partial class Cities
    {
        public string CityId { get; set; }
        public string CountryId { get; set; }
        public string CityName { get; set; }

        public Country Country { get; set; }
    }
}
