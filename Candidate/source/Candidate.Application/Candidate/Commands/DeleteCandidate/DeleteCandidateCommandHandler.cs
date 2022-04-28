using Candidate.Infra.Data.UoW;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using CandidateAgg = Candidate.Domain.CandidateAggregate;

namespace Candidate.Application.Candidate.Commands.DeleteCandidate
{
    public class DeleteCandidateCommandHandler : CommandHandler, IRequestHandler<DeleteCandidateCommand, bool>
    {
        private readonly CandidateAgg.ICandidateRepository candidateRepository;

        public DeleteCandidateCommandHandler(CandidateAgg.ICandidateRepository candidateRepository, IUnitOfWork uow, IMediator mediator) : base(uow, mediator)
        {
            this.candidateRepository = candidateRepository;
        }

        public Task<bool> Handle(DeleteCandidateCommand request, CancellationToken cancellationToken)
        {
            var candidate = candidateRepository.Get(request.Id);

            candidateRepository.Delete(candidate);

            Commit();

            PublishEvents(candidate.Events);

            return Task.FromResult(true);
        }
    }
}