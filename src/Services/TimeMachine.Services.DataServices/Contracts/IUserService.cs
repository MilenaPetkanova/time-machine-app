namespace TimeMachine.Services.DataServices.Contracts
{
    using System.Collections.Generic;
    using TimeMachine.Services.Models.Home;

    public interface IUserService
    {
        IEnumerable<IndexUserViewModel> GetAll();
    }
}
