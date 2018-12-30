namespace TimeMachine.Data.Models.UserProfile
{
    using System;
    using TimeMachine.Data.Common.Abstraction;
    using TimeMachine.Web.Areas.Identity.Data;

    public class Letter : BaseModel<int>
    {
        public DateTime CreatedOn { get; set; }

        public int CurrentUserAge { get; set; }

        public string SenderFullName { get; set; }

        public string SenderRelation { get; set; }

        public string TextContent { get; set; }

        public string UserId { get; set; }
        public TimeMachineUser User { get; set; }
    }
}
