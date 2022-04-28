using Candidate.Infra.Data.UoW;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using CandidateExperienceAgg = Candidate.Domain.CandidateExperienceAggregate;

namespace Candidate.Application.CandidateExperience.Commands.RegisterCandidateExperience
{
    public class RegisterCandidateExperienceCommandHandler : CommandHandler, IRequestHandler<RegisterCandidateExperienceCommand, bool>
    {
        private readonly CandidateExperienceAgg.ICandidateExperienceRepository candidateExperienceRepository;

        public RegisterCandidateExperienceCommandHandler(CandidateExperienceAgg.ICandidateExperienceRepository candidateExperienceRepository, IUnitOfWork uow, IMediator mediator) : base(uow, mediator)
        {
            this.candidateExperienceRepository = candidateExperienceRepository;
        }

        public Task<bool> Handle(RegisterCandidateExperienceCommand request, CancellationToken cancellationToken)
        {
            var candidateExperience =
                new CandidateExperienceAgg.CandidateExperience(request.Company,
                                                                request.Job,
                                                                request.Description,
                                                                request.Salary,
                                                                request.BeginDate,
                                                                request.EndDate,
                                                                request.CandidateId);

            candidateExperienceRepository.Add(candidateExperience);

            Commit();

            PublishEvents(candidateExperience.Events);

            return Task.FromResult(true);
        }
    }
}