using System.Threading.Tasks;

namespace Candidate.Infra.CrossCutting.Bus
{
    interface IBus
    {
        Task SendCommand<T>(ICommand<T> command);

        Task RaiseEvent(IEvent @event);
    }
}