using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Validator
{
    public class InstrumentValidator
    {
        public bool CheckEmailFormat(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase); ;
        }
        public bool CheckDateTime(DateTime date)
        {
            return date > new DateTime(1880, 1, 1) && date < DateTime.Now;
        }
        public bool CheckStringInput(string str)
        {
            return !string.IsNullOrEmpty(str) && !string.IsNullOrWhiteSpace(str);
        }
        public bool CheckSpecificSymbols(string str, List<char> symbols)
        {
            return str.Any(strChar => symbols.Any(symbolChar => symbolChar == strChar));
        }
        public bool CheckNotLetterOrDigit(string str)
        {
            return str.Any(ch => !char.IsLetterOrDigit(ch));
        }
    }
}
