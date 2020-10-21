using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Models;
namespace BL
{
    public interface IInstrumentGruppeRepo
    {
        Task<bool> OpretInstrumentGruppeAsync(InstrumentGruppe gruppe);
        Task<List<InstrumentGruppe>> HentInstrumentGrupperAsync();
    }
}
