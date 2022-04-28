using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using CandidateExperienceAgg = Candidate.Domain.CandidateExperienceAggregate;

namespace Candidate.Infra.Data.CandidateExperience
{
    public class CandidateExperienceRepository : CandidateExperienceAgg.ICandidateExperienceRepository
    {
        private readonly CandidateDBContext context;

        public CandidateExperienceRepository(CandidateDBContext context)
        {
            this.context = context;
        }

        public CandidateExperienceAgg.CandidateExperience Get(Guid id)
        {
            return context.Set<CandidateExperienceAgg.CandidateExperience>().AsNoTracking().Where(c => c.Id == id).FirstOrDefault();
        }

        public IEnumerable<CandidateExperienceAgg.CandidateExperience> GetAllExperiencesByCandidateId(Guid candidateId)
        {
            return context.Set<CandidateExperienceAgg.CandidateExperience>().AsNoTracking().Where(x => x.CandidateId == candidateId).ToList();
        }

        public void Add(CandidateExperienceAgg.CandidateExperience entity)
        {
            context.Set<CandidateExperienceAgg.CandidateExperience>().Add(entity);
        }

        public void Update(CandidateExperienceAgg.CandidateExperience entity)
        {
            context.Set<CandidateExperienceAgg.CandidateExperience>().Update(entity);
        }

        public void Delete(CandidateExperienceAgg.CandidateExperience entity)
        {
            context.Set<CandidateExperienceAgg.CandidateExperience>().Remove(entity);
        }
    }
}