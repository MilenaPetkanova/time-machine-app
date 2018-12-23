namespace TimeMachine.Data.Models.UserProfile
{
    using System;
    using TimeMachine.Data.Common;

    public class Letter : BaseModel<int>
    {
        public DateTime CreatedOn { get; set; }

        public int CurrentUserAge { get; set; }

        public string SenderFullName { get; set; }

        public string SenderRelation { get; set; }

        public string TextContent { get; set; }

        public int? UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
