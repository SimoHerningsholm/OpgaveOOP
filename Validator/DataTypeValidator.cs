using System;
using System.Collections.Generic;
using System.Text;

namespace Validator
{
    public class DataTypeValidator
    {
        public bool CheckIntInput(string input)
        {
            int parsedVal;
            //Returnere true hvis den kan parse string input til parsedVal datatype
            return int.TryParse(input, out parsedVal);
        }
        public bool CheckDoubleInput(string input)
        {
            double parsedVal;
            //Returnere true hvis den kan parse string input til parsedVal datatype
            return double.TryParse(input, out parsedVal);
        }
        public bool CheckDateTimeInput(string input)
        {
            DateTime parsedDateTime;
            //Returnere true hvis den kan parse string input til parsedVal datatype
            return DateTime.TryParse(input, out parsedDateTime);
        }
        public bool CheckValideringResultater(List<bool> inValideringsBools)
        {
            //Iterere igennem valideringresultatliste
            for (int i = 0; i < inValideringsBools.Count; i++)
            {
                //Er der én validering der ikke er gået igennem så returneres der false
                if(inValideringsBools[i] == false)
                {
                    return false;
                }
            }
            //Er den kommet successfuldt gennem listen returneres der true
            return true;
        }
    }
}
