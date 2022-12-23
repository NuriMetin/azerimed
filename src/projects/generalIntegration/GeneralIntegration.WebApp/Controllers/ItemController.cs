using GeneralIntegration.Application;
using GeneralIntegration.Application.Item.TimerServices;
using GeneralIntegration.Application.Test.Services.TimerServices;
using Microsoft.AspNetCore.Mvc;

namespace GeneralIntegration.WebApp.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemTimerService _itemTimerService;
        public ItemController(IItemTimerService itemTimerService)
        {
            _itemTimerService = itemTimerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ForGuid.GUID_CONTROLLER_I = Guid.NewGuid().ToString();
            return Json(new { status = 200 });
        }
    }
}