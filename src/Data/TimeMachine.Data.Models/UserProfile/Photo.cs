namespace TimeMachine.Data.Models.UserProfile
{
    using System;
    using TimeMachine.Data.Common;

    public class Photo : BaseModel<int>
    {
        public string Url { get; set; }

        public string Title { get; set; }

        public string Caption { get; set; }

        public DateTime UploadedOn { get; set; }

        public DateTime CapturedOn { get; set; }

        public int? UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
