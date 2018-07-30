using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoCYQ
{
    public class CategoryDescriptionInfo
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string SmallImg { get; set; }
        public string MiddleImg { get; set; }
        public string BigImg { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public string Description { get; set; }
    }
}