namespace TimeMachine.Data.Models.Contracts
{
    using System;

    public interface IPersonProfile
    {
        DateTime CreateProfileOn { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string FullName { get; }
    }
}
