using System;
using System.Xml.Linq;

namespace CourseAssignment
{
	public class Budget
	{
        private string Name;
		private decimal Amount;

        public Budget()
		{
            
        }

        public Budget(string name, decimal amount)
        {
            Name = name;
            Amount = amount;
        }

        public string GetName()
		{
			return Name;
		}

        public void SetName(string name)
        {
            Name = name;
        }

        public decimal GetAmount()
        {
            return Amount;
        }

        public void SetAmount(decimal amount)
        {
            Amount = amount;
        }
    }
}

