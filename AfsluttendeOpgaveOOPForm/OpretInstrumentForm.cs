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
        private Form prevForm;
        private int vareGruppe;
        public OpretInstrumentForm(Form inPrevForm, int inVareGruppe)
        {
            InitializeComponent();
            prevForm = inPrevForm;
            vareGruppe = inVareGruppe;
            fyldProducentCombo();
            ProducentCombo.SelectedIndex = 0;
        }

        private async void OpretInstrumentBtn_Click(object sender, EventArgs e)
        {
            InstrumentRepository instRep = new InstrumentRepository();
            bool opretFejl = false;
            string fejlMeddelelse = string.Empty;
            Instrument opretInstrument = new Instrument();
            //Sætter properties som er string og derfor kun skal valideres på indhold i repository
            opretInstrument.Navn = InstrumentNavnTxt.Text;
            opretInstrument.Beskrivelse = InstrumentBeskrivelseTxt.Text;
            opretInstrument.Producent = ProducentCombo.SelectedText;
            opretInstrument.VareGruppe = vareGruppe;
            //Der valideres på om der er problemer med at konvertere de modtagne input til de nødvendige datatyper.. Dette kan eventuelt laves smartere og eksternt
            //Er der et problem med konvertering lagres en fejlmeddelelse og opdaterfejl sættes til true.
            try
            {
                opretInstrument.IndkøbsPris = Convert.ToDouble(InstrumentIndkøbsPrisTxt.Text);
            }
            catch
            {
                opretFejl = true;
                fejlMeddelelse += "Indkøbspris var ikke et tal";
            }
            try
            {
                opretInstrument.Fortjeneste = Convert.ToDouble(InstrumentFortjenesteTxt.Text);
            }
            catch
            {
                opretFejl = true;
                fejlMeddelelse += "Fortjeneste var ikke et tal";
            }
            try
            {
                opretInstrument.LagerDato = Convert.ToDateTime(InstrumentLagerDatoTxt.Text);
            }
            catch
            {
                opretFejl = true;
                fejlMeddelelse += "Lagerdato var ikke en dato";
            }
            try
            {
                opretInstrument.Antal = int.Parse(InstrumentAntalTxt.Text);
            }
            catch
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
                }
                else
                {
                    StatusLabel.Text = "Kunne ikke opdatere varen";
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
        }
        private void fyldProducentCombo()
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
