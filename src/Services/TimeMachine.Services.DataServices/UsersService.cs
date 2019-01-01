//namespace TimeMachine.Services.DataServices
//{
//    using AutoMapper;
//    using System.Collections.Generic;
//    using System.Linq;
//    using TimeMachine.Data.Common.Contracts;
//    using TimeMachine.Services.DataServices.Contracts;
//    using TimeMachine.Services.Models.Home;
//    using TimeMachine.Services.Models.TimeMachineUsers;
//    using TimeMachine.Web.Areas.Identity.Data;

//    public class UsersService : IUsersService
//    {
//        private readonly IRepository<TimeMachineUser> _usersRepository;
//        protected readonly IMapper _mapper;

//        public UsersService(IRepository<TimeMachineUser> usersRepository, IMapper mapper)
//        {
//            this._usersRepository = usersRepository;
//            this._mapper = mapper;
//        }

//        public TimeMachineUser GetUserById(string userId)
//        {
//            var currentUser = _usersRepository.All()
//                .FirstOrDefault(u => u.Id.Equals(userId));

//            return currentUser;
//        }

//        public IEnumerable<IndexUserViewModel> GetAll()
//        {
//            var allUserViewModels = _usersRepository.All()
//                .Select(u => new IndexUserViewModel
//                {
//                    FullName = u.FullName,
//                    BirthDate = u.BirthDate.ToString()
//                }).ToList();

//            return allUserViewModels;
//        }

//        public IEnumerable<IndexUserViewModel> GetAllPublic()
//        {
//            var allPublicUserViewModels = _usersRepository.All()
//                .Where(u => u.IsProfilePrivate.Equals(false))
//                //.OrderBy(u => Guid.NewGuid())
//                .Select(u => new IndexUserViewModel
//                {
//                    FullName = u.FullName,
//                    BirthDate = u.BirthDate.ToString()
//                }).ToList();

//            return allPublicUserViewModels;
//        }

//        public IEnumerable<IndexUserViewModel> GetLastUsers(int count)
//        {
//            var allPublicUserViewModels = _usersRepository.All()
//                .Where(u => u.IsProfilePrivate.Equals("false"))
//                .TakeLast(count)
//                .Select(u => new IndexUserViewModel
//                {
//                    FullName = u.FullName,
//                    BirthDate = u.BirthDate.ToString()
//                }).ToList();

//            return allPublicUserViewModels;
//        }
//    }
//}
