using BLL.Interfaces;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Controllers
{
    [Route("api/[controller]")]
    public class MemberController : Controller
    {
        private readonly IMemberBLL _memberBLL;

        public MemberController(IMemberBLL memberBLL)
        {
            _memberBLL = memberBLL;
        }

        [HttpPost]
        [Route("registration")]
        public void Registration([FromBody]Member member)
        {
            _memberBLL.Register(member);
            Response.WriteAsync("Register Member");
        }
    }
}