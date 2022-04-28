using Candidate.Application.Candidate.Commands.DeleteCandidate;
using Candidate.Application.Candidate.Commands.RegisterCandidate;
using Candidate.Application.Candidate.Commands.UpdateCandidate;
using Candidate.Application.Candidate.Query.GetAllCandidates;
using Candidate.Application.Candidate.Query.GetCandidate;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Candidate.Web.MVC.Controllers
{
    public class CandidateController : Controller
    {
        private readonly ILogger<CandidateController> _logger;
        private readonly IMediator _mediator;

        public CandidateController(IMediator mediator, ILogger<CandidateController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var query = new GetAllCandidatesQuery();

            var candidatesViewModel = _mediator.Send(query).Result;

            return View(candidatesViewModel);
        }

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var query = new GetCandidateQuery() { Id = id };

            var candidateViewModel = _mediator.Send(query).Result;

            return View(candidateViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] RegisterCandidateCommand registerCandidateCommand)
        {
            if (!ModelState.IsValid) return View(registerCandidateCommand);

            _mediator.Send(registerCandidateCommand);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var query = new GetCandidateQuery() { Id = id };

            var candidateViewModel = _mediator.Send(query).Result;

            return View(candidateViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind]UpdateCandidateCommand updateCandidateCommand)
        {
            if (!ModelState.IsValid) return View(updateCandidateCommand);

            _mediator.Send(updateCandidateCommand);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var query = new GetCandidateQuery() { Id = id };

            var candidateViewModel = _mediator.Send(query).Result;

            return View(candidateViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(DeleteCandidateCommand deleteCandidateCommand)
        {
            if (!ModelState.IsValid) return View(deleteCandidateCommand);

            _mediator.Send(deleteCandidateCommand);

            return RedirectToAction("Index");
        }
    }
}
