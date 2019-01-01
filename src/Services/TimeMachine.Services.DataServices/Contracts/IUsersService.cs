namespace TimeMachine.Services.DataServices.Contracts
{
    using System.Collections.Generic;
    using TimeMachine.Services.Models.Home;
    using TimeMachine.Services.Models.TimeMachineUsers;
    using TimeMachine.Web.Areas.Identity.Data;

    public interface IUsersService
    {
        TimeMachineUser GetUserById(string userId);

        IEnumerable<IndexUserViewModel> GetAll();

        IEnumerable<IndexUserViewModel> GetAllPublic();

        IEnumerable<IndexUserViewModel> GetLastUsers(int count);
    }
}
