using System;
using System.Collections.Generic;
using System.Text;

namespace Validator
{
    class DataTypeValidator
    {
        public bool checkIntInput(string input)
        {
            int parsedVal;
            return int.TryParse(input, out parsedVal);
        }
        public bool checkDateTimeInput(string input)
        {
            DateTime parsedDateTime;
            return DateTime.TryParse(input, out parsedDateTime);
        }
    }
}
