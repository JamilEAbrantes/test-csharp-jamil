using Candidate.Domain.CandidateAggregate.Event;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Candidate.Application.Candidate.Commands.UpdateCandidate
{
    public class UpdatedCandidateEventHandler : INotificationHandler<UpdatedCandidateIntegrationEvent>
    {
        public Task Handle(UpdatedCandidateIntegrationEvent notification, CancellationToken cancellationToken)
        {
            // Gerar os resultados em um console 
            throw new System.NotImplementedException();
        }
    }
}