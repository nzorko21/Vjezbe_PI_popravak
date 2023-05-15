namespace Evaluation_Manager {
    partial class FrmEvauation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.MaskedTextBox();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPotpis = new System.Windows.Forms.Label();
            this.labelOcijena = new System.Windows.Forms.Label();
            this.labelOcjenjivac = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.labelDatum = new System.Windows.Forms.Label();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.labelBodovi = new System.Windows.Forms.Label();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(407, 51);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.Size = new System.Drawing.Size(142, 20);
            this.txtMinForSignature.TabIndex = 0;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(627, 51);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.Size = new System.Drawing.Size(116, 20);
            this.txtMinForGrade.TabIndex = 1;
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(57, 103);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(686, 179);
            this.txtActivityDescription.TabIndex = 2;
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(57, 50);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(119, 21);
            this.cboActivities.TabIndex = 4;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aktivnost";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPotpis
            // 
            this.labelPotpis.AutoSize = true;
            this.labelPotpis.Location = new System.Drawing.Point(404, 25);
            this.labelPotpis.Name = "labelPotpis";
            this.labelPotpis.Size = new System.Drawing.Size(79, 13);
            this.labelPotpis.TabIndex = 6;
            this.labelPotpis.Text = "Uvijet za potpis";
            this.labelPotpis.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelOcijena
            // 
            this.labelOcijena.AutoSize = true;
            this.labelOcijena.Location = new System.Drawing.Point(624, 25);
            this.labelOcijena.Name = "labelOcijena";
            this.labelOcijena.Size = new System.Drawing.Size(85, 13);
            this.labelOcijena.TabIndex = 7;
            this.labelOcijena.Text = "Uvijet za ocijenu";
            // 
            // labelOcjenjivac
            // 
            this.labelOcjenjivac.AutoSize = true;
            this.labelOcjenjivac.Location = new System.Drawing.Point(381, 298);
            this.labelOcjenjivac.Name = "labelOcjenjivac";
            this.labelOcjenjivac.Size = new System.Drawing.Size(59, 13);
            this.labelOcjenjivac.TabIndex = 8;
            this.labelOcjenjivac.Text = "Ocijenjivač";
            this.labelOcjenjivac.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(384, 323);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(113, 20);
            this.txtTeacher.TabIndex = 9;
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(536, 298);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(89, 13);
            this.labelDatum.TabIndex = 10;
            this.labelDatum.Text = "Datum evaluacije";
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(539, 323);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.Size = new System.Drawing.Size(121, 20);
            this.txtEvaluationDate.TabIndex = 11;
            // 
            // labelBodovi
            // 
            this.labelBodovi.AutoSize = true;
            this.labelBodovi.Location = new System.Drawing.Point(684, 298);
            this.labelBodovi.Name = "labelBodovi";
            this.labelBodovi.Size = new System.Drawing.Size(40, 13);
            this.labelBodovi.TabIndex = 12;
            this.labelBodovi.Text = "Bodovi";
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(684, 323);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(59, 20);
            this.numPoints.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(523, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 29);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(647, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 27);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmEvauation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.labelBodovi);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.labelOcjenjivac);
            this.Controls.Add(this.labelOcijena);
            this.Controls.Add(this.labelPotpis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Name = "FrmEvauation";
            this.Text = "FrmEvauation";
            this.Load += new System.EventHandler(this.FrmEvauation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.MaskedTextBox txtMinForGrade;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPotpis;
        private System.Windows.Forms.Label labelOcijena;
        private System.Windows.Forms.Label labelOcjenjivac;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.Label labelBodovi;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}