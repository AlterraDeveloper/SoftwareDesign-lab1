using SoftwareDesign_lab1.Entities;

namespace SoftwareDesign_lab1.Validators
{
    class RangeValidator : ValueValidator
    {
        private int _leftBound, _rightBound;
        public RangeValidator(Package package) : base(package)
        {
            _leftBound = 0;
            _rightBound = 0;
        }

        public RangeValidator(Package package, int leftBound, int rightBound) : base(package)
        {
            _leftBound = leftBound;
            _rightBound = rightBound;
        }

        protected override bool CheckValue(string value)
        {
            int intValue = 0;

            if (int.TryParse(value, out intValue))
            {
                return intValue >= _leftBound && intValue <= _rightBound;
            }

            return false;
        }
    }
}
