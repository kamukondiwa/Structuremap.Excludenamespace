using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structuremap.Excludenamespace
{
    public class MainService : IMainService
    {
        public string Foo()
        {
            return "Foo";
        }
    }
}
