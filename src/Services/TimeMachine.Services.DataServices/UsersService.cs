namespace TimeMachine.Services.DataServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using TimeMachine.Data.Common.Contracts;
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
            var allUserViewModels = _usersRepository.All()
                .Select(u => new IndexUserViewModel
                {
                    FullName = u.FullName,
                    BirthDate = u.BirthDate.ToString()
                }).ToList();

            return allUserViewModels;
        }

        public IEnumerable<IndexUserViewModel> GetAllPublic()
        {
            var allPublicUserViewModels = _usersRepository.All()
                .Where(u => u.IsProfilePrivate.Equals("false"))
                //.OrderBy(u => Guid.NewGuid())
                .Select(u => new IndexUserViewModel
                {
                    FullName = u.FullName,
                    BirthDate = u.BirthDate.ToString()
                }).ToList();

            return allPublicUserViewModels;
        }

        public IEnumerable<IndexUserViewModel> GetLast(int count)
        {
            var allPublicUserViewModels = _usersRepository.All()
                .Where(u => u.IsProfilePrivate.Equals("false"))
                .TakeLast(count)
                .Select(u => new IndexUserViewModel
                {
                    FullName = u.FullName,
                    BirthDate = u.BirthDate.ToString()
                }).ToList();

            return allPublicUserViewModels;
        }
    }
}
