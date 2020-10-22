using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Validator
{
    public class KonverterValidator
    {
        public double DoubleConverter(string str)
        {
            try
            {
                return Convert.ToDouble(str);
            }
            catch
            {
                return 0;
            }
        }
        public int IntConverter(string str)
        {
            try
            {
                return Convert.ToInt32(str);
            }
            catch
            {
                return 0;
            }
        }
        public DateTime DateTimeConverter(string str)
        {
            try
            {
                return Convert.ToDateTime(str);
            }
            catch
            {
                return new DateTime(1,1,1);
            }
        }
    }
}
