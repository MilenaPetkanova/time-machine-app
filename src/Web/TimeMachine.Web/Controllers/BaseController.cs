namespace TimeMachine.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using TimeMachine.Web.Areas.Identity.Data;

    public abstract class BaseController : Controller
    {
        protected readonly UserManager<TimeMachineUser> _userManager;
        protected readonly SignInManager<TimeMachineUser> _signInManager;
        protected readonly IMapper _mapper;

        public BaseController(UserManager<TimeMachineUser> userManager, SignInManager<TimeMachineUser> signInManager, IMapper mapper)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._mapper = mapper;
        }
    }
}
