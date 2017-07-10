using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISampleTransient _sampleTransient;
        private readonly ISampleScoped _sampleScoped;
        private readonly ISampleSingleton _sampleSingleton;
        private readonly IMemberBLL _memberBLL;

        public HomeController(ISampleTransient sampleTransient, ISampleScoped sampleScoped, ISampleSingleton sampleSingleton, IMemberBLL memberBLL)
        {
            _sampleTransient = sampleTransient;
            _sampleScoped = sampleScoped;
            _sampleSingleton = sampleSingleton;
            _memberBLL = memberBLL;
        }

        public IActionResult Index()
        {
            var message = $"<tr><td>Transient</td><td>{_sampleTransient.Id}</td></tr>"
                        + $"<tr><td>Scoped</td><td>{_sampleScoped.Id}</td></tr>"
                        + $"<tr><td>Singleton</td><td>{_sampleSingleton.Id}</td></tr>";
            return View(model: message);
        }

        public void Register()
        {
            _memberBLL.Register(null);
            Response.WriteAsync("Register Member");
        }
    }
}