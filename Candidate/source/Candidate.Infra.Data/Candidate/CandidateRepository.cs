using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using CandidateAgg = Candidate.Domain.CandidateAggregate;

namespace Candidate.Infra.Data.Candidate
{
    public class CandidateRepository : CandidateAgg.ICandidateRepository
    {
        private readonly CandidateDBContext context;

        public CandidateRepository(CandidateDBContext context)
        {
            this.context = context;
        }

        public CandidateAgg.Candidate Get(Guid id)
        {
            return context.Set<CandidateAgg.Candidate>().AsNoTracking().Where(c => c.Id == id).Include(x => x.CandidateExperiences).FirstOrDefault();
        }

        public IEnumerable<CandidateAgg.Candidate> GetAll()
        {
            return context.Set<CandidateAgg.Candidate>().AsNoTracking().Include(x => x.CandidateExperiences).ToList();
        }

        public void Add(CandidateAgg.Candidate entity)
        {
            context.Set<CandidateAgg.Candidate>().Add(entity);
        }

        public void Update(CandidateAgg.Candidate entity)
        {
            context.Set<CandidateAgg.Candidate>().Update(entity);
        }

        public void Delete(CandidateAgg.Candidate entity)
        {
            context.Set<CandidateAgg.Candidate>().Remove(entity);
        }
    }
}