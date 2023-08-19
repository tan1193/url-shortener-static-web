using System;
using System.Collections.Generic;

namespace BlazorApp.Shared
{
    public class LinkDefinition
    {
        public string Slug { get; set; }
        public string DefaultUrl { get; set; }
        public List<string> RegionSpecificUrls { get; set; }
    }

}
