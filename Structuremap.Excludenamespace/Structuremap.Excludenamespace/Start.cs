using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;

namespace Structuremap.Excludenamespace
{
    public class Start
    {
        private string whatDoIHave;

        public Start()
        {
            ObjectFactory.Initialize(x =>
            {
                x.IncludeRegistry<AppRegistry>();
            });

            whatDoIHave = ObjectFactory.WhatDoIHave();
        }

        public string WhatDoIHave { get { return this.whatDoIHave; } }
    }
}
