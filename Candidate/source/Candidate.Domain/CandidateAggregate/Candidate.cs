using Candidate.Domain.CandidateExperienceAggregate;
using Candidate.Domain.Core.Model;
using System;
using System.Collections.Generic;

namespace Candidate.Domain.CandidateAggregate
{
    public class Candidate : Entity
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public DateTime Birthdate { get; private set; }

        public string Email { get; private set; }

        public DateTime InsertDate { get; private set; }

        public DateTime? ModifyDate { get; private set; }

        public List<CandidateExperience> CandidateExperiences { get; private set; }

        public Candidate()
        {
            CandidateExperiences = new List<CandidateExperience>();
        }

        public Candidate(
            string name,
            string surname,
            DateTime birthdate,
            string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Birthdate = birthdate;
            Email = email;
            InsertDate = DateTime.Now;
            ModifyDate = null;
            CandidateExperiences = new List<CandidateExperience>();
        }

        public Candidate(
            Guid id,
            string name,
            string surname,
            DateTime birthdate,
            DateTime insertDate,
            string email)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Birthdate = birthdate;
            Email = email;
            InsertDate = insertDate;
            ModifyDate = DateTime.Now;
            CandidateExperiences = new List<CandidateExperience>();
        }

        public void AssignCandidateExperience(CandidateExperience candidateExperience)
        {
            CandidateExperiences.Add(candidateExperience);
        }

        public override string ToString() => $"[ { GetType().Name } - Name: { Name }, Surname: { Surname } ]";
    }
}