﻿namespace AfsluttendeOpgaveOOPForm
{
    partial class OpretInstrumentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpretInstrumentBtn = new System.Windows.Forms.Button();
            this.InstrumentNavnTxt = new System.Windows.Forms.TextBox();
            this.InstrumentBeskrivelseTxt = new System.Windows.Forms.TextBox();
            this.InstrumentIndkøbsPrisTxt = new System.Windows.Forms.TextBox();
            this.InstrumentFortjenesteTxt = new System.Windows.Forms.TextBox();
            this.InstrumentAntalTxt = new System.Windows.Forms.TextBox();
            this.InstrumentLagerDatoTxt = new System.Windows.Forms.DateTimePicker();
            this.ProducentCombo = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TilbageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpretInstrumentBtn
            // 
            this.OpretInstrumentBtn.Location = new System.Drawing.Point(321, 370);
            this.OpretInstrumentBtn.Name = "OpretInstrumentBtn";
            this.OpretInstrumentBtn.Size = new System.Drawing.Size(155, 23);
            this.OpretInstrumentBtn.TabIndex = 0;
            this.OpretInstrumentBtn.Text = "Opret";
            this.OpretInstrumentBtn.UseVisualStyleBackColor = true;
            this.OpretInstrumentBtn.Click += new System.EventHandler(this.OpretInstrumentBtn_Click);
            // 
            // InstrumentNavnTxt
            // 
            this.InstrumentNavnTxt.Location = new System.Drawing.Point(321, 52);
            this.InstrumentNavnTxt.Name = "InstrumentNavnTxt";
            this.InstrumentNavnTxt.Size = new System.Drawing.Size(155, 20);
            this.InstrumentNavnTxt.TabIndex = 1;
            this.InstrumentNavnTxt.Text = "Navn";
            // 
            // InstrumentBeskrivelseTxt
            // 
            this.InstrumentBeskrivelseTxt.Location = new System.Drawing.Point(321, 97);
            this.InstrumentBeskrivelseTxt.Name = "InstrumentBeskrivelseTxt";
            this.InstrumentBeskrivelseTxt.Size = new System.Drawing.Size(155, 20);
            this.InstrumentBeskrivelseTxt.TabIndex = 2;
            this.InstrumentBeskrivelseTxt.Text = "Beskrivelse";
            // 
            // InstrumentIndkøbsPrisTxt
            // 
            this.InstrumentIndkøbsPrisTxt.Location = new System.Drawing.Point(321, 142);
            this.InstrumentIndkøbsPrisTxt.Name = "InstrumentIndkøbsPrisTxt";
            this.InstrumentIndkøbsPrisTxt.Size = new System.Drawing.Size(155, 20);
            this.InstrumentIndkøbsPrisTxt.TabIndex = 3;
            this.InstrumentIndkøbsPrisTxt.Text = "Indkøbspris";
            // 
            // InstrumentFortjenesteTxt
            // 
            this.InstrumentFortjenesteTxt.Location = new System.Drawing.Point(321, 190);
            this.InstrumentFortjenesteTxt.Name = "InstrumentFortjenesteTxt";
            this.InstrumentFortjenesteTxt.Size = new System.Drawing.Size(155, 20);
            this.InstrumentFortjenesteTxt.TabIndex = 4;
            this.InstrumentFortjenesteTxt.Text = "Fortjeneste";
            // 
            // InstrumentAntalTxt
            // 
            this.InstrumentAntalTxt.Location = new System.Drawing.Point(321, 273);
            this.InstrumentAntalTxt.Name = "InstrumentAntalTxt";
            this.InstrumentAntalTxt.Size = new System.Drawing.Size(155, 20);
            this.InstrumentAntalTxt.TabIndex = 5;
            this.InstrumentAntalTxt.Text = "Antal";
            // 
            // InstrumentLagerDatoTxt
            // 
            this.InstrumentLagerDatoTxt.Location = new System.Drawing.Point(321, 233);
            this.InstrumentLagerDatoTxt.Name = "InstrumentLagerDatoTxt";
            this.InstrumentLagerDatoTxt.Size = new System.Drawing.Size(155, 20);
            this.InstrumentLagerDatoTxt.TabIndex = 6;
            // 
            // ProducentCombo
            // 
            this.ProducentCombo.FormattingEnabled = true;
            this.ProducentCombo.Location = new System.Drawing.Point(321, 322);
            this.ProducentCombo.Name = "ProducentCombo";
            this.ProducentCombo.Size = new System.Drawing.Size(155, 21);
            this.ProducentCombo.TabIndex = 7;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(328, 401);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Opret instrument indenfor varegruppe  du har valgt";
            // 
            // TilbageBtn
            // 
            this.TilbageBtn.Location = new System.Drawing.Point(321, 415);
            this.TilbageBtn.Name = "TilbageBtn";
            this.TilbageBtn.Size = new System.Drawing.Size(155, 23);
            this.TilbageBtn.TabIndex = 10;
            this.TilbageBtn.Text = "Tilbage til varegruppe";
            this.TilbageBtn.UseVisualStyleBackColor = true;
            this.TilbageBtn.Click += new System.EventHandler(this.TilbageBtn_Click);
            // 
            // OpretInstrumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TilbageBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ProducentCombo);
            this.Controls.Add(this.InstrumentLagerDatoTxt);
            this.Controls.Add(this.InstrumentAntalTxt);
            this.Controls.Add(this.InstrumentFortjenesteTxt);
            this.Controls.Add(this.InstrumentIndkøbsPrisTxt);
            this.Controls.Add(this.InstrumentBeskrivelseTxt);
            this.Controls.Add(this.InstrumentNavnTxt);
            this.Controls.Add(this.OpretInstrumentBtn);
            this.Name = "OpretInstrumentForm";
            this.Text = "OpretInstrumentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpretInstrumentBtn;
        private System.Windows.Forms.TextBox InstrumentNavnTxt;
        private System.Windows.Forms.TextBox InstrumentBeskrivelseTxt;
        private System.Windows.Forms.TextBox InstrumentIndkøbsPrisTxt;
        private System.Windows.Forms.TextBox InstrumentFortjenesteTxt;
        private System.Windows.Forms.TextBox InstrumentAntalTxt;
        private System.Windows.Forms.DateTimePicker InstrumentLagerDatoTxt;
        private System.Windows.Forms.ComboBox ProducentCombo;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TilbageBtn;
    }
}