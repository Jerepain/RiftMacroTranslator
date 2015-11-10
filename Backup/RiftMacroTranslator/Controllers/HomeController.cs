using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;


namespace RiftMacroTranslator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {                     
            return View();
        }

        public ActionResult HandleForm(string macro, string language)
       { 
            return View("Index");
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your app description page.";

        //    return View();
        //}


        public ActionResult Annuaire()
        {
            return View();
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        public string Translate(string textBox1, string language)
        {
            CultureInfo c = new CultureInfo(language);
            
            Resources.Strings.ResourceManager.IgnoreCase = true;
            var keyWords = new List<string>() { "cast", "[shift]", "suppressmacrofailures", "#show", "@focus", "[maj]", "@gtae" };
            for (int i=1; i < 10 ; i++)
            {
                string group = "@group0";
                keyWords.Add(group + i.ToString());
            }
            for (int i = 10; i < 50; i++)
            {
                string group = "@group";
                keyWords.Add(group + i.ToString());
            }

            HttpContext.Session["culture"] = "fr-FR";
            string result = "";
            var input = textBox1.Split('\n');

            foreach (var i in input)
            {
                string toTranslate = "";
                string toKeep = "";
                string[] line = i.Split(' ');
                foreach (var word in line)
                {
                    var newWord = word.Replace('\r', ' ').Trim();
                    if (!keyWords.Exists(kw => kw == newWord))
                    {
                        toTranslate += newWord;
                    }
                    else
                    {
                        toKeep += newWord + " ";
                    }
                }
                var translated = Resources.Strings.ResourceManager.GetString(toTranslate,c);

                if (translated == null)
                {
                    translated = toTranslate;
                }
                result += toKeep + translated + "\n";
            }          

            return result;
        } 
    }
}
