using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuleComposer.Test
{
    public class CustomerSpecification:SpecificationFor<Customer>
    {
        public CustomerSpecification()
        {
            When(p => p.PurchasedAmount >= 100001).Then(p => p.customerType = CustomerType.Premium);
        }
    }
}
