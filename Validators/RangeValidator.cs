using System;
using SoftwareDesign_lab1.Entities;

namespace SoftwareDesign_lab1.Validators
{
    class RangeValidator : ValueValidator
    {
        private readonly int _leftBound;
        private readonly int _rightBound;

        public RangeValidator(Package package, int leftBound, int rightBound) : base(package)
        {
            _leftBound = leftBound;
            _rightBound = rightBound;
        }

        protected override bool CheckValue(string value)
        {
            int intValue;

            if (int.TryParse(value, out intValue))
            {
                return intValue >= _leftBound && intValue <= _rightBound;
            }

            return false;
        }
    }
}
