using Candidate.Application.CandidateExperience.Commands.DeleteCandidateExperience;
using Candidate.Application.CandidateExperience.Commands.RegisterCandidateExperience;
using Candidate.Application.CandidateExperience.Commands.UpdateCandidateExperience;
using Candidate.Application.CandidateExperience.Query.GetAllCandidateExperiences;
using Candidate.Application.CandidateExperience.Query.GetCandidateExperience;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Candidate.Web.MVC.Controllers
{
    public class CandidateExperienceController : Controller
    {
        private readonly ILogger<CandidateExperienceController> _logger;
        private readonly IMediator _mediator;

        public CandidateExperienceController(ILogger<CandidateExperienceController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public IActionResult Experiences(Guid id)
        {
            TempData["CandidateId"] = id;

            var query = new GetAllCandidateExperiencesQuery() { CandidateId = id };

            var candidateExperienceViewModel = _mediator.Send(query).Result;

            return View(candidateExperienceViewModel);
        }

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var query = new GetCandidateExperienceQuery() { Id = id };

            var candidateExperienceViewModel = _mediator.Send(query).Result;

            return View(candidateExperienceViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] RegisterCandidateExperienceCommand registerCandidateExperienceCommand)
        {
            if (!ModelState.IsValid) return View(registerCandidateExperienceCommand);

            _mediator.Send(registerCandidateExperienceCommand);

            return RedirectToAction("Experiences", new { id = registerCandidateExperienceCommand.CandidateId });
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var query = new GetCandidateExperienceQuery() { Id = id };

            var candidateExperienceViewModel = _mediator.Send(query).Result;

            return View(candidateExperienceViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind] UpdateCandidateExperienceCommand updateCandidateExperienceCommand)
        {
            if (!ModelState.IsValid) return View(updateCandidateExperienceCommand);

            _mediator.Send(updateCandidateExperienceCommand);

            return RedirectToAction("Experiences", new { id = updateCandidateExperienceCommand.CandidateId });
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var query = new GetCandidateExperienceQuery() { Id = id };

            var candidateExperienceViewModel = _mediator.Send(query).Result;

            return View(candidateExperienceViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(DeleteCandidateExperienceCommand deleteCandidateExperienceCommand)
        {
            if (!ModelState.IsValid) return View(deleteCandidateExperienceCommand);

            _mediator.Send(deleteCandidateExperienceCommand);

            return RedirectToAction("Experiences", new { id = TempData["CandidateId"] });
        }
    }
}