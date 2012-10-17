using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuleComposer
{
    public interface IRule<T>
    {
        IRule<T> When(Predicate<T> condition);

        void Then(Action<T> action);

        T Execute(T @object);
    }
}
