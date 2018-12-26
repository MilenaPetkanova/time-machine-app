namespace TimeMachine.Services.DataServices.Contracts
{
    using System.Collections.Generic;
    using TimeMachine.Services.Models.Stories;

    public interface IStoriesService
    {
        IEnumerable<StoryViewModel> GetAll();

        int GetCount();
    }
}
