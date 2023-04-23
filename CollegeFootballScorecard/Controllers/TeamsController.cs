using CollegeFootballScorecard.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Text;


namespace CollegeFootballScorecard.Controllers
{
    public class TeamsController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

    }
}
