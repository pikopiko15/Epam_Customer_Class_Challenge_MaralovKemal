using System;

/*
 * Customer class has three public properties - Name (string),
 * ContactPhone (string) and Revenue (decimal).
 * Implement for the Customer's objects the capability of a various string representation.
 * For example, the object with the Name = "Jeffrey Richter", Revenue = 1000000,
 * ContactPhone = "+1 (425) 555-0100" can have the following string representation:
   - Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100
   - Customer record: +1 (425) 555-0100
   - Customer record: Jeffrey Richter, 1,000,000.00
   - Customer record: Jeffrey Richter
   - Customer record: 1000000, etc. 
Add to Customer class an additional formatting capability, that is not provided by the class 
(Customer class do not change). Develop unit tests.
 */

namespace Epam_Customer_Class_Challenge_MaralovKemal
{
    public class Customer
    {
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public decimal Revenue { get; set; }

        public Customer(string name, string phone, decimal revenue)
        {
            Name = name;
            ContactPhone = phone;
            Revenue = revenue;
        }

        public override string ToString()
        {
            return ToString("G");
        }

        public string ToString(string fmt)
        {
            if (string.IsNullOrEmpty(fmt))
                fmt = "G";

            switch (fmt.ToUpperInvariant())
            {
                case "G":
                    return string.Format("- Customer Record: {0}, {1:N0}.00, {2}", Name, Revenue, ContactPhone);
                case "D":
                    return string.Format("- Customer Record: {0}", ContactPhone);
                case "C":
                    return string.Format("- Customer Record: {0}, {1:N0}.00", Name, Revenue);
                case "A":
                    return string.Format("- Custome Record: {0}", Name);
                case "B":
                    return string.Format("- Custome Record: {0}, etc", Revenue);
                default:
                    string msg = string.Format("'{0}' is an invalid format string",
                                               fmt);
                    throw new ArgumentException(msg);
            }
        }
    }
}
