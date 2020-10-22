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
            //Tjekker først om navn er null eller tom
            if (CheckStringInput(grp.Navn))
            {
                //Tjekker dernæst om der er et tegn der ikke er et bogstav eller et tal
                if (CheckNotLetterOrDigit(grp.Navn))
                {
                    return false;
                }
            }
            //tjekker om beskrivelse er null eller tom
            if (CheckStringInput(grp.Beskrivelse))
            {
                //tjekker om der er tegn der ikke er bogstav eller tal
                if (CheckNotLetterOrDigit(grp.Beskrivelse))
                {
                    return false;
                }
            }
            return true;
        }
        public bool checkInstrumentObject(Instrument inst)
        {
            //tjekker om navn er null eller tom
            if(CheckStringInput(inst.Navn))
            {
                //tkekker om navn er et andet tegn end bogstav eller tal
                if(CheckNotLetterOrDigit(inst.Navn))
                {
                    return false;
                }
            }
            //tjekker om beskrivelse er null eller tom
            if(CheckStringInput(inst.Beskrivelse))
            {
                //tjekker om der er tegn der ikke er bogstav eller tal
                if(CheckNotLetterOrDigit(inst.Beskrivelse))
                {
                    return false;
                }
            }
            //indkøbsprisen må ikke være mindre end eller lig 0
            if(inst.IndkøbsPris <= 0)
            {
                return false;
            }
            //fortjeneste må ikke være mindre end eller lig 0%
            if(inst.Fortjeneste <= 0)
            {
                return false;
            }
            //Datoen en vare er kommet på lager kan ikke være i fremtiden. Medmindre vi betragter feltet som en vare der kommer på lager i fremtiden
            if(CheckLagerDato(inst.LagerDato))
            {
                return false;
            }
            //man kan ikke have under et antal på en vare
            if(inst.Antal < 1)
            {
                return false;
            }
            //Tjekker at producent strengen ikke er null eller tom
            if(CheckStringInput(inst.Producent))
            {
                //tjekker der ikke er tegn der ikke skal være der
                if (CheckNotLetterOrDigit(inst.Navn))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
