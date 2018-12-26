namespace TimeMachine.Web.Controllers
{
    using System.Diagnostics;
    using AutoMapper;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    using TimeMachine.Web.Areas.Identity.Data;
    using TimeMachine.Web.Models;
    using TimeMachine.Services.DataServices.Contracts;
    using TimeMachine.Services.Models.Stories;

    public class HomeController : BaseController
    {
        private readonly IStoriesService _storiesService;

        public HomeController(UserManager<TimeMachineUser> userManager, SignInManager<TimeMachineUser> signInManager, IMapper mapper, IStoriesService storiesService)
            : base(userManager, signInManager, mapper)
        {
            this._storiesService = storiesService;
        }

        public IActionResult Index()
        {
            var stories = this._storiesService.GetAll();

            var model = new StoriesViewModel
            {
                Stories = stories
            };

            return this.View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
