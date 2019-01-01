namespace TimeMachine.Data.Models.Contracts
{
    using System;
    using System.Collections.Generic;
    using TimeMachine.Data.Models.Posts;

    public interface IReaderProfile
    {
        DateTime BirthdayDate { get; set; }

        int Age { get; }

        IList<Post> Posts { get; set; }
    }
}
