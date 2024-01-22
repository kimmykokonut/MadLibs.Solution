using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Home() { return View(); }

        [Route("/efform")]
        public ActionResult EFForm() { return View(); }

        [Route("/iceform")]
        public ActionResult IceForm() { return View(); }

        [Route("/efstory")]
        public ActionResult EFStory(string properNoun, string adj, string color, string animal, string place, string adj1, string mc, string adj2, string mc2, string room, string noun, string noun1, string noun2, string adj3, string nounP, string num, string time, string verb, string adj4, string noun3) //route for form data to go to...
        {
            BlankVariable myBlankVariable = new BlankVariable();

            myBlankVariable.ProperNoun = properNoun;
            myBlankVariable.Adj = adj;
            myBlankVariable.Color = color;
            myBlankVariable.Animal = animal;
            myBlankVariable.Place = place;
            myBlankVariable.Adj1 = adj1;
            myBlankVariable.Mc = mc;
            myBlankVariable.Adj2 = adj2;
            myBlankVariable.Mc2 = mc2;
            myBlankVariable.Room = room;
            myBlankVariable.Noun = noun;
            myBlankVariable.Noun1 = noun1;
            myBlankVariable.Noun2 = noun2;
            myBlankVariable.Adj3 = adj3;
            myBlankVariable.NounP = nounP;
            myBlankVariable.Num = num;
            myBlankVariable.Time = time;
            myBlankVariable.Verb = verb;
            myBlankVariable.Adj4 = adj4;
            myBlankVariable.Noun3 = noun3;

            return View(myBlankVariable);
        }
        [Route("/icestory")]
        public ActionResult IceStory(string one, string two, string three, string four, string five, string six, string seven, string eight, string nine, string ten, string eleven, string twelve, string thirteen, string fourteen, string fifteen)
        {
            IceVariable myIceVariable = new IceVariable();
            myIceVariable.One = one;
            myIceVariable.Two = two;
            myIceVariable.Three = three;
            myIceVariable.Four = four;
            myIceVariable.Five = five;
            myIceVariable.Six = six;
            myIceVariable.Seven = seven;
            myIceVariable.Eight = eight;
            myIceVariable.Nine = nine;
            myIceVariable.Ten = ten;
            myIceVariable.Eleven = eleven;
            myIceVariable.Twelve = twelve;
            myIceVariable.Thirteen = thirteen;
            myIceVariable.Fourteen = fourteen;
            myIceVariable.Fifteen = fifteen;
            return View(myIceVariable);
        }
    }
}