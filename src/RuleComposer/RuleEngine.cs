using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuleComposer
{
    public class RuleEngine:IRuleEngine
    {
        public T ExecuteRules<T>(T @object)
        {
            IList<ISpecification<T>> SpecificationList= SpecificationScanner.container.GetAllInstances<ISpecification<T>>();
            SpecificationList.ToList().ForEach(p => p.ApplyRules(@object));
            return @object;
        }
    }
}
