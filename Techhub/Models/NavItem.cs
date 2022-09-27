using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;

namespace Techhub.Models
{
    public class NavItem
    {
        public Item Item { get; set; }
        public string Url { get; set; }
    }
}