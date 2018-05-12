using System;
using System.Collections.Generic;

namespace BlazorDDL.Shared.Models
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<Cities>();
        }

        public string CountryId { get; set; }
        public string CountryName { get; set; }

        public ICollection<Cities> Cities { get; set; }
    }
}
