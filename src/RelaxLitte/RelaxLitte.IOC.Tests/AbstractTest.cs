using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelaxLittle.IOC.Tests
{
    internal abstract class AbstractTest
    {
        internal abstract void Run();
    }

    internal class Test : AbstractTest
    {
        internal override void Run()
        {
            throw new NotImplementedException();
        }
    }
}
