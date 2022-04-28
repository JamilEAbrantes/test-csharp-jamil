using Candidate.Domain.CandidateExperienceAggregate.Event;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Candidate.Application.CandidateExperience.Commands.RegisterCandidateExperience
{
    public class RegisterCandidateExperienceEventHandler : INotificationHandler<RegisteredCandidateExperienceIntegrationEvent>
    {
        public Task Handle(RegisteredCandidateExperienceIntegrationEvent notification, CancellationToken cancellationToken)
        {
            // Gerar os resultados em um console 
            throw new System.NotImplementedException();
        }
    }
}