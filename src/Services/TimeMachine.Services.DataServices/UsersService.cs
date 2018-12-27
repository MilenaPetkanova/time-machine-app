namespace TimeMachine.Services.DataServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using TimeMachine.Data.Common;
    using TimeMachine.Services.DataServices.Contracts;
    using TimeMachine.Services.Models.Home;
    using TimeMachine.Web.Areas.Identity.Data;

    public class UsersService : IUsersService
    {
        private readonly IRepository<TimeMachineUser> _usersRepository;

        public UsersService(IRepository<TimeMachineUser> usersRepository)
        {
            this._usersRepository = usersRepository;
        }

        public IEnumerable<IndexUserViewModel> GetAll()
        {
            var userViewModels = _usersRepository.All()
                .Where(u => u.IsProfilePrivate.Equals("false"))
                .OrderBy(u => Guid.NewGuid())
                .Select(u => new IndexUserViewModel
                {
                    FullName = u.FullName,
                    BirthDate = u.BirthDate.ToString()
                }).ToList();

            return userViewModels;
        }

        public int GetCount()
        {
            return this.GetAll().Count();
        }
    }
}
