﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Models;
using Validator;

namespace AfsluttendeOpgaveOOPForm
{
    public partial class VisInstrumentGrupper : Form
    {
        private int valgtVareGruppeId;
        public VisInstrumentGrupper()
        {
            InitializeComponent();
            LoadInstrumentGruppeGrid();
        }
        private async void OpretInstrumentGrpBtn_Click(object sender, EventArgs e)
        {
            //Instanciere instrumentgrupperepository med henblik på at oprette ny instrumentgruppe
            InstrumentGruppeRepository grprep = new InstrumentGruppeRepository();
            bool successfuldOprettelse = await grprep.OpretInstrumentGruppeAsync(new InstrumentGruppe
            {
                //sætter navn og beskrivelse
                Navn = InstrumentGrpNavnTxt.Text,
                Beskrivelse = InstrumentGrpBeskrivelseTxt.Text
            });
            //er oprettelse foretaget successfuldt skal formen resettes, hvis ikke skal der printes en fejlmeddelelse
            if(successfuldOprettelse)
            {
                ResetForm();
            }
            else
            {
                StatusLabel.Text = "Oprettelsen lykkedes ikke";
            }

        }
        private void InstrumentGrpGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Modtager id på valgt varegruppe
            valgtVareGruppeId = (int)InstrumentGrpGrid.Rows[InstrumentGrpGrid.CurrentRow.Index].Cells[0].Value;
            //instanciere en visinstrumenter form som modtager den nuværende form samt det valgte gruppeid
            VisInstrumenterForm visInstrumenter = new VisInstrumenterForm(this, valgtVareGruppeId);
            //Skjuler denne form og viser instrumentform med instrumenter for den valgte varegruppe
            this.Hide();
            visInstrumenter.Show();
        }
        private async void LoadInstrumentGruppeGrid()
        {
            //Instanciere repository med henblik på at læse instrumentgrupper ind i datagridview
            InstrumentGruppeRepository rep = new InstrumentGruppeRepository();
            //nulstiller datasource
            InstrumentGrpGrid.DataSource = null;
            //loader instrumentgrupper ind med metode fra repository 
            List<InstrumentGruppe> instrumentGrupper = await rep.HentInstrumentGrupperAsync();
            //Lister instrumentgrupperne ved at sætte listen af instrumentgrupper som datasource på instrumentgrpgrid
            InstrumentGrpGrid.DataSource = instrumentGrupper;
        }
        private async void LoadInstrumentGrid()
        {
            //Instanciere repository med henblik på at læse instrumentgrupper ind i datagridview
            InstrumentRepository rep = new InstrumentRepository();
            //nulstiller datasource
            InstrumentGrpGrid.DataSource = null;
            //loader instrumentgrupper ind med metode fra repository 
            List<Instrument> instrumenter = await rep.HentInstrumenterAsync(valgtVareGruppeId);
            //Lister instrumentgrupperne ved at sætte listen af instrumentgrupper som datasource på instrumentgrpgrid
            InstrumentGrpGrid.DataSource = instrumenter;
        }
        private void ResetForm()
        {
            //Resetter tekstbokse med standard værdier og reloader grid
            InstrumentGrpNavnTxt.Text = "Navn";
            InstrumentGrpBeskrivelseTxt.Text = "Beskrivelse";
            LoadInstrumentGruppeGrid();
        }

        private void ReloadGridBtn_Click(object sender, EventArgs e)
        {
            LoadInstrumentGruppeGrid();
        }
    }
}
