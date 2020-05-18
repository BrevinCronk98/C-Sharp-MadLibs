using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Form() {return View(); }


        [Route("/madlib")]
        public ActionResult MadLib(string nounOne, string nounTwo, string nounThree, string verbOne, string verbTwo, string verbThree, string adjOne, string adjTwo, string adjThree, string adverbOne, string adverbTwo, string adverbThree )
        {
            MadLibs myMadLibs = new MadLibs();
            myMadLibs.NounOne = nounOne;
            myMadLibs.NounTwo = nounTwo;
            myMadLibs.NounThree = nounThree;

            myMadLibs.VerbOne = verbOne;
            myMadLibs.VerbTwo = verbTwo;
            myMadLibs.VerbThree = verbThree;

            myMadLibs.AdjOne = adjOne;
            myMadLibs.AdjTwo = adjTwo;
            myMadLibs.AdjThree = adjThree;

            myMadLibs.AdverbOne = adverbOne;
            myMadLibs.AdverbTwo = adverbTwo;
            myMadLibs.AdverbThree= adverbThree;
            return View(myMadLibs);


            
        }
    }

    
}