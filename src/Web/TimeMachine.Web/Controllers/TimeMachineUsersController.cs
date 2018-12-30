namespace TimeMachine.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Identity;
    using TimeMachine.Web.Areas.Identity.Data;
    using TimeMachine.Services.DataServices.Contracts;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using TimeMachine.Services.Models.Stories;

    public class TimeMachineUsersController : BaseController
    {
        private readonly IUsersService _usersService;
        private readonly IStoriesService _storiesService;

        public TimeMachineUsersController(UserManager<TimeMachineUser> userManager, SignInManager<TimeMachineUser> signInManager, IMapper mapper, IUsersService usersService, IStoriesService storiesService)
            : base(userManager, signInManager, mapper)
        {
            this._usersService = usersService;
            this._storiesService = storiesService;
        }

        public async Task<IActionResult> Index()
        {
            var currentUserId = _userManager.GetUserId(User);

            var userStoryViewModels = this._storiesService.GetUserStories(currentUserId, 5);

            return this.View(userStoryViewModels);
        }
    }
}
