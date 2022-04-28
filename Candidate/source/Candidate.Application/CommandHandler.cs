using Candidate.Domain.Core;
using Candidate.Infra.Data.UoW;
using MediatR;
using System.Collections.Generic;
using System.Linq;

namespace Candidate.Application
{
    public abstract class CommandHandler
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _uow;

        public CommandHandler(IUnitOfWork uow, IMediator mediator)
        {
            this._mediator = mediator;
            _uow = uow;
        }

        public bool Commit()
        {
            if (_uow.Commit()) return true;

            return false;
        }

        public void PublishEvents(IList<IntegrationEvent> events)
        {
            events.ToList().ForEach(e => _mediator.Publish(e));
        }
    }
}