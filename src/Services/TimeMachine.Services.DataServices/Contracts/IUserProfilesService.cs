namespace TimeMachine.Services.DataServices.Contracts
{
    using System.Collections.Generic;
    using TimeMachine.Web.Models.Home;

    public interface IUserProfilesService
    {
        IEnumerable<IndexUserViewModel> GetAll();

        bool IsUserProfileByIdValid(int categoryId);

        int? GetUserProfileId(string name);
    }
}
