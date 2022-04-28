using AutoMapper;
using Candidate.Application.Candidate.Query.GetAllCandidates;
using Candidate.Application.Candidate.Query.GetCandidate;
using Candidate.Application.CandidateExperience.Query.GetAllCandidateExperiences;
using Candidate.Application.CandidateExperience.Query.GetCandidateExperience;
using CandidateAgg = Candidate.Domain.CandidateAggregate;
using CandidateExperienceAgg = Candidate.Domain.CandidateExperienceAggregate;

namespace Candidate.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<CandidateAgg.Candidate, GetCandidateViewModel>();
            CreateMap<CandidateAgg.Candidate, GetAllCandidatesViewModel>();
            CreateMap<CandidateExperienceAgg.CandidateExperience, GetCandidateExperienceViewModel>();
            CreateMap<CandidateExperienceAgg.CandidateExperience, GetAllCandidateExperiencesViewModel>();
        }
    }
}