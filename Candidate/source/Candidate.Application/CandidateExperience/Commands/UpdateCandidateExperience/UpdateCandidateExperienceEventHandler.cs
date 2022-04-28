using Candidate.Domain.CandidateExperienceAggregate.Event;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Candidate.Application.CandidateExperience.Commands.UpdateCandidateExperience
{
    public class UpdateCandidateExperienceEventHandler : INotificationHandler<UpdatedCandidateExperienceIntegrationEvent>
    {
        public Task Handle(UpdatedCandidateExperienceIntegrationEvent notification, CancellationToken cancellationToken)
        {
            // Gerar os resultados em um console 
            throw new System.NotImplementedException();
        }
    }
}