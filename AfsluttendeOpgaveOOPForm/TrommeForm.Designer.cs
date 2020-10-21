namespace AfsluttendeOpgaveOOPForm
{
    partial class TrommeForm
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
            this.TrommeOpdaterBtn = new System.Windows.Forms.Button();
            this.TrommeOpretBtn = new System.Windows.Forms.Button();
            this.TrommeProducent = new System.Windows.Forms.ComboBox();
            this.TrommeLagerDato = new System.Windows.Forms.DateTimePicker();
            this.TrommeFortjenesteTxt = new System.Windows.Forms.TextBox();
            this.TrommeIndkøbsPrisTxt = new System.Windows.Forms.TextBox();
            this.TrommeBeskrivelseTxt = new System.Windows.Forms.TextBox();
            this.TrommenNavnTxt = new System.Windows.Forms.TextBox();
            this.TrommeDataGrid = new System.Windows.Forms.DataGridView();
            this.TrommeSletBtn = new System.Windows.Forms.Button();
            this.TilbageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrommeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TrommeOpdaterBtn
            // 
            this.TrommeOpdaterBtn.Location = new System.Drawing.Point(139, 330);
            this.TrommeOpdaterBtn.Name = "TrommeOpdaterBtn";
            this.TrommeOpdaterBtn.Size = new System.Drawing.Size(75, 23);
            this.TrommeOpdaterBtn.TabIndex = 19;
            this.TrommeOpdaterBtn.Text = "Opdater";
            this.TrommeOpdaterBtn.UseVisualStyleBackColor = true;
            this.TrommeOpdaterBtn.Click += new System.EventHandler(this.TrommeOpdaterBtn_Click);
            // 
            // TrommeOpretBtn
            // 
            this.TrommeOpretBtn.Location = new System.Drawing.Point(27, 330);
            this.TrommeOpretBtn.Name = "TrommeOpretBtn";
            this.TrommeOpretBtn.Size = new System.Drawing.Size(88, 26);
            this.TrommeOpretBtn.TabIndex = 18;
            this.TrommeOpretBtn.Text = "Opret";
            this.TrommeOpretBtn.UseVisualStyleBackColor = true;
            this.TrommeOpretBtn.Click += new System.EventHandler(this.TrommeOpretBtn_Click);
            // 
            // TrommeProducent
            // 
            this.TrommeProducent.FormattingEnabled = true;
            this.TrommeProducent.Location = new System.Drawing.Point(27, 288);
            this.TrommeProducent.Name = "TrommeProducent";
            this.TrommeProducent.Size = new System.Drawing.Size(121, 21);
            this.TrommeProducent.TabIndex = 17;
            this.TrommeProducent.Text = "Producent";
            // 
            // TrommeLagerDato
            // 
            this.TrommeLagerDato.Location = new System.Drawing.Point(27, 240);
            this.TrommeLagerDato.Name = "TrommeLagerDato";
            this.TrommeLagerDato.Size = new System.Drawing.Size(100, 20);
            this.TrommeLagerDato.TabIndex = 16;
            // 
            // TrommeFortjenesteTxt
            // 
            this.TrommeFortjenesteTxt.Location = new System.Drawing.Point(27, 196);
            this.TrommeFortjenesteTxt.Name = "TrommeFortjenesteTxt";
            this.TrommeFortjenesteTxt.Size = new System.Drawing.Size(100, 20);
            this.TrommeFortjenesteTxt.TabIndex = 15;
            this.TrommeFortjenesteTxt.Text = "Fortjeneste";
            // 
            // TrommeIndkøbsPrisTxt
            // 
            this.TrommeIndkøbsPrisTxt.Location = new System.Drawing.Point(27, 150);
            this.TrommeIndkøbsPrisTxt.Name = "TrommeIndkøbsPrisTxt";
            this.TrommeIndkøbsPrisTxt.Size = new System.Drawing.Size(100, 20);
            this.TrommeIndkøbsPrisTxt.TabIndex = 14;
            this.TrommeIndkøbsPrisTxt.Text = "Indkøbspris";
            // 
            // TrommeBeskrivelseTxt
            // 
            this.TrommeBeskrivelseTxt.Location = new System.Drawing.Point(27, 105);
            this.TrommeBeskrivelseTxt.Name = "TrommeBeskrivelseTxt";
            this.TrommeBeskrivelseTxt.Size = new System.Drawing.Size(100, 20);
            this.TrommeBeskrivelseTxt.TabIndex = 13;
            this.TrommeBeskrivelseTxt.Text = "Beskrivelse";
            // 
            // TrommenNavnTxt
            // 
            this.TrommenNavnTxt.Location = new System.Drawing.Point(27, 58);
            this.TrommenNavnTxt.Name = "TrommenNavnTxt";
            this.TrommenNavnTxt.Size = new System.Drawing.Size(100, 20);
            this.TrommenNavnTxt.TabIndex = 12;
            this.TrommenNavnTxt.Text = "Navn";
            // 
            // TrommeDataGrid
            // 
            this.TrommeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrommeDataGrid.Location = new System.Drawing.Point(251, 40);
            this.TrommeDataGrid.Name = "TrommeDataGrid";
            this.TrommeDataGrid.Size = new System.Drawing.Size(523, 370);
            this.TrommeDataGrid.TabIndex = 11;
            // 
            // TrommeSletBtn
            // 
            this.TrommeSletBtn.Location = new System.Drawing.Point(27, 375);
            this.TrommeSletBtn.Name = "TrommeSletBtn";
            this.TrommeSletBtn.Size = new System.Drawing.Size(75, 23);
            this.TrommeSletBtn.TabIndex = 20;
            this.TrommeSletBtn.Text = "Slet";
            this.TrommeSletBtn.UseVisualStyleBackColor = true;
            this.TrommeSletBtn.Click += new System.EventHandler(this.TrommeSletBtn_Click);
            // 
            // TilbageBtn
            // 
            this.TilbageBtn.Location = new System.Drawing.Point(27, 416);
            this.TilbageBtn.Name = "TilbageBtn";
            this.TilbageBtn.Size = new System.Drawing.Size(75, 23);
            this.TilbageBtn.TabIndex = 21;
            this.TilbageBtn.Text = "Tilbage til instrumentgrupper";
            this.TilbageBtn.UseVisualStyleBackColor = true;
            this.TilbageBtn.Click += new System.EventHandler(this.TilbageBtn_Click);
            // 
            // TrommeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TilbageBtn);
            this.Controls.Add(this.TrommeSletBtn);
            this.Controls.Add(this.TrommeOpdaterBtn);
            this.Controls.Add(this.TrommeOpretBtn);
            this.Controls.Add(this.TrommeProducent);
            this.Controls.Add(this.TrommeLagerDato);
            this.Controls.Add(this.TrommeFortjenesteTxt);
            this.Controls.Add(this.TrommeIndkøbsPrisTxt);
            this.Controls.Add(this.TrommeBeskrivelseTxt);
            this.Controls.Add(this.TrommenNavnTxt);
            this.Controls.Add(this.TrommeDataGrid);
            this.Name = "TrommeForm";
            this.Text = "TrommeForm";
            ((System.ComponentModel.ISupportInitialize)(this.TrommeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TrommeOpdaterBtn;
        private System.Windows.Forms.Button TrommeOpretBtn;
        private System.Windows.Forms.ComboBox TrommeProducent;
        private System.Windows.Forms.DateTimePicker TrommeLagerDato;
        private System.Windows.Forms.TextBox TrommeFortjenesteTxt;
        private System.Windows.Forms.TextBox TrommeIndkøbsPrisTxt;
        private System.Windows.Forms.TextBox TrommeBeskrivelseTxt;
        private System.Windows.Forms.TextBox TrommenNavnTxt;
        private System.Windows.Forms.DataGridView TrommeDataGrid;
        private System.Windows.Forms.Button TrommeSletBtn;
        private System.Windows.Forms.Button TilbageBtn;
    }
}