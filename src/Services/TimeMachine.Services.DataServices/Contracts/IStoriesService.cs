namespace TimeMachine.Services.DataServices.Contracts
{
    using System.Collections.Generic;
    using TimeMachine.Services.Models.Stories;

    public interface IStoriesService
    {
        IEnumerable<StoryViewModel> GetAllUserStories(string userId);

        IEnumerable<StoryViewModel> GetLastUserStories(string userId, int storiesCount);
    }
}
