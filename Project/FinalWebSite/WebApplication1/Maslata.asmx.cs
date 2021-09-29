using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for Maslata
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Maslata : System.Web.Services.WebService
    {

        [WebMethod]
        public string CustomerLogin(string NationalID, string Password)
        {
            WebsiteDatabaseProjectEntities _context = new WebsiteDatabaseProjectEntities();
            Citizen CurrentCitizen = (from Citizen c in _context.Citizens
                                      where c.National_ID == NationalID
                                      select c
                                        ).FirstOrDefault();
            try
            {
                if (CurrentCitizen.Password == Password)
                {
                    return CurrentCitizen.National_ID;
                }
                else {
                    return "0";
                }
            }
            catch
            {
                return "0";
            }
        }






        [WebMethod]
        public string CustomerRequists(string CustomerID)
        {
            string result = "";
            WebsiteDatabaseProjectEntities _context = new WebsiteDatabaseProjectEntities();
            List<Request> CurrentReqists = (from Request r in _context.Requests
                                            where r.Citizen_ID == CustomerID
                                            select r).ToList();
            foreach (Request rr in CurrentReqists)
            {
                result = result + rr.Mostanadat.Mostanad_Name + " " + rr.Msale7.Msl7a_Name +"&"+ rr.Request_ID+ "#";
            }
            return result;
        }







        [WebMethod]
        public bool PrintDoc(int RequestID)
        {
            WebsiteDatabaseProjectEntities _context = new WebsiteDatabaseProjectEntities();
            Request CurrentReqist = (from Request r in _context.Requests
                                            where r.Request_ID == RequestID
                                            select r).FirstOrDefault();
            CurrentReqist.toPrint = true;
            _context.SaveChanges();
            return true;
        }
    }
}
