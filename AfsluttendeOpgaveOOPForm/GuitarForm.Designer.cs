namespace AfsluttendeOpgaveOOPForm
{
    partial class GuitarForm
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
            this.GuitarGridView = new System.Windows.Forms.DataGridView();
            this.GuitarNavnTxt = new System.Windows.Forms.TextBox();
            this.GuitarBeskrivelseTxt = new System.Windows.Forms.TextBox();
            this.GuitarIndkøbsPrisTxt = new System.Windows.Forms.TextBox();
            this.GuitarFortjenesteTxt = new System.Windows.Forms.TextBox();
            this.GuitarLagerDato = new System.Windows.Forms.DateTimePicker();
            this.GuitarProducent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpretGuitarBtn = new System.Windows.Forms.Button();
            this.OpdaterGuitarBtn = new System.Windows.Forms.Button();
            this.SletGuitarBtn = new System.Windows.Forms.Button();
            this.TilbageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GuitarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GuitarGridView
            // 
            this.GuitarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuitarGridView.Location = new System.Drawing.Point(265, 68);
            this.GuitarGridView.Name = "GuitarGridView";
            this.GuitarGridView.Size = new System.Drawing.Size(523, 370);
            this.GuitarGridView.TabIndex = 0;
            // 
            // GuitarNavnTxt
            // 
            this.GuitarNavnTxt.Location = new System.Drawing.Point(37, 68);
            this.GuitarNavnTxt.Name = "GuitarNavnTxt";
            this.GuitarNavnTxt.Size = new System.Drawing.Size(100, 20);
            this.GuitarNavnTxt.TabIndex = 1;
            this.GuitarNavnTxt.Text = "Navn";
            // 
            // GuitarBeskrivelseTxt
            // 
            this.GuitarBeskrivelseTxt.Location = new System.Drawing.Point(37, 115);
            this.GuitarBeskrivelseTxt.Name = "GuitarBeskrivelseTxt";
            this.GuitarBeskrivelseTxt.Size = new System.Drawing.Size(100, 20);
            this.GuitarBeskrivelseTxt.TabIndex = 2;
            this.GuitarBeskrivelseTxt.Text = "Beskrivelse";
            // 
            // GuitarIndkøbsPrisTxt
            // 
            this.GuitarIndkøbsPrisTxt.Location = new System.Drawing.Point(37, 160);
            this.GuitarIndkøbsPrisTxt.Name = "GuitarIndkøbsPrisTxt";
            this.GuitarIndkøbsPrisTxt.Size = new System.Drawing.Size(100, 20);
            this.GuitarIndkøbsPrisTxt.TabIndex = 3;
            this.GuitarIndkøbsPrisTxt.Text = "Indkøbspris";
            // 
            // GuitarFortjenesteTxt
            // 
            this.GuitarFortjenesteTxt.Location = new System.Drawing.Point(37, 206);
            this.GuitarFortjenesteTxt.Name = "GuitarFortjenesteTxt";
            this.GuitarFortjenesteTxt.Size = new System.Drawing.Size(100, 20);
            this.GuitarFortjenesteTxt.TabIndex = 4;
            this.GuitarFortjenesteTxt.Text = "Fortjeneste";
            // 
            // GuitarLagerDato
            // 
            this.GuitarLagerDato.Location = new System.Drawing.Point(37, 250);
            this.GuitarLagerDato.Name = "GuitarLagerDato";
            this.GuitarLagerDato.Size = new System.Drawing.Size(100, 20);
            this.GuitarLagerDato.TabIndex = 5;
            // 
            // GuitarProducent
            // 
            this.GuitarProducent.FormattingEnabled = true;
            this.GuitarProducent.Location = new System.Drawing.Point(37, 298);
            this.GuitarProducent.Name = "GuitarProducent";
            this.GuitarProducent.Size = new System.Drawing.Size(121, 21);
            this.GuitarProducent.TabIndex = 7;
            this.GuitarProducent.Text = "Producent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // OpretGuitarBtn
            // 
            this.OpretGuitarBtn.Location = new System.Drawing.Point(37, 339);
            this.OpretGuitarBtn.Name = "OpretGuitarBtn";
            this.OpretGuitarBtn.Size = new System.Drawing.Size(88, 26);
            this.OpretGuitarBtn.TabIndex = 9;
            this.OpretGuitarBtn.Text = "Opret";
            this.OpretGuitarBtn.UseVisualStyleBackColor = true;
            this.OpretGuitarBtn.Click += new System.EventHandler(this.OpretGuitarBtn_Click);
            // 
            // OpdaterGuitarBtn
            // 
            this.OpdaterGuitarBtn.Location = new System.Drawing.Point(150, 339);
            this.OpdaterGuitarBtn.Name = "OpdaterGuitarBtn";
            this.OpdaterGuitarBtn.Size = new System.Drawing.Size(75, 23);
            this.OpdaterGuitarBtn.TabIndex = 10;
            this.OpdaterGuitarBtn.Text = "Opdater";
            this.OpdaterGuitarBtn.UseVisualStyleBackColor = true;
            this.OpdaterGuitarBtn.Click += new System.EventHandler(this.OpdaterGuitarBtn_Click);
            // 
            // SletGuitarBtn
            // 
            this.SletGuitarBtn.Location = new System.Drawing.Point(37, 380);
            this.SletGuitarBtn.Name = "SletGuitarBtn";
            this.SletGuitarBtn.Size = new System.Drawing.Size(75, 23);
            this.SletGuitarBtn.TabIndex = 11;
            this.SletGuitarBtn.Text = "Slet";
            this.SletGuitarBtn.UseVisualStyleBackColor = true;
            this.SletGuitarBtn.Click += new System.EventHandler(this.SletGuitarBtn_Click);
            // 
            // TilbageBtn
            // 
            this.TilbageBtn.Location = new System.Drawing.Point(37, 415);
            this.TilbageBtn.Name = "TilbageBtn";
            this.TilbageBtn.Size = new System.Drawing.Size(188, 23);
            this.TilbageBtn.TabIndex = 12;
            this.TilbageBtn.Text = "Tilbage til instrument grupper";
            this.TilbageBtn.UseVisualStyleBackColor = true;
            this.TilbageBtn.Click += new System.EventHandler(this.TilbageBtn_Click);
            // 
            // GuitarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TilbageBtn);
            this.Controls.Add(this.SletGuitarBtn);
            this.Controls.Add(this.OpdaterGuitarBtn);
            this.Controls.Add(this.OpretGuitarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuitarProducent);
            this.Controls.Add(this.GuitarLagerDato);
            this.Controls.Add(this.GuitarFortjenesteTxt);
            this.Controls.Add(this.GuitarIndkøbsPrisTxt);
            this.Controls.Add(this.GuitarBeskrivelseTxt);
            this.Controls.Add(this.GuitarNavnTxt);
            this.Controls.Add(this.GuitarGridView);
            this.Name = "GuitarForm";
            this.Text = "GuitarForm";
            ((System.ComponentModel.ISupportInitialize)(this.GuitarGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GuitarGridView;
        private System.Windows.Forms.TextBox GuitarNavnTxt;
        private System.Windows.Forms.TextBox GuitarBeskrivelseTxt;
        private System.Windows.Forms.TextBox GuitarIndkøbsPrisTxt;
        private System.Windows.Forms.TextBox GuitarFortjenesteTxt;
        private System.Windows.Forms.DateTimePicker GuitarLagerDato;
        private System.Windows.Forms.ComboBox GuitarProducent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpretGuitarBtn;
        private System.Windows.Forms.Button OpdaterGuitarBtn;
        private System.Windows.Forms.Button SletGuitarBtn;
        private System.Windows.Forms.Button TilbageBtn;
    }
}