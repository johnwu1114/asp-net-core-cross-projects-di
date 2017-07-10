using DAL.Interfaces;
using DAO;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public class MemberDAL : IMemberDAL
    {
        private readonly string _dbConnectionString;

        public MemberDAL(IConfigurationRoot config)
        {
            _dbConnectionString = config["DbConnection"];
            // Do something...
        }

        public void CreateMember(MemberDAO member)
        {
            // Do something...
        }
    }
}