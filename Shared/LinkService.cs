﻿using System.Collections.Generic;

namespace BlazorApp.Shared
{
    public class LinkService
    {
        public List<LinkDefinition> GetLinkDefinitions()
        {
            // Define your link definitions here
            var linkDefinitions = new List<LinkDefinition>
        {
            new LinkDefinition
            {
                Slug = "handbag",
                DefaultUrl = "https://shope.ee/2VOqbwvDIv",
                PageTitle = "Teelab Crossbody Messenger Bag",
                //RegionSpecificUrls = new List<string>
                //{
                //    "https://www.amazon.co.uk/product-1",
                //    "https://www.amazon.de/product-1"
                //}
            },
             new LinkDefinition
            {
                Slug = "keyboard1",
                DefaultUrl = "https://shope.ee/5KjJHeb0Ms",
                PageTitle = "Bàn phím cơ mạch xuôi JAMESDONKEY A3 ",
                //RegionSpecificUrls = new List<string>
                //{
                //    "https://www.amazon.co.uk/product-1",
                //    "https://www.amazon.de/product-1"
                //}
            }
        };

            return linkDefinitions;
        }
    }
}
