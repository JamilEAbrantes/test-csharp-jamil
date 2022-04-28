using Candidate.Domain.Core;
using System;

namespace Candidate.Domain.CandidateExperienceAggregate.Event
{
    public class UpdatedCandidateExperienceIntegrationEvent : IntegrationEvent
    {
        public string Company { get; set; }

        public string Job { get; set; }

        public string Description { get; set; }

        public decimal Salary { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime? EndDate { get; private set; }

        public Guid CandidateId { get; private set; }

        public UpdatedCandidateExperienceIntegrationEvent(
            string company, 
            string job, 
            string description, 
            decimal salary, 
            DateTime beginDate, 
            DateTime? endDate, 
            Guid candidateId)
        {
            Company = company;
            Job = job;
            Description = description;
            Salary = salary;
            BeginDate = beginDate;
            EndDate = endDate;
            CandidateId = candidateId;
        }
    }
}