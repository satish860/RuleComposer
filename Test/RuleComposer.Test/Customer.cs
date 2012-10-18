using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuleComposer.Test
{
    public class Customer
    {
        public double PurchasedAmount { get; set; }

        public CustomerType customerType { get; set; }
    }

    public enum CustomerType
    {
        Premium,
        Normal
    }
}
