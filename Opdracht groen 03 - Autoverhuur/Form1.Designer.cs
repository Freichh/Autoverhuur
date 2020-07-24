namespace Opdracht_groen_03___Autoverhuur
{
    partial class Form1
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
            this.radioButtonAuto = new System.Windows.Forms.RadioButton();
            this.radioButtonBusje = new System.Windows.Forms.RadioButton();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEind = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownLiters = new System.Windows.Forms.NumericUpDown();
            this.buttonBereken = new System.Windows.Forms.Button();
            this.textBoxTotaalbedrag = new System.Windows.Forms.TextBox();
            this.labelBegindatum = new System.Windows.Forms.Label();
            this.labelEinddatum = new System.Windows.Forms.Label();
            this.labelGetankt = new System.Windows.Forms.Label();
            this.labelLiterprijs = new System.Windows.Forms.Label();
            this.LabelTotaalbedrag = new System.Windows.Forms.Label();
            this.numericUpDownLiterprijs = new System.Windows.Forms.NumericUpDown();
            this.labelGereden = new System.Windows.Forms.Label();
            this.numericUpDownKilometers = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiterprijs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKilometers)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonAuto
            // 
            this.radioButtonAuto.AutoSize = true;
            this.radioButtonAuto.Location = new System.Drawing.Point(64, 30);
            this.radioButtonAuto.Name = "radioButtonAuto";
            this.radioButtonAuto.Size = new System.Drawing.Size(58, 21);
            this.radioButtonAuto.TabIndex = 0;
            this.radioButtonAuto.TabStop = true;
            this.radioButtonAuto.Text = "Auto";
            this.radioButtonAuto.UseVisualStyleBackColor = true;
            this.radioButtonAuto.CheckedChanged += new System.EventHandler(this.radioButtonAuto_CheckedChanged);
            // 
            // radioButtonBusje
            // 
            this.radioButtonBusje.AutoSize = true;
            this.radioButtonBusje.Location = new System.Drawing.Point(159, 30);
            this.radioButtonBusje.Name = "radioButtonBusje";
            this.radioButtonBusje.Size = new System.Drawing.Size(64, 21);
            this.radioButtonBusje.TabIndex = 1;
            this.radioButtonBusje.Text = "Busje";
            this.radioButtonBusje.UseVisualStyleBackColor = true;
            this.radioButtonBusje.CheckedChanged += new System.EventHandler(this.radioButtonBusje_CheckedChanged);
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Location = new System.Drawing.Point(159, 93);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(229, 22);
            this.dateTimePickerBegin.TabIndex = 2;
            this.dateTimePickerBegin.ValueChanged += new System.EventHandler(this.dateTimePickerBegin_ValueChanged);
            // 
            // dateTimePickerEind
            // 
            this.dateTimePickerEind.Location = new System.Drawing.Point(546, 93);
            this.dateTimePickerEind.Name = "dateTimePickerEind";
            this.dateTimePickerEind.Size = new System.Drawing.Size(232, 22);
            this.dateTimePickerEind.TabIndex = 3;
            this.dateTimePickerEind.ValueChanged += new System.EventHandler(this.dateTimePickerEind_ValueChanged);
            // 
            // numericUpDownLiters
            // 
            this.numericUpDownLiters.Location = new System.Drawing.Point(159, 209);
            this.numericUpDownLiters.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLiters.Name = "numericUpDownLiters";
            this.numericUpDownLiters.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLiters.TabIndex = 5;
            this.numericUpDownLiters.ValueChanged += new System.EventHandler(this.numericUpDownLiters_ValueChanged);
            // 
            // buttonBereken
            // 
            this.buttonBereken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBereken.Location = new System.Drawing.Point(45, 293);
            this.buttonBereken.Name = "buttonBereken";
            this.buttonBereken.Size = new System.Drawing.Size(155, 43);
            this.buttonBereken.TabIndex = 7;
            this.buttonBereken.Text = "Bereken totaal";
            this.buttonBereken.UseVisualStyleBackColor = true;
            this.buttonBereken.Click += new System.EventHandler(this.buttonBereken_Click);
            // 
            // textBoxTotaalbedrag
            // 
            this.textBoxTotaalbedrag.Location = new System.Drawing.Point(234, 312);
            this.textBoxTotaalbedrag.Name = "textBoxTotaalbedrag";
            this.textBoxTotaalbedrag.Size = new System.Drawing.Size(100, 22);
            this.textBoxTotaalbedrag.TabIndex = 8;
            // 
            // labelBegindatum
            // 
            this.labelBegindatum.AutoSize = true;
            this.labelBegindatum.Location = new System.Drawing.Point(39, 93);
            this.labelBegindatum.Name = "labelBegindatum";
            this.labelBegindatum.Size = new System.Drawing.Size(83, 17);
            this.labelBegindatum.TabIndex = 8;
            this.labelBegindatum.Text = "Begindatum";
            // 
            // labelEinddatum
            // 
            this.labelEinddatum.AutoSize = true;
            this.labelEinddatum.Location = new System.Drawing.Point(440, 93);
            this.labelEinddatum.Name = "labelEinddatum";
            this.labelEinddatum.Size = new System.Drawing.Size(75, 17);
            this.labelEinddatum.TabIndex = 8;
            this.labelEinddatum.Text = "Einddatum";
            // 
            // labelGetankt
            // 
            this.labelGetankt.AutoSize = true;
            this.labelGetankt.Location = new System.Drawing.Point(42, 208);
            this.labelGetankt.Name = "labelGetankt";
            this.labelGetankt.Size = new System.Drawing.Size(80, 17);
            this.labelGetankt.TabIndex = 9;
            this.labelGetankt.Text = "Getankt (L)";
            // 
            // labelLiterprijs
            // 
            this.labelLiterprijs.AutoSize = true;
            this.labelLiterprijs.Location = new System.Drawing.Point(441, 209);
            this.labelLiterprijs.Name = "labelLiterprijs";
            this.labelLiterprijs.Size = new System.Drawing.Size(74, 17);
            this.labelLiterprijs.TabIndex = 10;
            this.labelLiterprijs.Text = "Literprijs €";
            // 
            // LabelTotaalbedrag
            // 
            this.LabelTotaalbedrag.AutoSize = true;
            this.LabelTotaalbedrag.Location = new System.Drawing.Point(231, 291);
            this.LabelTotaalbedrag.Name = "LabelTotaalbedrag";
            this.LabelTotaalbedrag.Size = new System.Drawing.Size(93, 17);
            this.LabelTotaalbedrag.TabIndex = 11;
            this.LabelTotaalbedrag.Text = "Totaalbedrag";
            // 
            // numericUpDownLiterprijs
            // 
            this.numericUpDownLiterprijs.Location = new System.Drawing.Point(546, 208);
            this.numericUpDownLiterprijs.Name = "numericUpDownLiterprijs";
            this.numericUpDownLiterprijs.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLiterprijs.TabIndex = 6;
            this.numericUpDownLiterprijs.ValueChanged += new System.EventHandler(this.numericUpDownLiterprijs_ValueChanged);
            // 
            // labelGereden
            // 
            this.labelGereden.AutoSize = true;
            this.labelGereden.Location = new System.Drawing.Point(24, 152);
            this.labelGereden.Name = "labelGereden";
            this.labelGereden.Size = new System.Drawing.Size(98, 17);
            this.labelGereden.TabIndex = 14;
            this.labelGereden.Text = "Gereden (KM)";
            // 
            // numericUpDownKilometers
            // 
            this.numericUpDownKilometers.Location = new System.Drawing.Point(159, 152);
            this.numericUpDownKilometers.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownKilometers.Name = "numericUpDownKilometers";
            this.numericUpDownKilometers.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownKilometers.TabIndex = 4;
            this.numericUpDownKilometers.ValueChanged += new System.EventHandler(this.numericUpDownKilometers_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGereden);
            this.Controls.Add(this.numericUpDownKilometers);
            this.Controls.Add(this.numericUpDownLiterprijs);
            this.Controls.Add(this.LabelTotaalbedrag);
            this.Controls.Add(this.labelLiterprijs);
            this.Controls.Add(this.labelGetankt);
            this.Controls.Add(this.labelEinddatum);
            this.Controls.Add(this.labelBegindatum);
            this.Controls.Add(this.textBoxTotaalbedrag);
            this.Controls.Add(this.buttonBereken);
            this.Controls.Add(this.numericUpDownLiters);
            this.Controls.Add(this.dateTimePickerEind);
            this.Controls.Add(this.dateTimePickerBegin);
            this.Controls.Add(this.radioButtonBusje);
            this.Controls.Add(this.radioButtonAuto);
            this.Name = "Form1";
            this.Text = "Autoverhuur Kosten - Freek Heining";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLiterprijs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKilometers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAuto;
        private System.Windows.Forms.RadioButton radioButtonBusje;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.DateTimePicker dateTimePickerEind;
        private System.Windows.Forms.NumericUpDown numericUpDownLiters;
        private System.Windows.Forms.Button buttonBereken;
        private System.Windows.Forms.TextBox textBoxTotaalbedrag;
        private System.Windows.Forms.Label labelBegindatum;
        private System.Windows.Forms.Label labelEinddatum;
        private System.Windows.Forms.Label labelGetankt;
        private System.Windows.Forms.Label labelLiterprijs;
        private System.Windows.Forms.Label LabelTotaalbedrag;
        private System.Windows.Forms.NumericUpDown numericUpDownLiterprijs;
        private System.Windows.Forms.Label labelGereden;
        private System.Windows.Forms.NumericUpDown numericUpDownKilometers;
    }
}

