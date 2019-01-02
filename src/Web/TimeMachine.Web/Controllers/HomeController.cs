//namespace TimeMachine.Web.Controllers
//{
//    using System.Diagnostics;
//    using AutoMapper;
//    using Microsoft.AspNetCore.Identity;
//    using Microsoft.AspNetCore.Mvc;
//    using TimeMachine.Web.Areas.Identity.Data;
//    using TimeMachine.Services.DataServices.Contracts;
//    using TimeMachine.Services.Models;
//    using TimeMachine.Services.Models.TimeMachineUsers;
//    using Microsoft.AspNetCore.Authorization;

//    public class HomeController : BaseController
//    {
//        private readonly IUsersService _usersService;
//        private readonly IStoriesService _storiesService;

//        public HomeController(UserManager<TimeMachineUser> userManager, SignInManager<TimeMachineUser> signInManager, IMapper mapper, 
//            IUsersService usersService, IStoriesService storiesService)
//            : base(userManager, signInManager, mapper)
//        {
//            this._usersService = usersService;  
//            this._storiesService = storiesService;
//        }

//        [AllowAnonymous]
//        public IActionResult Index()
//        {
//            if (this._signInManager.IsSignedIn(User))
//            {
//                var currentUserId = _userManager.GetUserId(User);
//                var currentUser = this._usersService.GetUserById(currentUserId);

//                var userProfileViewModel = this._mapper.Map<UserProfileViewModel>(currentUser);

//                var userStoryViewModels = this._storiesService.GetLastUserStories(currentUserId, 5);

//                userProfileViewModel.Stories = userStoryViewModels;

//                return this.View(userProfileViewModel);
//            }

//            return this.View();
//        }

//        public IActionResult About()
//        {
//            ViewData["Message"] = "This platform is the spacetime, where parents from the present could tell or show anything to theirs children from the future.";

//            return View();
//        }

//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}
