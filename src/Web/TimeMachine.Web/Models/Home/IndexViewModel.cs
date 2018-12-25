namespace TimeMachine.Web.Models.Home
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public IEnumerable<IndexUserProfileViewModel> UserProfiles { get; set; }
    }
}
