using Microsoft.AspNetCore.Mvc;
using System.Data;
using CollegeFootballScorecard.Models;



namespace CollegeFootballScorecard
{
    public interface IcfbRepo
    {

        public IEnumerable<Teams> GetTeams();

        public IEnumerable<Conferences> GetConf();
    }
}
