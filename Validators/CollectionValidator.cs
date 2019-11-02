using System.Linq;
using SoftwareDesign_lab1.Entities;

namespace SoftwareDesign_lab1.Validators
{
    public class CollectionValidator : ValueValidator
    {
        private readonly string[] _collection;

        public CollectionValidator(Package package, string[] collection) : base(package)
        {
            _collection = collection;
        }

        protected override bool CheckValue(string value)
        {
            return _collection.Contains(value);
        }
    }
}