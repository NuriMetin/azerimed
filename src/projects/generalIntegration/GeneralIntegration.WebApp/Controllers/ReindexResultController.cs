using GeneralIntegration.Application.ReindexResult.Dtos;
using Core.Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using GeneralIntegration.Application.ReindexResult.Queries;
using GeneralIntegration.Application.ReindexResult.Services.TimerServices;
using GeneralIntegration.Application.ReindexResult.Services.BackgroundServices;

namespace GeneralIntegration.WebApp.Controllers
{
    public class ReindexResultController : BaseController
    {
        private readonly IReindexResultTimerService _reindexResultTimerService;
        private readonly IReindexResultBackgroundService _reindexResultBackgroundService;

        public ReindexResultController(IReindexResultBackgroundService reindexResultBackgroundService, IReindexResultTimerService reindexResultTimerService)
        {
            _reindexResultBackgroundService = reindexResultBackgroundService;
            _reindexResultTimerService = reindexResultTimerService;
        }

        public async Task<IActionResult> Index()
        {
            GetReindexResultByBaseNameAndDateQuery getReindexResultByBaseNameAndDateQuery = new() { BaseName = "LOGO", Date = DateTime.Now };
            Response<ReindexResultDto> reindexResult = await Mediator.Send(getReindexResultByBaseNameAndDateQuery);
            return View();
        }

        public async Task<IActionResult> Timer()
        {
            //await _reindexResultBackgroundService.InvokeServiceAsync();
            await _reindexResultTimerService.InvokeTimerByInterval(_reindexResultBackgroundService,TimeSpan.FromSeconds(10));

            return Ok();
        }
    }
}
