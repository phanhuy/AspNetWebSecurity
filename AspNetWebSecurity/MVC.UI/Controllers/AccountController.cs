using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Login()
		{
			string connString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;


			using (SqlConnection con = new SqlConnection(connString))
			{
				con.Open();
				using (SqlCommand command = new SqlCommand("SELECT * FROM Users", con))
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						Console.WriteLine("{0} {1} {2}",
						reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
					}
				}
			}


			return View();
		}
    }
}