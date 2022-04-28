using Candidate.Domain.Core;
using System;

namespace Candidate.Domain.CandidateExperienceAggregate.Event
{
    public class DeletedCandidateExperienceIntegrationEvent : IntegrationEvent
    {
        public Guid Id { get; set; }
    }
}