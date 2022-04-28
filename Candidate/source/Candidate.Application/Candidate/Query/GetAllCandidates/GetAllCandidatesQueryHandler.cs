using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CandidateAgg = Candidate.Domain.CandidateAggregate;

namespace Candidate.Application.Candidate.Query.GetAllCandidates
{
    public class GetAllCandidatesQueryHandler : IRequestHandler<GetAllCandidatesQuery, IEnumerable<GetAllCandidatesViewModel>>
    {
        private readonly CandidateAgg.ICandidateRepository candidateRepository;
        private readonly IMapper mapper;

        public GetAllCandidatesQueryHandler(CandidateAgg.ICandidateRepository candidateRepository, IMapper mapper)
        {
            this.candidateRepository = candidateRepository;
            this.mapper = mapper;
        }

        public Task<IEnumerable<GetAllCandidatesViewModel>> Handle(GetAllCandidatesQuery request, CancellationToken cancellationToken)
        {
            var candidates = candidateRepository.GetAll();
            var candidatesViewModel = mapper.Map<IEnumerable<GetAllCandidatesViewModel>>(candidates);

            return Task.FromResult(candidatesViewModel);
        }
    }
}
