using CollegeFootballScorecard.Models;
using Dapper;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace CollegeFootballScorecard
{
    public class cfbRepo : IcfbRepo
    {

        private readonly IDbConnection _conn;

        public cfbRepo(IDbConnection conn) 
        {
            _conn= conn;
        }

        public IEnumerable<Teams> GetTeams() 
        {
            return _conn.Query<Teams>("Select * from xxiiseason;");
        }

        public IEnumerable<Conferences> GetConf()
        {
            return _conn.Query<Conferences>("Select * from Conferences");
        }


    }
}
