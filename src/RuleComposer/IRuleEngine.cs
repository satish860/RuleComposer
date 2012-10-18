using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuleComposer
{
    public interface IRuleEngine
    {
        T ExecuteRules<T>(T @object);
    }
}
