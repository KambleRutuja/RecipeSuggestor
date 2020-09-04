using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RecipSuggestor.Models;

namespace RecipSuggestor.ViewModel
{
    public class RecipeViewModel
    {
        public IEnumerable<RecipeTab> Recipsss { get; set; }
        public IEnumerable<IngredientTab> Ingresss { get; set; }
        public IEnumerable<RITab> RecIngsss { get; set; }
    }
}