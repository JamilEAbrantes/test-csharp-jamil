using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace Candidate.Application.Candidate.Commands.DeleteCandidate
{
    public class DeleteCandidateCommand : IRequest<bool>
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid Id { get; set; }
    }
}