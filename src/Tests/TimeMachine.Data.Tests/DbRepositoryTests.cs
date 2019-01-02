namespace TimeMachine.Data.Tests
{
    using System;
    using TimeMachine.Data.Models;
    using Xunit;
    using TimeMachine.Services.Constants;
    using Moq;
    using TimeMachine.Data.Contracts;
    using Microsoft.EntityFrameworkCore;
    using TimeMachine.Web.Models;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class DbRepositoryTests
    {
        [Fact]
        public async Task AddAsyncShouldAddEntityInDb()
        {
            var options = new DbContextOptionsBuilder<TimeMachineContext>()
                    .UseInMemoryDatabase(databaseName: "Save_Tag_Db")
                    .Options;

            var db = new TimeMachineContext(options);

            var dbRepository = new DbRepository<Tag>(db);

            await dbRepository.AddAsync(new Tag());
            await dbRepository.SaveChangesAsync();

            var tagsCount = db.Tags.Count();

            Assert.Equal(1, tagsCount);
        }

        [Fact]
        public async Task AllShouldReturnEntitiesCountOfDbSet()
        {
            var options = new DbContextOptionsBuilder<TimeMachineContext>()
                .UseInMemoryDatabase(databaseName: "Get_All_Tags_Db")
                .Options;

            var db = new TimeMachineContext(options);

            var dbRepository = new DbRepository<Tag>(db);

            await dbRepository.AddAsync(new Tag());
            await dbRepository.AddAsync(new Tag());
            await dbRepository.AddAsync(new Tag());
            await dbRepository.SaveChangesAsync();

            var tagsCount = dbRepository.All().Count();

            Assert.Equal(3, tagsCount);
        }

        // Failed
        [Fact]
        public async Task GetLastShouldReturnLastEntitiesOfDbSet()
        {
            var options = new DbContextOptionsBuilder<TimeMachineContext>()
                .UseInMemoryDatabase(databaseName: "Get_Last_Tags_Db")
                .Options;

            var db = new TimeMachineContext(options);

            var dbRepository = new DbRepository<Tag>(db);

            await dbRepository.AddAsync(new Tag());
            await dbRepository.AddAsync(new Tag());
            await dbRepository.AddAsync(new Tag());
            await dbRepository.SaveChangesAsync();

            var lastEntities = dbRepository.GetLast(1);

            var lastEntitiesCount = lastEntities.Count();

            Assert.Equal(1, lastEntitiesCount);
        }

        [Fact]
        public async Task DeleteShouldDeleteEntityOfDbSet()
        {
            var options = new DbContextOptionsBuilder<TimeMachineContext>()
                .UseInMemoryDatabase(databaseName: "Get_Last_Tags_Db")
                .Options;

            var db = new TimeMachineContext(options);

            var dbRepository = new DbRepository<Tag>(db);

            var tagToDlelete = new Tag();

            await dbRepository.AddAsync(tagToDlelete);
            await dbRepository.AddAsync(new Tag());
            await dbRepository.SaveChangesAsync();

            dbRepository.Delete(tagToDlelete);
            await dbRepository.SaveChangesAsync();

            var entitiesCount = db.Tags.Count();

            Assert.Equal(1, entitiesCount);
        }
    }
}
