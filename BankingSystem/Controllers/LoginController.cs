using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace BankingSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginPage()
        {
            return View();
        }

        public ActionResult SuccessfulLogin()
        {
            return View();
        }

        public async Task<ActionResult> ButtonAction(string userid,string userpass,string button)
        {
            //if (userid.Length == 0 || userpass.Length == 0)
            //    return View("LoginPage");

            //else
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress=new Uri("http://localhost:59037/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage message = await client.GetAsync("api/LoginAuthenticate" +"?username=" + userid + "&password=" + userpass);
                    if(message.IsSuccessStatusCode)
                    {
                        string temp = message.Content.ReadAsStringAsync().Result;
                            return Content("role is "+temp.Substring(1,temp.Length-2));

                    }

                    Response.Redirect("https://www.google.com");


                }

                return View();
            }
            //return Content("UserId: " + userid + "\n"+ "password: " + userpass);
        }
    }
}