using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleComposer
{
    public class SpecificationScanner
    {
        public static IContainer container;

        public static void ScanSpecificationInAssembly<T>()
        {
            container = container ?? new Container();
            container.Configure(p => p.Scan(Scanner =>
            {
                Scanner.AssemblyContainingType<T>();
                Scanner.ConnectImplementationsToTypesClosing(typeof(ISpecification<>));
            }));
        }
    }
}
