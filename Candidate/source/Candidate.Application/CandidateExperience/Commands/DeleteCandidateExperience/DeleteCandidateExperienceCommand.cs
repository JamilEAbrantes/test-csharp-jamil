using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace Candidate.Application.CandidateExperience.Commands.DeleteCandidateExperience
{
    public class DeleteCandidateExperienceCommand : IRequest<bool>
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid Id { get; set; }
    }
}