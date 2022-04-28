using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using CandidateAgg = Candidate.Domain.CandidateAggregate;

namespace Candidate.Application.Candidate.Query.GetCandidate
{
    public class GetAllCandidateQueryHandler : IRequestHandler<GetCandidateQuery, GetCandidateViewModel>
    {
        private readonly CandidateAgg.ICandidateRepository candidateRepository;
        private readonly IMapper mapper;

        public GetAllCandidateQueryHandler(CandidateAgg.ICandidateRepository candidateRepository, IMapper mapper)
        {
            this.candidateRepository = candidateRepository;
            this.mapper = mapper;
        }

        public Task<GetCandidateViewModel> Handle(GetCandidateQuery request, CancellationToken cancellationToken)
        {
            var candidate = candidateRepository.Get(request.Id);
            var candidateViewModel = mapper.Map<GetCandidateViewModel>(candidate);

            return Task.FromResult(candidateViewModel);
        }
    }
}