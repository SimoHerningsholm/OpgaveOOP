namespace AfsluttendeOpgaveOOPForm
{
    partial class BassForm
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
            this.OpdaterBassBtn = new System.Windows.Forms.Button();
            this.OpretBassBtn = new System.Windows.Forms.Button();
            this.BassProducent = new System.Windows.Forms.ComboBox();
            this.BassLagerDato = new System.Windows.Forms.DateTimePicker();
            this.BassFortjenesteTxt = new System.Windows.Forms.TextBox();
            this.BassInkøbsPrisTxt = new System.Windows.Forms.TextBox();
            this.BassBeskrivelseTxt = new System.Windows.Forms.TextBox();
            this.BassNavnTxt = new System.Windows.Forms.TextBox();
            this.BassGridView = new System.Windows.Forms.DataGridView();
            this.SletBassBtn = new System.Windows.Forms.Button();
            this.TilbageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BassGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OpdaterBassBtn
            // 
            this.OpdaterBassBtn.Location = new System.Drawing.Point(121, 339);
            this.OpdaterBassBtn.Name = "OpdaterBassBtn";
            this.OpdaterBassBtn.Size = new System.Drawing.Size(75, 23);
            this.OpdaterBassBtn.TabIndex = 19;
            this.OpdaterBassBtn.Text = "Opdater";
            this.OpdaterBassBtn.UseVisualStyleBackColor = true;
            this.OpdaterBassBtn.Click += new System.EventHandler(this.OpdaterBassBtn_Click);
            // 
            // OpretBassBtn
            // 
            this.OpretBassBtn.Location = new System.Drawing.Point(27, 339);
            this.OpretBassBtn.Name = "OpretBassBtn";
            this.OpretBassBtn.Size = new System.Drawing.Size(88, 26);
            this.OpretBassBtn.TabIndex = 18;
            this.OpretBassBtn.Text = "Opret";
            this.OpretBassBtn.UseVisualStyleBackColor = true;
            this.OpretBassBtn.Click += new System.EventHandler(this.OpretBassBtn_Click);
            // 
            // BassProducent
            // 
            this.BassProducent.FormattingEnabled = true;
            this.BassProducent.Location = new System.Drawing.Point(27, 288);
            this.BassProducent.Name = "BassProducent";
            this.BassProducent.Size = new System.Drawing.Size(121, 21);
            this.BassProducent.TabIndex = 17;
            this.BassProducent.Text = "Producent";
            // 
            // BassLagerDato
            // 
            this.BassLagerDato.Location = new System.Drawing.Point(27, 240);
            this.BassLagerDato.Name = "BassLagerDato";
            this.BassLagerDato.Size = new System.Drawing.Size(100, 20);
            this.BassLagerDato.TabIndex = 16;
            // 
            // BassFortjenesteTxt
            // 
            this.BassFortjenesteTxt.Location = new System.Drawing.Point(27, 196);
            this.BassFortjenesteTxt.Name = "BassFortjenesteTxt";
            this.BassFortjenesteTxt.Size = new System.Drawing.Size(100, 20);
            this.BassFortjenesteTxt.TabIndex = 15;
            this.BassFortjenesteTxt.Text = "Fortjeneste";
            // 
            // BassInkøbsPrisTxt
            // 
            this.BassInkøbsPrisTxt.Location = new System.Drawing.Point(27, 150);
            this.BassInkøbsPrisTxt.Name = "BassInkøbsPrisTxt";
            this.BassInkøbsPrisTxt.Size = new System.Drawing.Size(100, 20);
            this.BassInkøbsPrisTxt.TabIndex = 14;
            this.BassInkøbsPrisTxt.Text = "Indkøbspris";
            // 
            // BassBeskrivelseTxt
            // 
            this.BassBeskrivelseTxt.Location = new System.Drawing.Point(27, 105);
            this.BassBeskrivelseTxt.Name = "BassBeskrivelseTxt";
            this.BassBeskrivelseTxt.Size = new System.Drawing.Size(100, 20);
            this.BassBeskrivelseTxt.TabIndex = 13;
            this.BassBeskrivelseTxt.Text = "Beskrivelse";
            // 
            // BassNavnTxt
            // 
            this.BassNavnTxt.Location = new System.Drawing.Point(27, 58);
            this.BassNavnTxt.Name = "BassNavnTxt";
            this.BassNavnTxt.Size = new System.Drawing.Size(100, 20);
            this.BassNavnTxt.TabIndex = 12;
            this.BassNavnTxt.Text = "Navn";
            // 
            // BassGridView
            // 
            this.BassGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BassGridView.Location = new System.Drawing.Point(251, 40);
            this.BassGridView.Name = "BassGridView";
            this.BassGridView.Size = new System.Drawing.Size(523, 370);
            this.BassGridView.TabIndex = 11;
            // 
            // SletBassBtn
            // 
            this.SletBassBtn.Location = new System.Drawing.Point(27, 371);
            this.SletBassBtn.Name = "SletBassBtn";
            this.SletBassBtn.Size = new System.Drawing.Size(75, 23);
            this.SletBassBtn.TabIndex = 20;
            this.SletBassBtn.Text = "Slet";
            this.SletBassBtn.UseVisualStyleBackColor = true;
            this.SletBassBtn.Click += new System.EventHandler(this.SletBassBtn_Click);
            // 
            // TilbageBtn
            // 
            this.TilbageBtn.Location = new System.Drawing.Point(27, 415);
            this.TilbageBtn.Name = "TilbageBtn";
            this.TilbageBtn.Size = new System.Drawing.Size(169, 23);
            this.TilbageBtn.TabIndex = 21;
            this.TilbageBtn.Text = "Tilbage til instrumentgrupper";
            this.TilbageBtn.UseVisualStyleBackColor = true;
            // 
            // BassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TilbageBtn);
            this.Controls.Add(this.SletBassBtn);
            this.Controls.Add(this.OpdaterBassBtn);
            this.Controls.Add(this.OpretBassBtn);
            this.Controls.Add(this.BassProducent);
            this.Controls.Add(this.BassLagerDato);
            this.Controls.Add(this.BassFortjenesteTxt);
            this.Controls.Add(this.BassInkøbsPrisTxt);
            this.Controls.Add(this.BassBeskrivelseTxt);
            this.Controls.Add(this.BassNavnTxt);
            this.Controls.Add(this.BassGridView);
            this.Name = "BassForm";
            this.Text = "BassForm";
            ((System.ComponentModel.ISupportInitialize)(this.BassGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpdaterBassBtn;
        private System.Windows.Forms.Button OpretBassBtn;
        private System.Windows.Forms.ComboBox BassProducent;
        private System.Windows.Forms.DateTimePicker BassLagerDato;
        private System.Windows.Forms.TextBox BassFortjenesteTxt;
        private System.Windows.Forms.TextBox BassInkøbsPrisTxt;
        private System.Windows.Forms.TextBox BassBeskrivelseTxt;
        private System.Windows.Forms.TextBox BassNavnTxt;
        private System.Windows.Forms.DataGridView BassGridView;
        private System.Windows.Forms.Button SletBassBtn;
        private System.Windows.Forms.Button TilbageBtn;
    }
}