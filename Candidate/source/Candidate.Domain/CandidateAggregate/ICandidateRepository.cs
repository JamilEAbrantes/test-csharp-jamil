using System;
using System.Collections.Generic;

namespace Candidate.Domain.CandidateAggregate
{
    public interface ICandidateRepository
    {
        Candidate Get(Guid id);

        IEnumerable<Candidate> GetAll();

        void Add(Candidate entity);

        void Update(Candidate entity);

        void Delete(Candidate entity);
    }
}