namespace Candidate.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CandidateDBContext candidateContext;

        public UnitOfWork(CandidateDBContext context)
        {
            candidateContext = context;
        }

        public bool Commit()
        {
            return candidateContext.SaveChanges() > 0;
        }

        public void Dispose()
        {
            candidateContext.Dispose();
        }
    }
}