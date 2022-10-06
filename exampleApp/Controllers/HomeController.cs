using Microsoft.AspNetCore.Mvc;
using ConfigCat.Client;


namespace exampleApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var client = new ConfigCatClient("YOUR-SDK-KEY");

            var mailingListEnabled = client.GetValue("mailingListEnabled", false);

            Console.WriteLine("mailingListEnabled's value from ConfigCat: " + mailingListEnabled);


            if (mailingListEnabled == true)
            {
 
                ViewBag.display = "display:inline-block";
            }
            else if (mailingListEnabled == false)
            {
                ViewBag.display = "display:none";

            }
          
            return View("Index");
        }
    }
}