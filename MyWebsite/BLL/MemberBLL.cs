using BLL.Interfaces;
using DAL.Interfaces;
using Entities;

namespace BLL
{
    public class MemberBLL : IMemberBLL
    {
        private IMemberDAL _memberDAL;

        public MemberBLL(IMemberDAL memberDAL)
        {
            _memberDAL = memberDAL;
        }

        public void Register(Member member)
        {
            // Do something...
            _memberDAL.CreateMember(member);
        }
    }
}