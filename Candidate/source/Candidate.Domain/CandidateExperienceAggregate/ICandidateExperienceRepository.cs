using System;
using System.Collections.Generic;

namespace Candidate.Domain.CandidateExperienceAggregate
{
    public interface ICandidateExperienceRepository
    {
        CandidateExperience Get(Guid id);

        IEnumerable<CandidateExperience> GetAllExperiencesByCandidateId(Guid id);

        void Add(CandidateExperience entity);

        void Update(CandidateExperience entity);

        void Delete(CandidateExperience entity);
    }
}