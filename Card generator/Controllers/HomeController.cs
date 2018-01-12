using Card_generator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace Card_generator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var reader = new StreamReader(System.IO.File.OpenRead(@"C:\Users\Mike Brooks\Dropbox\Card generator 2\game.csv"));
            var list = new List<CardViewModel>();
            Random rand = new Random();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                var model = new CardViewModel();

                model.Name = values[0];
                model.Special = values[1];
                model.Value = Int32.Parse(values[2]);

                model.WallConfig = rand.Next(1, 13);
                switch (values[3])
                {
                    case "Survivor":
                        model.Type = CardType.Survivor;
                        break;
                    case "Utility":
                        model.Type = CardType.Utility;
                        break;
                    case "Food":
                        model.Type = CardType.Food;
                        break;
                    case "Military":
                        model.Type = CardType.Military;
                        break;
                }
                list.Add(model);
            }

            return View(list.First());
        }
    }
}