using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;

namespace Techhub.Models
{
    public class Listing
    {
        public Item ParentItem { get; set; } 
        public IEnumerable<NavItem> Posts { get; set; } = Enumerable.Empty<NavItem>();
    }
}