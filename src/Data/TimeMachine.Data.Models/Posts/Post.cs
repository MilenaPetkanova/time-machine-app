namespace TimeMachine.Data.Models.Posts
{
    using System;
    using System.Collections.Generic;
    using TimeMachine.Data.Models.Contracts;

    public abstract class Post : BaseModel<int>, IPost
    {
        public Post()
        {
            this.Tags = new List<Tag>();
        }

        public DateTime CreatedOn => DateTime.Now;

        public string Name { get; set; }

        public IList<Tag> Tags { get; set; }

        public int ReaderProfileId { get; set; }
        public ReaderProfile ReaderProfile { get; set; }
    }
}
