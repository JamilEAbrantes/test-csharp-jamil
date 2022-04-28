using Candidate.Domain.Core;
using System;

namespace Candidate.Domain.CandidateAggregate.Event
{
    public class DeletedCandidateIntegrationEvent : IntegrationEvent
    {
        public Guid Id { get; set; }
    }
}