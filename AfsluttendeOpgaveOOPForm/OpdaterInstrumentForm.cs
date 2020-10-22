using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Validator;
using BL;

namespace AfsluttendeOpgaveOOPForm
{
    public partial class OpdaterInstrumentForm : Form
    {
        //opdaterformen skal bruge et instrument at opdatere på samt et gruppeid som instrumentet tilhøre for at opdatere instrumentet i den rigtige varegruppe kategori
        Form prevForm;
        Instrument instrument;
        int gruppeId;
        public OpdaterInstrumentForm()
        {
            InitializeComponent();
        }
        public OpdaterInstrumentForm(Form inPrevForm, Instrument inInstrument, int inGruppeId)
        {
            //sætter variabler der skal bruges af formen
            InitializeComponent();
            prevForm = inPrevForm;
            instrument = inInstrument;
            gruppeId = inGruppeId;
            loadTextBokse();
            fyldProducentCombo();
            ProducentCombo.SelectedIndex = 0;
        }

        private async void OpdaterInstrumentBtn_Click(object sender, EventArgs e)
        {
            bool opdaterFejl = false;
            string fejlMeddelelse = string.Empty;
            InstrumentRepository instRep = new InstrumentRepository();
            Instrument opdateretInstrument = new Instrument();
            //Sætter properties som er string og derfor kun skal valideres på indhold i repository
            opdateretInstrument.VareNummer = instrument.VareNummer;
            opdateretInstrument.Navn = InstrumentNavnTxt.Text;
            opdateretInstrument.Beskrivelse = InstrumentBeskrivelseTxt.Text;
            opdateretInstrument.Producent = ProducentCombo.SelectedText;
            opdateretInstrument.VareGruppe = gruppeId;
            //Der valideres på om der er problemer med at konvertere de modtagne input til de nødvendige datatyper.. Dette kan eventuelt laves smartere og eksternt
            //Er der et problem med konvertering lagres en fejlmeddelelse og opdaterfejl sættes til true.
            try
            {
                opdateretInstrument.IndkøbsPris = Convert.ToDouble(InstrumentIndkøbsPrisTxt.Text);
            }
            catch
            {
                opdaterFejl = true;
                fejlMeddelelse = "Indkøbspris var ikke et tal ";
            }
            try
            {
                opdateretInstrument.Fortjeneste = Convert.ToDouble(InstrumentFortjenesteTxt.Text);
            }
            catch
            {
                opdaterFejl = true;
                fejlMeddelelse += "Fortjeneste var ikke et tal ";
            }
            try
            {
                opdateretInstrument.LagerDato = Convert.ToDateTime(Convert.ToDateTime(InstrumentLagerDato.Text));
            }
            catch
            {
                opdaterFejl = true;
                fejlMeddelelse += "Lagerdato vare ikke en dato ";
            }
            try
            {
                opdateretInstrument.Antal = int.Parse(InstrumentAntalTxt.Text);
            }
            catch
            {
                opdaterFejl = true;
                fejlMeddelelse += "Antal var ikke et tal ";
            }
            if(opdaterFejl == false)
            {
                if(await instRep.OpdaterInstrumentAsync(opdateretInstrument))
                {
                    this.Hide();
                    prevForm.Show();
                }
                else
                {
                    StatusLabel.Text = "Der var problemer ved eksekvering mod databasen";
                }
            }
            else
            {
                 StatusLabel.Text = fejlMeddelelse;
            }
        }
        public void loadTextBokse()
        {
            //Sætter tekstbokse til at have properties på det indkomne instrument objekt
            InstrumentNavnTxt.Text = instrument.Navn;
            InstrumentBeskrivelseTxt.Text = instrument.Beskrivelse;
            InstrumentIndkøbsPrisTxt.Text = instrument.IndkøbsPris.ToString();
            InstrumentFortjenesteTxt.Text = instrument.Fortjeneste.ToString();
            InstrumentLagerDato.Value = instrument.LagerDato;
            InstrumentAntalTxt.Text = instrument.Antal.ToString();
            ProducentCombo.Text = instrument.Producent.ToString();
        }

        private void TilbageBtn_Click(object sender, EventArgs e)
        {
            //går man tilbage skjules denne form og den tidligere vises
            this.Hide();
            prevForm.Show();
        }
        private void fyldProducentCombo()
        {
            //Fylder combobokse med producenter
            ProducentCombo.Items.Add("Yamaha");
            ProducentCombo.Items.Add("Ibanez");
            ProducentCombo.Items.Add("Pearl");
            ProducentCombo.Items.Add("Korg");
            ProducentCombo.Items.Add("Gibson");
            ProducentCombo.Items.Add("Tama");
        }
    }
}
