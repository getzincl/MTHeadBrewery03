﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTHeadBrewery.Models
{
    public class Beer
    {
        public int ID { get; set; }
        public string BeerName { get; set; }
        public string ABV { get; set; }
        public string BeerDescription { get; set; }
        public DateTime FirstBrewed { get; set; }

        public virtual ICollection<Brewed> Brewing { get; set; }
    }
}