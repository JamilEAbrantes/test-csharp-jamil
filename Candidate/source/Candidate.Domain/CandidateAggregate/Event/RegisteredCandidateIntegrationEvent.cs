using Candidate.Domain.Core;
using System;

namespace Candidate.Domain.CandidateAggregate.Event
{
    public class RegisteredCandidateIntegrationEvent : IntegrationEvent
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime Birthdate { get; set; }

        public string Email { get; set; }

        public RegisteredCandidateIntegrationEvent(
            string name,
            string surname,
            DateTime birthdate,
            string email)
        {
            Name = name;
            Surname = surname;
            Birthdate = birthdate;
            Email = email;
        }
    }
}