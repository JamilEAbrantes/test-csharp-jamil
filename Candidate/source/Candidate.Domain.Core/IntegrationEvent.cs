using MediatR;
using System;

namespace Candidate.Domain.Core
{
    public abstract class IntegrationEvent : INotification
    {
        public DateTime DateOccurrence => DateTime.Now;
    }
}