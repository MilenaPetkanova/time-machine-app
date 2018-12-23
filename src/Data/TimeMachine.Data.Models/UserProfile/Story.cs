namespace TimeMachine.Data.Models.UserProfile
{
    using System;
    using TimeMachine.Data.Common;

    public class Story : BaseModel<int>
    {
        public DateTime CreatedOn { get; set; }

        public int CurrentUserAge { get; set; }

        public string TextContent { get; set; }

        public int? UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
