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

namespace AfsluttendeOpgaveOOPForm
{
    public partial class VisInstrumenterForm : Form
    {
        //Deklarere properties der skal anvendes af formen
        private int gruppeId;
        private int valgtInstrumentVareNummer;
        private Form prevForm;
        public VisInstrumenterForm()
        {
            InitializeComponent();
        }
        public VisInstrumenterForm(Form inPrevForm, int inGruppeId)
        {
            //Sætter den forhenværende form samt gruppeid på valgt instrumenter der skal vises og loader instrumentgrid
            InitializeComponent();
            prevForm = inPrevForm;
            gruppeId = inGruppeId;
            loadInstrumentGrid();
            GruppeIdLabel.Text = gruppeId.ToString();
           
        }
        private void InstrumentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Varenummer på den valgt vare i gridview lægges i valgtvarenummer således at den kan anvendes at opdaterform samt ved sletning af vare
            valgtInstrumentVareNummer = (int)InstrumentGridView.Rows[InstrumentGridView.CurrentRow.Index].Cells[0].Value;
            StatusLabel.Text = valgtInstrumentVareNummer.ToString();
        }
        private void TilbageBtn_Click(object sender, EventArgs e)
        {
            //Klikker man på tilbage skjules denne form og dne tidligere vises
            this.Hide();
            prevForm.Show();
        }
        public async void loadInstrumentGrid()
        {
            //Instanciere repository med henblik på at læse instrumentgrupper ind i datagridview
            InstrumentRepository rep = new InstrumentRepository();
            //nulstiller datasource
            InstrumentGridView.DataSource = null;
            //loader instrumentgrupper ind med metode fra repository 
            List<Instrument> instrumenter = await rep.HentInstrumenterAsync(gruppeId);
            //Lister instrumentgrupperne ved at sætte listen af instrumentgrupper som datasource på instrumentgrpgrid
            InstrumentGridView.DataSource = instrumenter;
        }

        private void OpretInstrumentBtn_Click(object sender, EventArgs e)
        {
            //Instanciere en opretForm som tager mod nuværende form samt id på den valgte gruppe
            OpretInstrumentForm opretForm = new OpretInstrumentForm(this, gruppeId);
            //Sjuler denne form og viser opretformen
            this.Hide();
            opretForm.Show();
        }

        private async void OpdaterInstrumentBtn_Click(object sender, EventArgs e)
        {
            //Instanciere instrument repository med henblik på at kunne hente et instrument med valgt instrument varenummer
            InstrumentRepository hentInstrument = new InstrumentRepository();
            //Henter instrument ned og lagre i valgtinstrument variablen
            Instrument valgtInstrument = await hentInstrument.HentInstrumentAsync(valgtInstrumentVareNummer);
            //Har den ikke returneret null kan opdatering af instrument påbegyndes
            if(valgtInstrument != null)
            {
                //instanciere en opdateringsform som modtager instrumentet der skal opdateres/redigere samt den nuværende form
                OpdaterInstrumentForm opdaterForm = new OpdaterInstrumentForm(this, valgtInstrument, gruppeId);
                //skjuler denne form og viser opdateringsformen
                this.Hide();
                opdaterForm.Show();
            }
            else
            {
                //modtog den ikke noget instrument (null) udskrives en fejlmeddelelse
                StatusLabel.Text = "Kunne ikke finde den pågældende varer";
            }
        }

        private async void SletInstrumentBtn_Click(object sender, EventArgs e)
        {
            //Instanciere object til at slette instrument
            InstrumentRepository sletInstrument = new InstrumentRepository();
            //Kalder sletinstrument metoden på sletinstrument objektet og passer varenummeret på varen der skal slettes
            bool successfuldSlet = await sletInstrument.SletInstrumentAsync(valgtInstrumentVareNummer);
            //Der udskrives fejlmeddelelse alt efter hvorvidt det har ladet sig gøre at slette instrument og grid over instrumenter reloades
            if(successfuldSlet)
            {
                StatusLabel.Text = "Du har successfuldt slettet vare";
                loadInstrumentGrid();
            }
            else
            {
                StatusLabel.Text = "Der opstod en fejl ved sletning af vare";
            }
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            loadInstrumentGrid();
        }
    }
}
