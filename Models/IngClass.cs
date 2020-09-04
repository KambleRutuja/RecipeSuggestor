using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipSuggestor.Models
{
    public class IngClass
    {
        public String id { get; set; }
        public String name { get; set; }
        public String type { get; set; }
        public bool isChecked { get; set; }
    }

    public class IngList
    { 
    public List<IngClass> IngrList { get; set; }
    }
}