﻿namespace Medici_Pacienti
{
    partial class FormMedic
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDataNastere = new System.Windows.Forms.DateTimePicker();
            this.cbSpec = new System.Windows.Forms.ComboBox();
            this.tbAn = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.renuntaBtn = new System.Windows.Forms.Button();
            this.adaugaBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 460);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data nastere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Specializare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "An absolvire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "CNP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nume";
            // 
            // dateDataNastere
            // 
            this.dateDataNastere.Location = new System.Drawing.Point(224, 460);
            this.dateDataNastere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateDataNastere.Name = "dateDataNastere";
            this.dateDataNastere.Size = new System.Drawing.Size(355, 26);
            this.dateDataNastere.TabIndex = 19;
            // 
            // cbSpec
            // 
            this.cbSpec.FormattingEnabled = true;
            this.cbSpec.Items.AddRange(new object[] {
            "Chirurgie Plastica",
            "Neurologie",
            "Cardiologie"});
            this.cbSpec.Location = new System.Drawing.Point(224, 355);
            this.cbSpec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSpec.Name = "cbSpec";
            this.cbSpec.Size = new System.Drawing.Size(355, 28);
            this.cbSpec.TabIndex = 18;
            // 
            // tbAn
            // 
            this.tbAn.Location = new System.Drawing.Point(224, 249);
            this.tbAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAn.Name = "tbAn";
            this.tbAn.Size = new System.Drawing.Size(355, 26);
            this.tbAn.TabIndex = 17;
            // 
            // tbCNP
            // 
            this.tbCNP.CausesValidation = false;
            this.tbCNP.Location = new System.Drawing.Point(224, 148);
            this.tbCNP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(355, 26);
            this.tbCNP.TabIndex = 16;
            this.tbCNP.Validating += new System.ComponentModel.CancelEventHandler(this.tbCNP_Validating);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(224, 57);
            this.tbNume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(355, 26);
            this.tbNume.TabIndex = 15;
            // 
            // renuntaBtn
            // 
            this.renuntaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.renuntaBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.renuntaBtn.Location = new System.Drawing.Point(416, 548);
            this.renuntaBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.renuntaBtn.Name = "renuntaBtn";
            this.renuntaBtn.Size = new System.Drawing.Size(165, 52);
            this.renuntaBtn.TabIndex = 21;
            this.renuntaBtn.Text = "Renunta";
            this.renuntaBtn.UseVisualStyleBackColor = false;
            // 
            // adaugaBtn
            // 
            this.adaugaBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.adaugaBtn.Location = new System.Drawing.Point(220, 548);
            this.adaugaBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adaugaBtn.Name = "adaugaBtn";
            this.adaugaBtn.Size = new System.Drawing.Size(123, 52);
            this.adaugaBtn.TabIndex = 20;
            this.adaugaBtn.Text = "Adauga";
            this.adaugaBtn.UseVisualStyleBackColor = true;
            this.adaugaBtn.Click += new System.EventHandler(this.adaugaBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 665);
            this.Controls.Add(this.renuntaBtn);
            this.Controls.Add(this.adaugaBtn);
            this.Controls.Add(this.dateDataNastere);
            this.Controls.Add(this.cbSpec);
            this.Controls.Add(this.tbAn);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMedic";
            this.Text = "FormMedic";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDataNastere;
        private System.Windows.Forms.ComboBox cbSpec;
        private System.Windows.Forms.TextBox tbAn;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Button renuntaBtn;
        private System.Windows.Forms.Button adaugaBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}