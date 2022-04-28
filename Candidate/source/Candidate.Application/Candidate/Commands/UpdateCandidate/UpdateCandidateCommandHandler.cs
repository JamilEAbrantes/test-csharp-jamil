using Candidate.Infra.Data.UoW;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using CandidateAgg = Candidate.Domain.CandidateAggregate;

namespace Candidate.Application.Candidate.Commands.UpdateCandidate
{
    public class UpdateCandidateCommandHandler : CommandHandler, IRequestHandler<UpdateCandidateCommand, bool>
    {
        private readonly CandidateAgg.ICandidateRepository candidateRepository;

        public UpdateCandidateCommandHandler(CandidateAgg.ICandidateRepository candidateRepository, IUnitOfWork uow, IMediator mediator) : base(uow, mediator)
        {
            this.candidateRepository = candidateRepository;
        }

        public Task<bool> Handle(UpdateCandidateCommand request, CancellationToken cancellationToken)
        {
            var candidate = 
                candidateRepository.Get(request.Id);

            var candidateUpdated =
                new CandidateAgg.Candidate(request.Id,
                                            request.Name,
                                            request.Surname,
                                            request.Birthdate,
                                            candidate.InsertDate,
                                            request.Email);

            candidateRepository.Update(candidateUpdated);

            Commit();

            PublishEvents(candidate.Events);

            return Task.FromResult(true);
        }
    }
}