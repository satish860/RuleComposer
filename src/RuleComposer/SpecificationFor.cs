using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleComposer
{
    public class SpecificationFor<T>:ISpecification<T>
    {
        List<IRule<T>> SpecificationRules;
        public SpecificationFor()
        {
            SpecificationRules = new List<IRule<T>>();
        }

        public T ApplyRules(T @object)
        {
            SpecificationRules.ForEach(p => p.Execute(@object));
            return @object;
        }

        public IRule<T> When(Predicate<T> Condition)
        {
            IRule<T> rule = new Rule<T>();
            rule.When(Condition);
            return rule;
        }
    }
}
