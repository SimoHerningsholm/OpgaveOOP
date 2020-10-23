using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Models;

namespace BL
{
    public interface IInstrumentRepo
    {
        Task<bool> OpretInstrumentAsync(Instrument instrument);
        Task<List<Instrument>> HentInstrumenterAsync(int VareGruppe);
        Task<Instrument> HentInstrumentAsync(int vareNummer);
        Task<bool> OpdaterInstrumentAsync(Instrument instrument);
        Task<bool> SletInstrumentAsync(int id);
    }
}
