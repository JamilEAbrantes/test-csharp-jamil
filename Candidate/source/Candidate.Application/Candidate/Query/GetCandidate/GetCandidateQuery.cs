using MediatR;
using System;

namespace Candidate.Application.Candidate.Query.GetCandidate
{
    public class GetCandidateQuery : IRequest<GetCandidateViewModel>
    {
        public Guid Id { get; set; }
    }
}