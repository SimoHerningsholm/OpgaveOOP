using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Models;

namespace Validator
{
    public class GeneralValidator
    {
        public bool CheckLagerDato(DateTime LagerDato)
        {
            //Hvis dato den er kommet på lager er større end nuværende dato er der tale om en fejl
            return LagerDato > DateTime.Now;
        }
        public bool CheckStringInput(string str)
        {
            //En input string kan ikke være null eller tom
            return !string.IsNullOrEmpty(str);
        }
        public bool CheckSpecificSymbols(string str)
        {
            //indeholder strengen nogle bestemte symboler returneres der false
            List<char> symbols = new List<char>() { '(', ')', '.' };
            return str.Any(strChar => symbols.Any(symbolChar => symbolChar == strChar));
        }
        public bool CheckNotLetterOrDigit(string str)
        {
            //Hvis der er en char i strengen der ikke er et bogstav eller tal er der inputtet noget forkert
            return str.Any(ch => !char.IsLetterOrDigit(ch));
        }
        public bool checkInstrumentGruppeObject(InstrumentGruppe grp)
        {

            if (CheckStringInput(grp.Navn))
            {
                if (CheckNotLetterOrDigit(grp.Navn))
                {
                    return false;
                }
            }
            if (CheckStringInput(grp.Beskrivelse))
            {
                if (CheckNotLetterOrDigit(grp.Beskrivelse))
                {
                    return false;
                }
            }
            return true;
        }
        public bool checkInstrumentObject(Instrument inst)
        {
            if(CheckStringInput(inst.Navn))
            {
                if(CheckNotLetterOrDigit(inst.Navn))
                {
                    return false;
                }
            }
            if(CheckStringInput(inst.Beskrivelse))
            {
                if(CheckNotLetterOrDigit(inst.Beskrivelse))
                {
                    return false;
                }
            }
            if(inst.IndkøbsPris < 1)
            {
                return false;
            }
            if(inst.Fortjeneste <= 0)
            {
                return false;
            }
            if(CheckLagerDato(inst.LagerDato))
            {
                return false;
            }
            if(inst.Antal < 1)
            {
                return false;
            }
            if(CheckStringInput(inst.Producent))
            {
                if (CheckNotLetterOrDigit(inst.Navn))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
