using System;

namespace Candidate.Infra.Data.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}