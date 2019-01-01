namespace TimeMachine.Data.Models.Posts
{
    using System;
    using TimeMachine.Data.Models.Contracts;

    public class Video : Post, IMedia
    {
        public string Url { get; set; }

        public string Title { get; set; }

        public string Caption { get; set; }

        public DateTime UploadedOn { get; set; }

        public DateTime CapturedOn { get; set; }

    }
}
