using SoftwareDesign_lab1.Entities;
using System;

namespace SoftwareDesign_lab1.Validators
{
    class IntegerValidator : ValueValidator
    {
        public IntegerValidator(Package package) : base(package)
        {
        }
        protected override bool CheckValue(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}
