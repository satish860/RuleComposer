using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace RuleComposer.Test
{
    [TestFixture]
    public class SpecificationTest
    {
        [Test]
        public void Should_Compose_rule_and_Apply_All()
        {
            CustomerSpecification specification = new CustomerSpecification();
            specification.ApplyRules(new Customer { PurchasedAmount = 10001 }).customerType.Should().Be(CustomerType.Premium);
        }
    }
}
