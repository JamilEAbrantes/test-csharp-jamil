using MediatR;

namespace Candidate.Infra.CrossCutting.Bus
{
    public interface ICommand<T> : IRequest<T>
    {
    }
}