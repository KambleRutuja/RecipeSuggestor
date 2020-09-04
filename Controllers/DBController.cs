using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RecipSuggestor.Models;
using RecipSuggestor.ViewModel;

namespace RecipSuggestor.Controllers
{
    public class DBController : Controller
    {
        // GET: DB
        public ActionResult Index()
        {
            RecipesDBEntities obj = new RecipesDBEntities();
            var mymodel = new RecipeViewModel();
            mymodel.Recipsss = obj.RecipeTabs.ToList();
            mymodel.Ingresss = obj.IngredientTabs.ToList();
            mymodel.RecIngsss = obj.RITabs.ToList();
            return View(mymodel);
        }
/*        public ActionResult ShowRec()
        {
            RecipesDBEntities obj = new RecipesDBEntities();
            var mymodel = new RecipeViewModel();
            mymodel.Recipsss = obj.RecipeTabs.ToList();
            mymodel.Ingresss = obj.IngredientTabs.ToList();
            mymodel.RecIngsss = obj.RITabs.ToList();
            return View(mymodel);
        }
*/
    }
}