using System;
using System.Collections.Generic;

namespace CarConstructorGame.Entities
{
    public class Age: ValueObject
    {
        private Age() { }
        public Age(int value)
        {
            if (!IsValid(value))
            {
                throw new ArgumentException("Age is not valid");
            }
            Value = value;
        }

        public int Value { get; private set; }

        public static bool IsValid(int value)
        {
            return 10 <= value && value <= 120;
        }
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
