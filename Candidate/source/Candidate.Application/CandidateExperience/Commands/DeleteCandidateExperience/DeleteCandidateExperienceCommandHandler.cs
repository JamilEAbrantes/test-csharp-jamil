using Candidate.Infra.Data.UoW;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using CandidateExperienceAgg = Candidate.Domain.CandidateExperienceAggregate;

namespace Candidate.Application.CandidateExperience.Commands.DeleteCandidateExperience
{
    public class DeleteCandidateExperienceCommandHandler : CommandHandler, IRequestHandler<DeleteCandidateExperienceCommand, bool>
    {
        private readonly CandidateExperienceAgg.ICandidateExperienceRepository candidateExperienceRepository;

        public DeleteCandidateExperienceCommandHandler(CandidateExperienceAgg.ICandidateExperienceRepository candidateExperienceRepository, IUnitOfWork uow, IMediator mediator) 
            : base(uow, mediator)
        {
            this.candidateExperienceRepository = candidateExperienceRepository;
        }

        public Task<bool> Handle(DeleteCandidateExperienceCommand request, CancellationToken cancellationToken)
        {
            var candidateExperience = candidateExperienceRepository.Get(request.Id);

            candidateExperienceRepository.Delete(candidateExperience);

            Commit();

            PublishEvents(candidateExperience.Events);

            return Task.FromResult(true);
        }
    }
}