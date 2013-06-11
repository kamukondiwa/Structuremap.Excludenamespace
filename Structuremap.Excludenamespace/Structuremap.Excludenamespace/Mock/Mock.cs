using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structuremap.Excludenamespace.Mock
{
    public class Mock : IMock
    {
        public string Stub()
        {
            return "Stub";
        }
    }
}
