using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeTask.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        string url = "../../";

        public void SumaCifr(int number)
        {
            if(number > 9)
            {
                string Strnumber = "" + number;
                int suma = 0;
                foreach (char item in Strnumber)
                {
                    suma+=Convert.ToInt32(item)-48;
                }
                Response.Write(suma + $" <a href ={url}> Вернитель назад </a>");
            }
            else
            {
                Response.Write($" Вы ввели малелькое значение! <a href={url}>Вернитель назад</a>");
            }
        }

        public void Fibbonachi(int Max)
        {
            try
            {
                if (Max > 0 && Max < 100)
                {
                    ViewBag.L1 = 0;
                    ViewBag.max = Max;
                    Fibbonachi(0, 1);
                    return;
                }
            }
            catch (Exception)
            {
            }
            Response.Write($"Вы ввели неверное значение <a href ={url}> Вернитель назад </a>");
        }

        private void Fibbonachi(long F,long S)
        {
            Response.Write(S + " \n");
            ViewBag.L1++;
            if (ViewBag.L1 == ViewBag.max)
            {
                Response.Write($"<hr><a href ={url}> Вернитель назад </a>");
                return;
            }
            Fibbonachi(S, S + F);
        }
    }
}