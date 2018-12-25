using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FunApp.Data.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TimeMachine.Data.Models.UserProfile;
using TimeMachine.Web.Areas.Identity.Data;
using TimeMachine.Web.Models;
using TimeMachine.Web.Models.Home;

namespace TimeMachine.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IRepository<TimeMachineUser> _userRepository;

        public HomeController(UserManager<TimeMachineUser> userManager, SignInManager<TimeMachineUser> signInManager, IMapper mapper, IRepository<TimeMachineUser> userRepository)
            : base(userManager, signInManager, mapper)
        {
            this._userRepository = userRepository;
        }

        public IActionResult Index()
        {
            var users = this._userRepository.All()
                .OrderBy(x => Guid.NewGuid())
                .Select(
                x => new IndexUserProfileViewModel
                {
                    UserFullName = x.UserName
                });

            var viewModel = new IndexViewModel
            {
                UserProfiles = users
            };


            return this.View(viewModel);
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
