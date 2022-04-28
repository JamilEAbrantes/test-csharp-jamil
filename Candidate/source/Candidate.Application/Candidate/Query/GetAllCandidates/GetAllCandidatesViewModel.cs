using System;

namespace Candidate.Application.Candidate.Query.GetAllCandidates
{
    public class GetAllCandidatesViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime Birthdate { get; set; }

        public string Email { get; set; }
    }
}
