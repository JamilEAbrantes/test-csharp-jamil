using MediatR;
using System;

namespace Candidate.Application.CandidateExperience.Query.GetCandidateExperience
{
    public class GetCandidateExperienceQuery : IRequest<GetCandidateExperienceViewModel>
    {
        public Guid Id { get; set; }
    }
}