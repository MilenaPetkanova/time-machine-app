namespace TimeMachine.Services.DataServices.Contracts
{
    using System.Collections.Generic;
    using TimeMachine.Services.Models.UserProfiles;

    public interface IUserProfilesService
    {
        IEnumerable<IndexUserViewModel> GetAll();

        bool IsUserProfileByIdValid(int categoryId);

        int? GetUserProfileId(string name);
    }
}
