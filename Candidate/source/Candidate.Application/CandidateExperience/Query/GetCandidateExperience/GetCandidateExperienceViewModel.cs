﻿using System;

namespace Candidate.Application.CandidateExperience.Query.GetCandidateExperience
{
    public class GetCandidateExperienceViewModel
    {
        public Guid Id { get; set; }

        public string Company { get; private set; }

        public string Job { get; private set; }

        public string Description { get; private set; }

        public decimal Salary { get; private set; }

        public DateTime BeginDate { get; private set; }

        public DateTime? EndDate { get; private set; }

        public Guid CandidateId { get; private set; }
    }
}