using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using StructureMap;

namespace RuleComposer.Test
{
    [TestFixture]
    public class SpecificationScannerTest
    {
        [Test]
        public void Should_be_able_to_Scan_for_the_Specification_and_Register()
        {
            SpecificationScanner.ScanSpecificationInAssembly<CustomerSpecification>();
            var Specification=SpecificationScanner.container.GetInstance<ISpecification<Customer>>();
            Specification.Should().BeOfType<CustomerSpecification>();
        }
    }
}
