using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CandidateExperienceAgg = Candidate.Domain.CandidateExperienceAggregate;

namespace Candidate.Application.CandidateExperience.Query.GetAllCandidateExperiences
{
    public class GetAllCandidateExperiencesQueryHandler : IRequestHandler<GetAllCandidateExperiencesQuery, IEnumerable<GetAllCandidateExperiencesViewModel>>
    {
        private readonly CandidateExperienceAgg.ICandidateExperienceRepository candidateExperienceRepository;
        private readonly IMapper mapper;

        public GetAllCandidateExperiencesQueryHandler(CandidateExperienceAgg.ICandidateExperienceRepository candidateExperienceRepository, IMapper mapper)
        {
            this.candidateExperienceRepository = candidateExperienceRepository;
            this.mapper = mapper;
        }

        public Task<IEnumerable<GetAllCandidateExperiencesViewModel>> Handle(GetAllCandidateExperiencesQuery request, CancellationToken cancellationToken)
        {
            var candidateExperiences = candidateExperienceRepository.GetAllExperiencesByCandidateId(request.CandidateId);
            var candidateExperiencesViewModel = mapper.Map<IEnumerable<GetAllCandidateExperiencesViewModel>>(candidateExperiences);

            return Task.FromResult(candidateExperiencesViewModel);
        }
    }
}
