using lObjectIntegration.Infrastructure.Core.LObjectConnections;
using lObjectIntegration.Infrastructure.GeneralIntegration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lObjectIntegration.Application.GeneralIntegration
{
    public class TestApp
    {
        private readonly TestDal _testDal;
        public TestApp(TestDal testDal)
        {
            _testDal = testDal;
        }

        public void Foo()
        {
            _testDal.Foo();
        }
    }
}
