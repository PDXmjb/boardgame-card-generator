using Card_generator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace Card_generator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // TODO: Convert to user-linked database.
            var reader = new StreamReader(System.IO.File.OpenRead(@"C:\Users\Mike Brooks\Dropbox\Card generator 2\game.csv"));
            var list = new List<CardViewModel>();
            Random rand = new Random();
            int idIterator = 1;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                if (values.Length != 38)
                {
                    throw new InvalidDataException("Invalid number of values passed. Corrupt data stream. " + values.Length + " values passed.");
                }

                // Logic to be moved into its own factory.
                var model = new CardViewModel(idIterator, values[0], values[1],
                    new CardLabel(values[2], values[3], values[4], values[5]),
                    new CardLabel(values[6], values[7], values[8], values[9]),
                    new CardLabel(values[10], values[11], values[12], values[13]),
                    new CardLabel(values[14], values[15], values[16], values[17]),
                    new CardLabel(values[18], values[19], values[20], values[21]),
                    new CardLabel(values[22], values[23], values[24], values[25]),
                    new CardLabel(values[26], values[27], values[28], values[29]),
                    new CardLabel(values[30], values[31], values[32], values[33]),
                    new CardLabel(values[34], values[35], values[36], values[37]));
                
                list.Add(model);
                idIterator++;
            }
            reader.Close();
            
            return View(list);
        }        
    }   
}