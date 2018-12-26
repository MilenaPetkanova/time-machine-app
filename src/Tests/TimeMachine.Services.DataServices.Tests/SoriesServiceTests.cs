namespace TimeMachine.Services.DataServices.Tests
{
    using System;
    using Moq;
    using Xunit;

    using TimeMachine.Data.Common;
    using TimeMachine.Data.Models.UserProfile;
    using System.Collections.Generic;
    using System.Linq;

    public class SoriesServiceTests
    {
        [Fact]
        public void GetCountShouldReturnCorrectNumber()
        {
            var storiesRepository = new Mock<IRepository<Story>>();

            storiesRepository
                .Setup(r => r.All())
                .Returns(new List<Story>
                {
                    new Story(),
                    new Story(),
                    new Story()
                }.AsQueryable());

            var storiesService = new StoriesService(storiesRepository.Object);

            Assert.Equal(3, storiesService.GetCount());
        } 
    }
}
