using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.UI.HtmlControls;
using FinalWebSite.Models;
using System.Web.UI.WebControls;
using System.Collections.Specialized;


namespace FinalWebSite.Controllers
{
    public class HomeController : Controller
    {
        public static string msl7a_id, mostand_id;

        private WebsiteDatabaseProjectEntities2 db = new WebsiteDatabaseProjectEntities2();
        

        public static string rq, tm, mn, mm, noc, nam, re, pn, mson;

        public static string ermsg;
        public ActionResult PN()
        {
            return Content(pn);
        }

        public ActionResult MSON()
        {
            return Content(mson);
        }

        public ActionResult RQ()

        {
          
            return Content(rq);

        }   // Rqm Qwmy
        public ActionResult Name()

        {
            return Content(nam);

        }   // Name
        public ActionResult TM()

        {
            return Content(tm);

        }     // tare5 MElad
        public ActionResult MM()

        {
            return Content(mm);

        }      // M7l Melad
        public ActionResult MN()

        {
            return Content(mn);

        }      // Mother Name
        public ActionResult RE()

        {
            return Content(re);

        }             // Relegion
        public ActionResult Requestspage()
        {
            MN();
            TM();
            MM();
            RE();
            
            RQ();
            Name();
            return View();
        }     
        public ActionResult msl7a1_1()
        {
            msl7a_id = "1";
            mostand_id = "1";
            return RedirectToAction("Requestspage");

        }
        public ActionResult msl7a1_2()
        {
            msl7a_id = "1";
            mostand_id = "2";
            return RedirectToAction("Requestspage");
        }
        public ActionResult msl7a2_3()
        {
            msl7a_id = "2";
            mostand_id = "3";
            return RedirectToAction("Requestspage");
        }
        public ActionResult msl7a2_4()
        {
            msl7a_id = "2";
            mostand_id = "4";
            return RedirectToAction("Requestspage");
        }
        public ActionResult Index()
        {
            
            return View(db.Msale7.ToList());       // yro7 el Data Base w yd5ol el Msale7 w ygbha w y7otha f list
            //return View();
        }     
        public ActionResult erromsg()
        {

            return Content(ermsg);
        }          // Msg eli btzhr lw el user d5l password w national id 8alat
        public ActionResult Msal7Page()
        {

            return View(db.Msale7.ToList());

           

            // return View();
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



        // HttpPOST - Submits data to be processed to a specified resource
        [HttpPost]
      public  ActionResult Create()
        {
            nam = Request.Form["name"];                   
            string pass = Request.Form["password"];

            foreach (Citizen element in db.Citizens)
            {
                if ((element.National_ID == nam) && (element.Password == pass))
                {
                    rq = element.National_ID;
                    tm = element.BirthDate.ToShortDateString();
                    mn = element.Mother_Name;
                    mm = element.M7l_elmelad;
                    nam = element.Citizen_Name;
                    re = element.Relegion;
                   

                    return RedirectToAction("Msal7Page");
                    
                }
                else if ((element.National_ID != nam) || (element.Password != pass))
                {
                    

                    ermsg = "الرقم القومى / كلمة السر التي ادخلتها غير صحيحه";
                    erromsg();
                }


            }

            
            return RedirectToAction("Index");

        }


        [HttpPost]   
        public ActionResult save_requests()
        {


            noc = Request.Form["numberofcopies"];
            pn = Request.Form["ThePhoneNumber"];



            Request request = new Request() {

                Citizen_ID = rq,
                Mostanad_ID = int.Parse(mostand_id.ToString()),
                Msl7a_ID = int.Parse(msl7a_id.ToString()),
                No_of_copies = int.Parse(noc.ToString()),
                Phone_Number = pn.ToString(),
            };

            if (ModelState.IsValid)
            {
                db.Requests.Add(request);
                db.SaveChanges();


                 
            }
            return RedirectToAction("Requestspage");
        }

        public ActionResult confirmpage()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }

}