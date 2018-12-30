namespace TimeMachine.Services.DataServices.Contracts
{
    using System.Collections.Generic;
    using TimeMachine.Services.Models.Home;

    public interface IUsersService
    {
        IEnumerable<IndexUserViewModel> GetAll();

        IEnumerable<IndexUserViewModel> GetAllPublic();

        IEnumerable<IndexUserViewModel> GetLast(int count);
    }
}
