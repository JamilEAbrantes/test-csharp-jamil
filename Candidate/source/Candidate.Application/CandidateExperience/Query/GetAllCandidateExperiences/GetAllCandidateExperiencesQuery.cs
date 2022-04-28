using MediatR;
using System;
using System.Collections.Generic;

namespace Candidate.Application.CandidateExperience.Query.GetAllCandidateExperiences
{
    public class GetAllCandidateExperiencesQuery : IRequest<IEnumerable<GetAllCandidateExperiencesViewModel>>
    {
        public Guid CandidateId { get; set; }
    }
}