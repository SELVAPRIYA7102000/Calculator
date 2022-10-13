using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.Models;
namespace Calculator.Controllers
{
    public class Calc1Controller : Controller
    {
        // GET: Calc1
        public ActionResult Index()
        {
            return View(new Calc());
        }

        [HttpPost]
        public ActionResult Index(Calc c)
        {
            c.Result = 0;
            switch(c.Op)
            {
               
                case '+':
                    c.Result = c.num1 + c.num2;
                    break;
                case '-':
                    c.Result = c.num1 - c.num2;
                    break;
                case '*':
                    c.Result = c.num1 * c.num2;
                    break;
                case '/':
                    c.Result = c.num1 / c.num2;
                    break;
                case 'C':
                    c.Result = 0;
                    break;
            }
            c.num2 = c.Result;
            c.num1 = 0;
            return View(c);
        }
    }
}