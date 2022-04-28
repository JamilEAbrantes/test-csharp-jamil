using Candidate.Domain.CandidateAggregate.Event;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Candidate.Application.Candidate.Commands.RegisterCandidate
{
    public class RegisteredCandidateEventHandler : INotificationHandler<RegisteredCandidateIntegrationEvent>
    {
        public Task Handle(RegisteredCandidateIntegrationEvent notification, CancellationToken cancellationToken)
        {
            // Gerar os resultados em um console 
            throw new System.NotImplementedException();
        }
    }
}