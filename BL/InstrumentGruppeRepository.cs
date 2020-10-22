using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Models;
using DL;
using Validator;
namespace BL
{
    public class InstrumentGruppeRepository : IInstrumentGruppeRepo
    {
        //Deklarere en instrumentdatahandler samt en instrumentvalidator
        InstrumentGruppeDataHandler dataHandler;
        public InstrumentGruppeRepository()
        {
            //Instancierer en instrumentdatahandler samt en instrumentvalidator
            dataHandler = new InstrumentGruppeDataHandler();
        }
        public async Task<bool> OpretInstrumentGruppeAsync(InstrumentGruppe gruppe)
        {
            await Task.Delay(5000);
            GeneralValidator val = new GeneralValidator();
            //Tjekker om metoden har modtaget et gyldigt instrumentgruppe objekt
            if (val.checkInstrumentGruppeObject(gruppe))
            {
                //kalder OpretInstrumentAsync metoden på datahandler objektet med instrument som argument og returnere hvorvidt oprettelsen har været successfuld
                return await dataHandler.OpretInstrumentGruppeAsync(gruppe);
            }
            //Har metoden ikke modtaget et gyldigt instrument returnere den false
            return false;
        }
        public async Task<List<InstrumentGruppe>> HentInstrumentGrupperAsync()
        {
         //   await Task.Delay(5000);
            //kalder HentAlleInstrumentGrupperAsync metoden på datahandler objektet
            //har den hentet alle instrumentGrupper successfuldt returnere den liste over instrumentgrupper. Hvis ikke returnere den null.
            return await dataHandler.HentAlleInstrumentGrupperAsync();
        }
        public async Task<InstrumentGruppe> HentInstrumentGruppeAsync(int id)
        {
            await Task.Delay(5000);
            //kalder HentAlleInstrumentAsync metoden på datahandler objektet
            //har den hentet instrumentgruppe successfuldt returnere den instrumentergruppe. Hvis ikke returnere den null.
            return await dataHandler.HentInstrumentGruppeAsync(id);
        }

    }
}
