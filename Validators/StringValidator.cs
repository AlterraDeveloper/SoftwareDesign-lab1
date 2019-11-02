using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareDesign_lab1.Entities;

namespace SoftwareDesign_lab1.Validators
{
    class StringValidator : ValueValidator
    {
        public StringValidator(Package package) : base(package)
        {
        }

        protected override bool CheckValue(string value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }
}
