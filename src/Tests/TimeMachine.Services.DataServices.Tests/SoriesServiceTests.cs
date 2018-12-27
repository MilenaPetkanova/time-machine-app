namespace TimeMachine.Services.DataServices.Tests
{
    using System;
    using Moq;
    using Xunit;

    using TimeMachine.Data.Common;
    using TimeMachine.Data.Models.UserProfile;
    using System.Collections.Generic;
    using System.Linq;
    using TimeMachine.Web.Areas.Identity.Data;

    public class SoriesServiceTests
    {
        //[Fact]
        //public void GetAllUserStoriesShouldReturnOnlyUserStories()
        //{
        //    var user = new TimeMachineUser
        //    {
        //        Id = "testId",
        //        UserName = "testUserName",
        //        Email = "testEmail",
        //        PasswordHash = "testPassword",
        //        Stories = 
        //    };

        //    var storiesRepository = new Mock<IRepository<Story>>();

        //    storiesRepository
        //        .Setup(r => r.All())
        //        .Returns(new List<Story>
        //        {
        //            new Story(),
        //            new Story(),
        //            new Story()
        //        }.AsQueryable());

        //    var storiesService = new StoriesService(storiesRepository.Object);

        //    Assert.Equal(3, storiesService.);
        //} 
    }
}
