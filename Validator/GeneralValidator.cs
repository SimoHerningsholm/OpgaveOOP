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
        public bool CheckSpecificSymbols(string str)
        {
            //indeholder strengen nogle bestemte symboler returneres der false
            List<char> symbols = new List<char>() { '(', ')', '.', '/', ',' };
            return str.Any(strChar => symbols.Any(symbolChar => symbolChar == strChar));
        }
        public bool checkInstrumentGruppeObject(InstrumentGruppe grp)
        {
            //Tjekker først om navn er null eller tom
            if (!string.IsNullOrEmpty(grp.Navn))
            {
                //tkekker om navn er et andet tegn end bogstav eller tal
                if (CheckSpecificSymbols(grp.Navn))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            //tjekker om beskrivelse er null eller tom
            if (!string.IsNullOrEmpty(grp.Beskrivelse))
            {
                //tkekker om navn er et andet tegn end bogstav eller tal
                if (CheckSpecificSymbols(grp.Beskrivelse))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        public bool checkInstrumentObject(Instrument inst)
        {
            //tjekker om navn er null eller tom
            if(!string.IsNullOrEmpty(inst.Navn))
            {
                //tkekker om navn er et andet tegn end bogstav eller tal
                if(CheckSpecificSymbols(inst.Navn))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
            if (!string.IsNullOrEmpty(inst.Beskrivelse))//tjekker om beskrivelse er null eller tom
            {
                //tkekker om navn er et andet tegn end bogstav eller tal
                if (CheckSpecificSymbols(inst.Beskrivelse))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            //indkøbsprisen må ikke være mindre end eller lig 0
            if (inst.IndkøbsPris <= 0)
            {
                return false;
            }
            //fortjeneste må ikke være mindre end eller lig 0%
            if(inst.Fortjeneste <= 0)
            {
                return false;
            }
            //Datoen en vare er kommet på lager kan ikke være i fremtiden. Medmindre vi betragter feltet som en vare der kommer på lager i fremtiden
            if(inst.LagerDato > DateTime.Now)
            {
                return false;
            }
            //man kan ikke have under et antal på en vare
            if(inst.Antal < 1)
            {
                return false;
            }
            //Tjekker at producent strengen ikke er null eller tom
            if (!string.IsNullOrEmpty(inst.Producent))
            {
                //tkekker om navn er et andet tegn end bogstav eller tal
                if (CheckSpecificSymbols(inst.Producent))
                {
                    return false;
                }
            }
            else 
            {
                return false;
            }
            return true;
        }
    }
}
