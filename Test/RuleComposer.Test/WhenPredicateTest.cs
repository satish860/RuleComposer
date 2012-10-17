﻿using System;
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
    public class WhenPredicateTest
    {
        [Test]
        public void Simple_When_is_a_predicate_for_evaluting_the_Condition()
        {
            IRule<Customer> rule = new Rule<Customer>();
            rule.When(p => p.PurchasedAmount >= 10000).Then(p => p.customerType = CustomerType.Premium);
            rule.Execute(new Customer { PurchasedAmount = 100001 }).customerType.Should().Be(CustomerType.Premium);
        }
    }


}
