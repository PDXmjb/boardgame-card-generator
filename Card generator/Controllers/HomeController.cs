using Card_generator.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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

                if (values.Length != 38)
                {
                    throw new InvalidDataException("Invalid number of values passed. Corrupt data stream. " + values.Length + " values passed.");
                }

                // Logic to be moved into its own factory.
                var model = new CardViewModel(values[0], values[1],
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
            }
            reader.Close();

            var m_Bitmap = new Bitmap(285, 400);
            PointF point = new PointF(0, 0);
            SizeF maxSize = new SizeF(285, 400);
            var html = RenderRazorViewToString("Index", list.First());

            TheArtOfDev.HtmlRenderer.WinForms.HtmlRender.Render(Graphics.FromImage(m_Bitmap), html,point, maxSize);

            m_Bitmap.Save(@"C:\Users\Mike Brooks\Downloads\Test.png", ImageFormat.Png);

            return View(list.First());
        }

        public string RenderRazorViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext,
                                                                         viewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View,
                                             ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
                return sw.GetStringBuilder().ToString();
            }
        }
    }   
}