namespace WindowsFormsEsePreparazioneVerifica
{
    partial class FormFiglio1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.chkPelle = new System.Windows.Forms.CheckBox();
            this.chkStoffa = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chkPelle
            // 
            this.chkPelle.AutoSize = true;
            this.chkPelle.Location = new System.Drawing.Point(12, 12);
            this.chkPelle.Name = "chkPelle";
            this.chkPelle.Size = new System.Drawing.Size(91, 17);
            this.chkPelle.TabIndex = 0;
            this.chkPelle.Text = "Interni in pelle";
            this.chkPelle.UseVisualStyleBackColor = true;
            this.chkPelle.CheckedChanged += new System.EventHandler(this.chkPelle_CheckedChanged);
            // 
            // chkStoffa
            // 
            this.chkStoffa.AutoSize = true;
            this.chkStoffa.Location = new System.Drawing.Point(12, 35);
            this.chkStoffa.Name = "chkStoffa";
            this.chkStoffa.Size = new System.Drawing.Size(95, 17);
            this.chkStoffa.TabIndex = 1;
            this.chkStoffa.Text = "Interni in stoffa";
            this.chkStoffa.UseVisualStyleBackColor = true;
            this.chkStoffa.CheckedChanged += new System.EventHandler(this.chkStoffa_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BMW",
            "FIAT",
            "SEAT",
            "OPEL"});
            this.comboBox1.Location = new System.Drawing.Point(13, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormFiglio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(192, 115);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chkStoffa);
            this.Controls.Add(this.chkPelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFiglio1";
            this.Text = "FormFiglio1";
            this.Load += new System.EventHandler(this.FormFiglio1_Load);
            //this.ResumeLayout(false);
            //this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox chkPelle;
        private System.Windows.Forms.CheckBox chkStoffa;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}