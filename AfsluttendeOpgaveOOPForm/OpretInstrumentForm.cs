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
using BL;
using Validator;

namespace AfsluttendeOpgaveOOPForm
{
    public partial class OpretInstrumentForm : Form
    {
        private VisInstrumenterForm prevForm;
        private int vareGruppe;
        public OpretInstrumentForm(VisInstrumenterForm inPrevForm, int inVareGruppe)
        {
            InitializeComponent();
            prevForm = inPrevForm;
            vareGruppe = inVareGruppe;
            FyldProducentCombo();
            ProducentCombo.SelectedIndex = 0;
        }

        private async void OpretInstrumentBtn_Click(object sender, EventArgs e)
        {
            InstrumentRepository instRep = new InstrumentRepository();
            bool opretFejl = false;
            string fejlMeddelelse = string.Empty;
            Instrument opretInstrument = new Instrument();
            KonverterValidator k = new KonverterValidator();
            //Sætter properties som er string og derfor kun skal valideres på indhold i repository
            opretInstrument.Navn = InstrumentNavnTxt.Text;
            opretInstrument.Beskrivelse = InstrumentBeskrivelseTxt.Text;
            opretInstrument.Producent = ProducentCombo.SelectedItem.ToString(); //ProducentCombo.SelectedItem.ToString();
            opretInstrument.VareGruppe = vareGruppe;
            //Der valideres på om der er problemer med at konvertere de modtagne input til de nødvendige datatyper.. Dette kan eventuelt laves smartere og eksternt
            //Er der et problem med konvertering lagres en fejlmeddelelse og opdaterfejl sættes til true.
            opretInstrument.IndkøbsPris = k.DoubleConverter(InstrumentIndkøbsPrisTxt.Text);
            if(opretInstrument.IndkøbsPris == 0)
            {
                opretFejl = true;
                fejlMeddelelse += "Indkøbspris var ikke et tal";
            }
            opretInstrument.Fortjeneste = k.DoubleConverter(InstrumentFortjenesteTxt.Text);
            if(opretInstrument.Fortjeneste == 0)
            {
                opretFejl = true;
                fejlMeddelelse += "Indkøbspris var ikke et tal";
            }
            opretInstrument.LagerDato = k.DateTimeConverter(InstrumentLagerDatoTxt.Text);
            if(opretInstrument.LagerDato == new DateTime(1,1,1))
            {
                opretFejl = true;
                fejlMeddelelse += "Lagerdato var ikke en dato";
            }
            opretInstrument.Antal = k.IntConverter(InstrumentAntalTxt.Text);
            if(opretInstrument.Antal == 0)
            {
                opretFejl = true;
                fejlMeddelelse += "Antal var ikke et tal";
            }
            //er der opstået en fejl udskrives en fejlmeddelelse
            if (opretFejl == false)
            {
                if(await instRep.OpretInstrumentAsync(opretInstrument))
                {
                    this.Hide();
                    prevForm.Show();
                    prevForm.LoadInstrumentGrid();
                }
                else
                {
                    StatusLabel.Text = "Kunne ikke oprette varen";
                }
            }
            else
            {
                StatusLabel.Text = fejlMeddelelse;
            }
        }

        private void TilbageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
            prevForm.LoadInstrumentGrid();
            
        }
        private void FyldProducentCombo()
        {
            //Fylder comboboks med potentielle producenter
            ProducentCombo.Items.Add("Yamaha");
            ProducentCombo.Items.Add("Ibanez");
            ProducentCombo.Items.Add("Pearl");
            ProducentCombo.Items.Add("Korg");
            ProducentCombo.Items.Add("Gibson");
            ProducentCombo.Items.Add("Tama");
        }
    }
}
