using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RuleComposer;
using NUnit.Framework;
using FluentAssertions;

namespace RuleComposer.Test
{
    [TestFixture]
    public class RuleEngineTest
    {
        [Test]
        public void Should_Apply_all_the_Rule_and_execute()
        {
            SpecificationScanner.ScanSpecificationInAssembly<CustomerSpecification>();
            IRuleEngine ruleEngine = new RuleEngine();
            ruleEngine.ExecuteRules<Customer>(new Customer { PurchasedAmount = 100001 }).customerType.Should().Be(CustomerType.Premium);
        }
    }
}
