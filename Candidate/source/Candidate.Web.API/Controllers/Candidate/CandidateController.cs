using Candidate.Application.Candidate.Commands.DeleteCandidate;
using Candidate.Application.Candidate.Commands.RegisterCandidate;
using Candidate.Application.Candidate.Commands.UpdateCandidate;
using Candidate.Application.Candidate.Query.GetAllCandidates;
using Candidate.Application.Candidate.Query.GetCandidate;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Candidate.Web.API.Controllers.Candidate
{
    [ApiController]
    [Route("v1/candidate")]
    public class CandidateController : MainController
    {
        private readonly IMediator _mediator;

        public CandidateController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [AllowAnonymous]
        [HttpGet, Route("all")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult GetAll()
        {
            var query = new GetAllCandidatesQuery();
            var candidatesViewModel = _mediator.Send(query);

            return Ok(candidatesViewModel);
        }

        [AllowAnonymous]
        [HttpGet, Route("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult Get(Guid id)
        {
            var query = new GetCandidateQuery() { Id = id };
            var candidateViewModel = _mediator.Send(query);

            return Ok(candidateViewModel);
        }

        [AllowAnonymous]
        [HttpPost, Route("register")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult RegisterCandidate([FromBody] RegisterCandidateCommand registerCandidateCommand)
        {
            if (!ModelState.IsValid) return View(registerCandidateCommand);

            _mediator.Send(registerCandidateCommand);

            return StatusCode(201);
        }

        [AllowAnonymous]
        [HttpPut, Route("update")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult UpdateCandidate([FromBody] UpdateCandidateCommand updateCandidateCommand)
        {
            if (!ModelState.IsValid) return View(updateCandidateCommand);

            _mediator.Send(updateCandidateCommand);

            return StatusCode(200);
        }

        [AllowAnonymous]
        [HttpDelete, Route("delete")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult DeleteCandidate([FromBody] DeleteCandidateCommand deleteCandidateCommand)
        {
            if (!ModelState.IsValid) return View(deleteCandidateCommand);

            _mediator.Send(deleteCandidateCommand);

            return StatusCode(200);
        }
    }
}