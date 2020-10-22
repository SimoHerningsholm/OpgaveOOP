using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Models;
using DL;
using Validator;

namespace BL
{
    public class InstrumentRepository : IInstrumentRepo //Impementere IInstrumentRepo interface
    {
        //Deklarere en instrumentdatahandler samt en instrumentvalidator
        InstrumentDataHandler dataHandler;
        GeneralValidator val;
        public InstrumentRepository()
        {
            //Instancierer en instrumentdatahandler samt en instrumentvalidator
            dataHandler = new InstrumentDataHandler();
            val = new GeneralValidator();
        }
        public async Task<bool> OpretInstrumentAsync(Instrument instrument)
        {
            //  await Task.Delay(5000);
            //Tjekker om felter er sat på objektet
            GeneralValidator val = new GeneralValidator();
            //Tjekker om der er tale om et gyldigt instrument
            if (val.checkInstrumentObject(instrument))
            {
               //kalder OpretInstrumentAsync metoden på datahandler objektet med instrument som argument og returnere hvorvidt oprettelsen har været successfuld
                return await dataHandler.OpretInstrumentAsync(instrument);
            }
            else
            {
                //Går den ikke gennem valiering returneres der false
                return false;
            }
        }
        public async Task<List<Instrument>> HentInstrumenterAsync(int VareGruppe)
        {
          //  await Task.Delay(5000);
            //kalder HentAlleInstrumentAsync metoden på datahandler objektet
            //har den hentet alle instrumenter successfuldt returnere den liste over instrumenter. Hvis ikke returnere den null.
            return await dataHandler.HentInstrumenterAsync(VareGruppe);
        }
        public async Task<Instrument> HentInstrumentAsync(int vareNummer)
        {
          //  await Task.Delay(5000);
            //kalder HentInstrumentAsync metoden på datahandler objektet med vareNummer som argument
            //har den hentet et instrument successfuldt returnere den instrumentet. Hvis ikke returnere den null.
            return await dataHandler.HentInstrumentAsync(vareNummer);
        }
        public async Task<bool> OpdaterInstrumentAsync(Instrument instrument)
        {
            // await Task.Delay(5000);
            //Tjekker om felter er sat på objektet
            GeneralValidator val = new GeneralValidator();
            //Tjekker om der er tale om et gyldigt instrument
            if(val.checkInstrumentObject(instrument))
            {            
                //kalder OpdaterInstrumentAsync metoden på datahandler objektet med instrument som argument og returnere hvorvidt opdatering har været successfuld
                return await dataHandler.OpdaterInstrumentAsync(instrument);
            }
            else
            {
                //Går den ikke igennem returneres der false
                return false;
            }
        }
        public async Task<bool> SletInstrumentAsync(int vareNummer)
        {
          //  await Task.Delay(5000);
            //kalder SletInstrumentAsync metoden på datahandler objektet med varenummer som argument og returnere hvorvidt sletningen har været successfuld 
            return await dataHandler.SletInstrumentAsync(vareNummer);
        }
    }
}
