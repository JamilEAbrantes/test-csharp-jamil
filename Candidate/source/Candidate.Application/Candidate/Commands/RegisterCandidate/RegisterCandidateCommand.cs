using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace Candidate.Application.Candidate.Commands.RegisterCandidate
{
    public class RegisterCandidateCommand : IRequest<bool>
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(150, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        [StringLength(250, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Email { get; set; }
    }
}