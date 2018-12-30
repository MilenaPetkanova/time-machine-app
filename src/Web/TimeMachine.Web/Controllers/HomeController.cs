namespace TimeMachine.Web.Controllers
{
    using System.Diagnostics;
    using AutoMapper;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using TimeMachine.Web.Areas.Identity.Data;
    using TimeMachine.Services.DataServices.Contracts;
    using TimeMachine.Services.Models;

    public class HomeController : BaseController
    {
        private readonly IUsersService _usersService;

        public HomeController(UserManager<TimeMachineUser> userManager, SignInManager<TimeMachineUser> signInManager, IMapper mapper, IUsersService usersService)
            : base(userManager, signInManager, mapper)
        {
            this._usersService = usersService;
        }

        public IActionResult Index()
        {
            var usersViewModels = this._usersService.GetAllPublic();

            return this.View(usersViewModels);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This platform is the spacetime, where parents from the present could tell or show anything to theirs children from the future.";

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
