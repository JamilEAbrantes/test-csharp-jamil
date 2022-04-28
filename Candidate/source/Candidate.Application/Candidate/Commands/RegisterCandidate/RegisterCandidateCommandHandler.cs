using Candidate.Infra.Data.UoW;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using CandidateAgg = Candidate.Domain.CandidateAggregate;

namespace Candidate.Application.Candidate.Commands.RegisterCandidate
{
    public class RegisterCandidateCommandHandler : CommandHandler, IRequestHandler<RegisterCandidateCommand, bool>
    {
        private readonly CandidateAgg.ICandidateRepository candidateRepository;

        public RegisterCandidateCommandHandler(CandidateAgg.ICandidateRepository candidateRepository, IUnitOfWork uow, IMediator mediator) : base(uow, mediator)
        {
            this.candidateRepository = candidateRepository;
        }

        public Task<bool> Handle(RegisterCandidateCommand request, CancellationToken cancellationToken)
        {
            var candidate =
                new CandidateAgg.Candidate(request.Name,
                                            request.Surname,
                                            request.Birthdate,
                                            request.Email);

            candidateRepository.Add(candidate);

            Commit();

            PublishEvents(candidate.Events);

            return Task.FromResult(true);
        }
    }
}