namespace TimeMachine.Web.Areas.Identity.Data
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;
    using TimeMachine.Data.Models;
    using TimeMachine.Data.Models.Contracts;

    public class TimeMachineUser : IdentityUser, ITimeMachineUser
    {
        public TimeMachineUser()
        {
            this.ReaderProfiles = new List<ReaderProfile>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{this.FirstName} {this.LastName}";

        public DateTime CreateProfileOn { get; set; }

        public IList<ReaderProfile> ReaderProfiles { get; set; }
    }
}
