﻿using System.Collections.Generic;

namespace CommerceClient.Api.Model
{
    public class Country
    {
        public int CountryId { get; set; }
        public string ExtCountryId { get; set; }
        public string Name { get; set; }
        public bool IsDefaultCountry { get; set; }
        public int SortOrder { get; set; }

        // ReSharper disable once InconsistentNaming
        public string Iso3166Alpha3 { get; set; }

        // ReSharper disable once InconsistentNaming
        public string Iso3166Alpha2 { get; set; }
        public List<ResourceLink> Links { get; set; }
    }
}