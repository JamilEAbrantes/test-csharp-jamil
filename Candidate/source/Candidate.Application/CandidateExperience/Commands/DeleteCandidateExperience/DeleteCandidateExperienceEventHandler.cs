using Candidate.Domain.CandidateExperienceAggregate.Event;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Candidate.Application.CandidateExperience.Commands.DeleteCandidateExperience
{
    public class DeleteCandidateExperienceEventHandler : INotificationHandler<DeletedCandidateExperienceIntegrationEvent>
    {
        public Task Handle(DeletedCandidateExperienceIntegrationEvent notification, CancellationToken cancellationToken)
        {
            // Gerar os resultados em um console 
            throw new System.NotImplementedException();
        }
    }
}