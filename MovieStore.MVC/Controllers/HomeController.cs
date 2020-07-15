using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieStore.MVC.Models;

namespace MovieStore.MVC.Controllers
{
    //any c# can become a mvc controller if it inherits from controller base class microsoft.Aspnetcore.mvc
    // GET http://localhost:2322/home/index
    //routing -- pattern matching technique
    //homecontroller
    //index -- action method 
    public class HomeController : Controller
    {
        // Action method
        //return string 不行需要return view
        //if return type is interface return instance of a class that implement the interface.
        public IActionResult Index()
        {
            //by default MVC will look for same View Name as ation method name
            //it will look inside view folder -->Home(same name as controller)-->index.cshtml(c#+html razor views)

            //1 program.cs -->main method
            //2 startup class
            //3 configureservices
            //4 configure
            //5 homeController
            //6 action method 
            //7 return view

            //middleware a piece of software logic taht will be executed
            // train DC to boston , multiple stops(middleware) 
            //request --> M1 some logic -->m2->next m3 --> response and then goback wards 
            return View();// view return viewResult and viewresult implement IACtion interface
        }
    }
}
