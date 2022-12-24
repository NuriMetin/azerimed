using lObjectIntegration.Application.GeneralIntegration;
using Microsoft.AspNetCore.Mvc;

namespace lObjectIntegration.WebApi.Controllers.GeneralIntegration
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly TestApp _testApp;

        public TestController(TestApp testApp)
        {
            _testApp = testApp;
        }

        [HttpGet(Name = "Index")]
        public async Task<string> Index()
        {
            string result;
            try
            {
                _testApp.Foo();
                result = "success";
            }

            catch (Exception exp)
            {
                result = exp.Message;
            }

            return  result;
        }
    }
}
