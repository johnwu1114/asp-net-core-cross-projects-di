using BLL.Interfaces;
using DAL.Interfaces;
using DAO;

namespace BLL
{
    public class MemberBLL : IMemberBLL
    {
        private IMemberDAL _memberDAL;

        public MemberBLL(IMemberDAL memberDAL)
        {
            _memberDAL = memberDAL;
        }

        public void Register(MemberDAO member)
        {
            // Do something...
            _memberDAL.CreateMember(member);
        }
    }
}