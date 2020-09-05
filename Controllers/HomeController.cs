using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Web;
using System.Web.Mvc;
using RecipSuggestor.Models;
using RecipSuggestor.ViewModel;

namespace RecipSuggestor.Controllers
{    
    public class HomeController : Controller
    {
 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ShowIng()
        {
            List<IngClass> ls = new List<IngClass>()
            {
                new IngClass{ id="1",name=" Butter ",type="Dairy",isChecked=false },
                new IngClass{ id="2",name=" Egg ",type="Dairy",isChecked=false },
                new IngClass{ id="3",name=" Milk ",type="Dairy",isChecked=false },
                new IngClass{ id="4",name=" Paneer ",type="Dairy",isChecked=false },
                new IngClass{ id="6",name=" Curd ",type="Dairy",isChecked=false },
                new IngClass{ id="5",name=" Parmesan ",type="Dairy",isChecked=false },
                new IngClass{ id="11",name=" Onion ",type="Vegetables",isChecked=false },
                new IngClass{ id="12",name=" Tomato ",type="Vegetables",isChecked=false },
                new IngClass{ id="13",name=" Potato ",type="Vegetables",isChecked=false },
                new IngClass{ id="14",name=" Bell Pepper ",type="Vegetables",isChecked=false },
                new IngClass{ id="15",name=" Spinach ",type="Vegetables",isChecked=false },
                new IngClass{ id="16",name=" Cucumber ",type="Vegetables",isChecked=false },
                new IngClass{ id="17",name=" Cauliflower ",type="Vegetables",isChecked=false },
                new IngClass{ id="18",name=" Cabage ",type="Vegetables",isChecked=false },
                new IngClass{ id="19",name=" Carrot ",type="Vegetables",isChecked=false },
                new IngClass{ id="31",name=" Rice ",type="Grains",isChecked=false },
                new IngClass{ id="32",name=" Pasta ",type="Grains",isChecked=false },
                new IngClass{ id="33",name=" Flour ",type="Grains",isChecked=false },
                new IngClass{ id="34",name=" Bread ",type="Grains",isChecked=false },
                new IngClass{ id="35",name=" Noodles ",type="Grains",isChecked=false },
                new IngClass{ id="38",name=" Gram Flour ",type="Grains",isChecked=false },
                new IngClass{ id="37",name=" Pizza Dough ",type="Grains",isChecked=false },
                new IngClass{ id="36",name=" Corn Starch ",type="Grains",isChecked=false },
                new IngClass{ id="41",name=" Chicken Breast ",type="Meats",isChecked=false },
                new IngClass{ id="42",name=" Chicken leg ",type="Meats",isChecked=false },
                new IngClass{ id="43",name=" Whole Chicken ",type="Meats",isChecked=false },
                new IngClass{ id="44",name=" Lamb ",type="Meats",isChecked=false },
                new IngClass{ id="45",name=" lamb liver ",type="Meats",isChecked=false },
                new IngClass{ id="51",name=" Crab ",type="Seafood",isChecked=false },
                new IngClass{ id="52",name=" Prawns ",type="Seafood",isChecked=false },
                new IngClass{ id="53",name=" Lobster ",type="Seafood",isChecked=false },
                new IngClass{ id="54",name=" Pomfret ",type="Seafood",isChecked=false },
                new IngClass{ id="55",name=" King Fish ",type="Seafood",isChecked=false },
                new IngClass{ id="56",name=" Bangda ",type="Seafood",isChecked=false },
                new IngClass{ id="61",name=" Green Beans ",type="Legumes",isChecked=false },
                new IngClass{ id="62",name=" Peas ",type="Legumes",isChecked=false },
                new IngClass{ id="63",name=" Black Beans ",type="Legumes",isChecked=false },
                new IngClass{ id="64",name=" Chickpea ",type="Legumes",isChecked=false },
                new IngClass{ id="65",name=" Kidney beans ",type="Legumes",isChecked=false },
                new IngClass{ id="66",name=" Moog Daal ",type="Legumes",isChecked=false },
                new IngClass{ id="71",name=" Chili powder ",type="Spices",isChecked=false },
                new IngClass{ id="72",name=" Coriander ",type="Spices",isChecked=false },
                new IngClass{ id="73",name=" Clove ",type="Spices",isChecked=false },
                new IngClass{ id="74",name=" Turmeric ",type="Spices",isChecked=false },
                new IngClass{ id="75",name=" Cumin ",type="Spices",isChecked=false },
                new IngClass{ id="76",name=" Ginger Garlic Paste ",type="Spices",isChecked=false },
            };
            IngList list = new IngList();
            list.IngrList = ls;

            return View(list);
        }

        [HttpPost]
        public ActionResult ShowIng(IngList il)
        {
            StringBuilder sb = new StringBuilder();
            List<int> sb1 = new List<int>();

            foreach (var item in il.IngrList)
            {
                if (item.isChecked)
                {
                    sb.Append(item.id + ",");
                    sb1.Add(Int32.Parse(item.id));
                }
            }
                        
            ViewBag.selectIngr = sb.ToString();
            
            if(sb1 != null)
            {
                Session["Key"] = sb1;
                return RedirectToAction("Index", "DB");
            }

            return View();
        }

        
    }
}