namespace AfsluttendeOpgaveOOPForm
{
    partial class VisInstrumenterForm
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
            this.InstrumentGridView = new System.Windows.Forms.DataGridView();
            this.GruppeIdLabel = new System.Windows.Forms.Label();
            this.TilbageBtn = new System.Windows.Forms.Button();
            this.SletInstrumentBtn = new System.Windows.Forms.Button();
            this.OpdaterInstrumentBtn = new System.Windows.Forms.Button();
            this.OpretInstrumentBtn = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ReloadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InstrumentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InstrumentGridView
            // 
            this.InstrumentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstrumentGridView.Location = new System.Drawing.Point(184, 30);
            this.InstrumentGridView.Name = "InstrumentGridView";
            this.InstrumentGridView.Size = new System.Drawing.Size(590, 366);
            this.InstrumentGridView.TabIndex = 0;
            this.InstrumentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InstrumentGridView_CellContentClick);
            // 
            // GruppeIdLabel
            // 
            this.GruppeIdLabel.AutoSize = true;
            this.GruppeIdLabel.Location = new System.Drawing.Point(21, 30);
            this.GruppeIdLabel.Name = "GruppeIdLabel";
            this.GruppeIdLabel.Size = new System.Drawing.Size(70, 13);
            this.GruppeIdLabel.TabIndex = 1;
            this.GruppeIdLabel.Text = "gruppeidlabel";
            // 
            // TilbageBtn
            // 
            this.TilbageBtn.Location = new System.Drawing.Point(24, 415);
            this.TilbageBtn.Name = "TilbageBtn";
            this.TilbageBtn.Size = new System.Drawing.Size(211, 23);
            this.TilbageBtn.TabIndex = 2;
            this.TilbageBtn.Text = "Tilbage til vis varegrupper";
            this.TilbageBtn.UseVisualStyleBackColor = true;
            this.TilbageBtn.Click += new System.EventHandler(this.TilbageBtn_Click);
            // 
            // SletInstrumentBtn
            // 
            this.SletInstrumentBtn.Location = new System.Drawing.Point(24, 153);
            this.SletInstrumentBtn.Name = "SletInstrumentBtn";
            this.SletInstrumentBtn.Size = new System.Drawing.Size(129, 23);
            this.SletInstrumentBtn.TabIndex = 13;
            this.SletInstrumentBtn.Text = "Slet Instrumenter";
            this.SletInstrumentBtn.UseVisualStyleBackColor = true;
            this.SletInstrumentBtn.Click += new System.EventHandler(this.SletInstrumentBtn_Click);
            // 
            // OpdaterInstrumentBtn
            // 
            this.OpdaterInstrumentBtn.Location = new System.Drawing.Point(24, 109);
            this.OpdaterInstrumentBtn.Name = "OpdaterInstrumentBtn";
            this.OpdaterInstrumentBtn.Size = new System.Drawing.Size(129, 23);
            this.OpdaterInstrumentBtn.TabIndex = 12;
            this.OpdaterInstrumentBtn.Text = "Opdater instrumenter";
            this.OpdaterInstrumentBtn.UseVisualStyleBackColor = true;
            this.OpdaterInstrumentBtn.Click += new System.EventHandler(this.OpdaterInstrumentBtn_Click);
            // 
            // OpretInstrumentBtn
            // 
            this.OpretInstrumentBtn.Location = new System.Drawing.Point(24, 67);
            this.OpretInstrumentBtn.Name = "OpretInstrumentBtn";
            this.OpretInstrumentBtn.Size = new System.Drawing.Size(129, 23);
            this.OpretInstrumentBtn.TabIndex = 11;
            this.OpretInstrumentBtn.Text = "Opret instrumenter";
            this.OpretInstrumentBtn.UseVisualStyleBackColor = true;
            this.OpretInstrumentBtn.Click += new System.EventHandler(this.OpretInstrumentBtn_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(24, 233);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(35, 13);
            this.StatusLabel.TabIndex = 14;
            this.StatusLabel.Text = "label1";
            // 
            // ReloadBtn
            // 
            this.ReloadBtn.Location = new System.Drawing.Point(24, 196);
            this.ReloadBtn.Name = "ReloadBtn";
            this.ReloadBtn.Size = new System.Drawing.Size(129, 23);
            this.ReloadBtn.TabIndex = 15;
            this.ReloadBtn.Text = "Reload grid";
            this.ReloadBtn.UseVisualStyleBackColor = true;
            this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
            // 
            // VisInstrumenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReloadBtn);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SletInstrumentBtn);
            this.Controls.Add(this.OpdaterInstrumentBtn);
            this.Controls.Add(this.OpretInstrumentBtn);
            this.Controls.Add(this.TilbageBtn);
            this.Controls.Add(this.GruppeIdLabel);
            this.Controls.Add(this.InstrumentGridView);
            this.Name = "VisInstrumenterForm";
            this.Text = "VisInstrumenterForm";
            ((System.ComponentModel.ISupportInitialize)(this.InstrumentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InstrumentGridView;
        private System.Windows.Forms.Label GruppeIdLabel;
        private System.Windows.Forms.Button TilbageBtn;
        private System.Windows.Forms.Button SletInstrumentBtn;
        private System.Windows.Forms.Button OpdaterInstrumentBtn;
        private System.Windows.Forms.Button OpretInstrumentBtn;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button ReloadBtn;
    }
}