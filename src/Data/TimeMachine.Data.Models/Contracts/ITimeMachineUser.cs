namespace TimeMachine.Data.Models.Contracts
{
    using System.Collections.Generic;

    public interface ITimeMachineUser : IPersonProfile
    {
        IList<ReaderProfile> ReaderProfiles { get; set; }
    }
}
