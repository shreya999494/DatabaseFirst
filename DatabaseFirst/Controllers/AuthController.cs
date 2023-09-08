using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseFirst.Controllers
{
    public class AuthController : Controller
    {

        //[HttpGet]
        //[ActionName("CreateToken")]
        //// GET: Auth
        //public string CreateToken(string username,string password)
        //{
        //    string token = string.Empty;
        //    if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password)) 
        //    {
        //        token = TokenManager.GenerateToken(username, 10);
        //    }

        //    return token;
        //}

        //[HttpGet]
        [ActionName("CreateToken")]
        // GET: Auth
        public string CreateToken()
        {
           

            return "shreya";
        }
    }
}