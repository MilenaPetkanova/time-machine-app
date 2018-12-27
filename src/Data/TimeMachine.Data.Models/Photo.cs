namespace TimeMachine.Data.Models.UserProfile
{
    using System;
    using TimeMachine.Data.Common;
    using TimeMachine.Web.Areas.Identity.Data;

    public class Photo : BaseModel<int>
    {
        public string Url { get; set; }

        public string Title { get; set; }

        public string Caption { get; set; }

        public DateTime UploadedOn { get; set; }

        public DateTime CapturedOn { get; set; }

        public string UserId { get; set; }
        public TimeMachineUser User { get; set; }
    }
}
