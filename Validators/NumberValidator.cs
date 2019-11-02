using SoftwareDesign_lab1.Entities;
using System;

namespace SoftwareDesign_lab1.Validators
{
    class NumberValidator : ValueValidator
    {
        public NumberValidator(Package package) : base(package)
        {
        }
        protected override bool CheckValue(string value)
        {
            return double.TryParse(value, out _);
        }
    }
}
