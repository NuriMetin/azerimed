using GeneralIntegration.Application;
using GeneralIntegration.Application.Test.Services.BackgroundServices;
using GeneralIntegration.Application.Test.Services.TimerServices;
using Microsoft.AspNetCore.Mvc;

namespace GeneralIntegration.WebApp.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestTimerService _testTimerService;
        public TestController(ITestTimerService testTimerService)
        {
            _testTimerService = testTimerService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ForGuid.GUID_CONTROLLER = Guid.NewGuid().ToString();
            return Json(new {status = 200});
        }
    }
}
