using DAL.Interfaces;
using Entities;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public class MemberDAL : AbstractBaseDAL, IMemberDAL
    {
        public MemberDAL(IConfigurationRoot config) : base(config)
        {
        }

        public void CreateMember(Member member)
        {
            // Do something...
        }
    }
}