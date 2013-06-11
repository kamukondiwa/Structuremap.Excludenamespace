using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structuremap.Excludenamespace.Production
{
    public class Production : IProduction
    {
        public string DoWork()
        {
            return "DoWork";
        }
    }
}
