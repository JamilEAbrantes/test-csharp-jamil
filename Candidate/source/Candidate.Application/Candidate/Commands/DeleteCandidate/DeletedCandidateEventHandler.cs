using Candidate.Domain.CandidateAggregate.Event;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Candidate.Application.Candidate.Commands.DeleteCandidate
{
    public class DeletedCandidateEventHandler : INotificationHandler<DeletedCandidateIntegrationEvent>
    {
        public Task Handle(DeletedCandidateIntegrationEvent notification, CancellationToken cancellationToken)
        {
            // Gerar os resultados em um console 
            throw new System.NotImplementedException();
        }
    }
}