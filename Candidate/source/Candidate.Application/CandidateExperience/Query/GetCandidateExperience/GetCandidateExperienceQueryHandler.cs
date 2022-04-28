using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using CandidateExperienceAgg = Candidate.Domain.CandidateExperienceAggregate;

namespace Candidate.Application.CandidateExperience.Query.GetCandidateExperience
{
    public class GetCandidateExperienceQueryHandler : IRequestHandler<GetCandidateExperienceQuery, GetCandidateExperienceViewModel>
    {
        private readonly CandidateExperienceAgg.ICandidateExperienceRepository candidateExperienceRepository;
        private readonly IMapper mapper;

        public GetCandidateExperienceQueryHandler(CandidateExperienceAgg.ICandidateExperienceRepository candidateExperienceRepository, IMapper mapper)
        {
            this.candidateExperienceRepository = candidateExperienceRepository;
            this.mapper = mapper;
        }

        public Task<GetCandidateExperienceViewModel> Handle(GetCandidateExperienceQuery request, CancellationToken cancellationToken)
        {
            var candidateExperience = candidateExperienceRepository.Get(request.Id);
            var candidateExperienceViewModel = mapper.Map<GetCandidateExperienceViewModel>(candidateExperience);

            return Task.FromResult(candidateExperienceViewModel);
        }
    }
}
