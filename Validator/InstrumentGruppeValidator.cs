using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Models;

namespace Validator
{
    public class InstrumentGruppeValidator
    {
        public async Task<bool> checkInstrumentGruppeObject(InstrumentGruppe grp)
        {
            bool placehold = await placeholder();
            return true;
        }
        public async Task<bool> placeholder()
        {
            return true;
        }
    }
}
