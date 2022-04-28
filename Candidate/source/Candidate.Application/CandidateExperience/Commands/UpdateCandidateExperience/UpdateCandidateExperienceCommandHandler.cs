using Candidate.Infra.Data.UoW;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using CandidateExperienceAgg = Candidate.Domain.CandidateExperienceAggregate;

namespace Candidate.Application.CandidateExperience.Commands.UpdateCandidateExperience
{
    public class UpdateCandidateExperienceCommandHandler : CommandHandler, IRequestHandler<UpdateCandidateExperienceCommand, bool>
    {
        private readonly CandidateExperienceAgg.ICandidateExperienceRepository candidateExperienceRepository;

        public UpdateCandidateExperienceCommandHandler(CandidateExperienceAgg.ICandidateExperienceRepository candidateExperienceRepository, IUnitOfWork uow, IMediator mediator) 
            : base(uow, mediator)
        {
            this.candidateExperienceRepository = candidateExperienceRepository;
        }

        public Task<bool> Handle(UpdateCandidateExperienceCommand request, CancellationToken cancellationToken)
        {
            var candidateExperience = candidateExperienceRepository.Get(request.Id);

            var candidateUpdated =
                new CandidateExperienceAgg.CandidateExperience(request.Id,
                                                                request.Company,
                                                                request.Job,
                                                                request.Description,
                                                                request.Salary,
                                                                request.BeginDate,
                                                                request.EndDate,
                                                                candidateExperience.InsertDate,
                                                                request.CandidateId);

            candidateExperienceRepository.Update(candidateUpdated);

            Commit();

            PublishEvents(candidateExperience.Events);

            return Task.FromResult(true);
        }
    }
}
