namespace AfsluttendeOpgaveOOPForm
{
    partial class VisInstrumentGrupper
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
            this.InstrumentGrpGrid = new System.Windows.Forms.DataGridView();
            this.OpretUILabel = new System.Windows.Forms.Label();
            this.OpretInstrumentGrpBtn = new System.Windows.Forms.Button();
            this.InstrumentGrpNavnTxt = new System.Windows.Forms.TextBox();
            this.InstrumentGrpBeskrivelseTxt = new System.Windows.Forms.TextBox();
            this.OpretGridUILabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ReloadGridBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InstrumentGrpGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // InstrumentGrpGrid
            // 
            this.InstrumentGrpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstrumentGrpGrid.Location = new System.Drawing.Point(191, 62);
            this.InstrumentGrpGrid.Name = "InstrumentGrpGrid";
            this.InstrumentGrpGrid.Size = new System.Drawing.Size(588, 352);
            this.InstrumentGrpGrid.TabIndex = 0;
            this.InstrumentGrpGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InstrumentGrpGrid_CellContentClick);
            // 
            // OpretUILabel
            // 
            this.OpretUILabel.AutoSize = true;
            this.OpretUILabel.Location = new System.Drawing.Point(21, 62);
            this.OpretUILabel.Name = "OpretUILabel";
            this.OpretUILabel.Size = new System.Drawing.Size(120, 13);
            this.OpretUILabel.TabIndex = 1;
            this.OpretUILabel.Text = "Opret instrument gruppe";
            // 
            // OpretInstrumentGrpBtn
            // 
            this.OpretInstrumentGrpBtn.Location = new System.Drawing.Point(24, 177);
            this.OpretInstrumentGrpBtn.Name = "OpretInstrumentGrpBtn";
            this.OpretInstrumentGrpBtn.Size = new System.Drawing.Size(136, 23);
            this.OpretInstrumentGrpBtn.TabIndex = 2;
            this.OpretInstrumentGrpBtn.Text = "Opret instrumentgruppe";
            this.OpretInstrumentGrpBtn.UseVisualStyleBackColor = true;
            this.OpretInstrumentGrpBtn.Click += new System.EventHandler(this.OpretInstrumentGrpBtn_Click);
            // 
            // InstrumentGrpNavnTxt
            // 
            this.InstrumentGrpNavnTxt.Location = new System.Drawing.Point(24, 97);
            this.InstrumentGrpNavnTxt.Name = "InstrumentGrpNavnTxt";
            this.InstrumentGrpNavnTxt.Size = new System.Drawing.Size(136, 20);
            this.InstrumentGrpNavnTxt.TabIndex = 3;
            this.InstrumentGrpNavnTxt.Text = "Navn";
            // 
            // InstrumentGrpBeskrivelseTxt
            // 
            this.InstrumentGrpBeskrivelseTxt.Location = new System.Drawing.Point(24, 140);
            this.InstrumentGrpBeskrivelseTxt.Name = "InstrumentGrpBeskrivelseTxt";
            this.InstrumentGrpBeskrivelseTxt.Size = new System.Drawing.Size(136, 20);
            this.InstrumentGrpBeskrivelseTxt.TabIndex = 4;
            this.InstrumentGrpBeskrivelseTxt.Text = "Beskrivelse";
            // 
            // OpretGridUILabel
            // 
            this.OpretGridUILabel.AutoSize = true;
            this.OpretGridUILabel.Location = new System.Drawing.Point(379, 9);
            this.OpretGridUILabel.Name = "OpretGridUILabel";
            this.OpretGridUILabel.Size = new System.Drawing.Size(143, 13);
            this.OpretGridUILabel.TabIndex = 5;
            this.OpretGridUILabel.Text = "Liste over instrument grupper";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Klik på en gruppe for at gå til  gruppens varer ";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(21, 225);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 7;
            // 
            // ReloadGridBtn
            // 
            this.ReloadGridBtn.Location = new System.Drawing.Point(24, 220);
            this.ReloadGridBtn.Name = "ReloadGridBtn";
            this.ReloadGridBtn.Size = new System.Drawing.Size(136, 23);
            this.ReloadGridBtn.TabIndex = 8;
            this.ReloadGridBtn.Text = "Reload grid";
            this.ReloadGridBtn.UseVisualStyleBackColor = true;
            this.ReloadGridBtn.Click += new System.EventHandler(this.ReloadGridBtn_Click);
            // 
            // VisInstrumentGrupper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReloadGridBtn);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpretGridUILabel);
            this.Controls.Add(this.InstrumentGrpBeskrivelseTxt);
            this.Controls.Add(this.InstrumentGrpNavnTxt);
            this.Controls.Add(this.OpretInstrumentGrpBtn);
            this.Controls.Add(this.OpretUILabel);
            this.Controls.Add(this.InstrumentGrpGrid);
            this.Name = "VisInstrumentGrupper";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.InstrumentGrpGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InstrumentGrpGrid;
        private System.Windows.Forms.Label OpretUILabel;
        private System.Windows.Forms.Button OpretInstrumentGrpBtn;
        private System.Windows.Forms.TextBox InstrumentGrpNavnTxt;
        private System.Windows.Forms.TextBox InstrumentGrpBeskrivelseTxt;
        private System.Windows.Forms.Label OpretGridUILabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button ReloadGridBtn;
    }
}

