using CollegeFootballScorecard.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Text;


namespace CollegeFootballScorecard.Controllers
{
    public class TeamsController : Controller
    {

        private readonly IcfbRepo repo;

        public TeamsController(IcfbRepo repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var conf = repo.GetConf();

            return View();
        }

    }
}
