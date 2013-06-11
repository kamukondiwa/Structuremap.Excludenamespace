using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap.Configuration.DSL;
using System.Configuration;

namespace Structuremap.Excludenamespace
{
    public class AppRegistry : Registry
    {
        public AppRegistry()
        {
            Scan(x =>
            {
                x.TheCallingAssembly();
                x.WithDefaultConventions();
                x.RegisterConcreteTypesAgainstTheFirstInterface();
                x.Exclude(Exclusions);
                   
            });
        }

        public bool Exclusions(Type type)
        {
            var isAutomationMode = bool.Parse(System.Configuration.ConfigurationManager.AppSettings["isAutomationMode"]);
            var isExcluded = ((isAutomationMode && type.Namespace.EndsWith("production", StringComparison.InvariantCultureIgnoreCase)) ^ (!isAutomationMode && type.Namespace.EndsWith("mock", StringComparison.InvariantCultureIgnoreCase)));
            return false | isExcluded;
        }
    }
}
