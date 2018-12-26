namespace TimeMachine.Services.DataServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using TimeMachine.Data;
    using TimeMachine.Data.Common;
    using TimeMachine.Data.Models.UserProfile;
    using TimeMachine.Services.DataServices.Contracts;
    using TimeMachine.Services.Models.Stories;

    public class StoriesService : IStoriesService
    {
        private readonly IRepository<Story> _storiesRepository;

        public StoriesService(IRepository<Story> storiesRepository)
        {
            this._storiesRepository = storiesRepository;
        }

        public IEnumerable<StoryViewModel> GetAll()
        {
            var stories = this._storiesRepository.All()
                .Select(x => new StoryViewModel
                    {
                        Content = x.TextContent
                    }).ToList();

            return stories;
        }

        public int GetCount()
        {
            return this.GetAll().Count();
        }
    }
}
