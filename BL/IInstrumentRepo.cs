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
        Task<List<Instrument>> HentInstrumenterAsync();
        Task<Instrument> HentInstrumentAsync(int id);
        Task<bool> OpdaterInstrumentAsync(Instrument instrument);
        Task<bool> SletInstrumentAsync(int id);
    }
}
