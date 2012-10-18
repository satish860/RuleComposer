using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleComposer
{
    public interface ISpecification<T>
    {
        T ApplyRules(T @object);

        IRule<T> When(Predicate<T> Condition);
    }
}
