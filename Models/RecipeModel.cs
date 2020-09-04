using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipSuggestor.Models
{
    public class RecipeModel
    {
        public IEnumerable<RecipeTab> r { get; set; }
        public IEnumerable<RecipeTab> i { get; set; }
        public IEnumerable<RecipeTab> ri { get; set; }
    }
}