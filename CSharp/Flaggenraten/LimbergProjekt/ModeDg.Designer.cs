namespace LimbergProjekt
{
    partial class ModeDg
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
            this.flagToCapBt = new System.Windows.Forms.Button();
            this.capToFlagBt = new System.Windows.Forms.Button();
            this.countryToFlagBt = new System.Windows.Forms.Button();
            this.flagToCountryBt = new System.Windows.Forms.Button();
            this.capToCountryBt = new System.Windows.Forms.Button();
            this.countryToCapBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flagToCapBt
            // 
            this.flagToCapBt.Location = new System.Drawing.Point(289, 193);
            this.flagToCapBt.Name = "flagToCapBt";
            this.flagToCapBt.Size = new System.Drawing.Size(175, 74);
            this.flagToCapBt.TabIndex = 5;
            this.flagToCapBt.Text = "Flaggen -> Hauptstädte";
            this.flagToCapBt.UseVisualStyleBackColor = true;
            this.flagToCapBt.Click += new System.EventHandler(this.flagToCapBt_Click);
            // 
            // capToFlagBt
            // 
            this.capToFlagBt.Location = new System.Drawing.Point(289, 103);
            this.capToFlagBt.Name = "capToFlagBt";
            this.capToFlagBt.Size = new System.Drawing.Size(175, 74);
            this.capToFlagBt.TabIndex = 4;
            this.capToFlagBt.Text = "Hauptstädte -> Flaggen";
            this.capToFlagBt.UseVisualStyleBackColor = true;
            this.capToFlagBt.Click += new System.EventHandler(this.capToFlagBt_Click);
            // 
            // countryToFlagBt
            // 
            this.countryToFlagBt.Location = new System.Drawing.Point(289, 12);
            this.countryToFlagBt.Name = "countryToFlagBt";
            this.countryToFlagBt.Size = new System.Drawing.Size(175, 74);
            this.countryToFlagBt.TabIndex = 3;
            this.countryToFlagBt.Text = "Länder -> Flaggen";
            this.countryToFlagBt.UseVisualStyleBackColor = true;
            this.countryToFlagBt.Click += new System.EventHandler(this.countryToFlagBt_Click);
            // 
            // flagToCountryBt
            // 
            this.flagToCountryBt.Location = new System.Drawing.Point(12, 193);
            this.flagToCountryBt.Name = "flagToCountryBt";
            this.flagToCountryBt.Size = new System.Drawing.Size(175, 74);
            this.flagToCountryBt.TabIndex = 2;
            this.flagToCountryBt.Text = "Flaggen -> Länder";
            this.flagToCountryBt.UseVisualStyleBackColor = true;
            this.flagToCountryBt.Click += new System.EventHandler(this.flagToCountryBt_Click);
            // 
            // capToCountryBt
            // 
            this.capToCountryBt.Location = new System.Drawing.Point(12, 103);
            this.capToCountryBt.Name = "capToCountryBt";
            this.capToCountryBt.Size = new System.Drawing.Size(175, 74);
            this.capToCountryBt.TabIndex = 1;
            this.capToCountryBt.Text = "Hauptstädte -> Länder";
            this.capToCountryBt.UseVisualStyleBackColor = true;
            this.capToCountryBt.Click += new System.EventHandler(this.capToCountryBt_Click);
            // 
            // countryToCapBt
            // 
            this.countryToCapBt.Location = new System.Drawing.Point(12, 12);
            this.countryToCapBt.Name = "countryToCapBt";
            this.countryToCapBt.Size = new System.Drawing.Size(175, 74);
            this.countryToCapBt.TabIndex = 0;
            this.countryToCapBt.Text = "Länder -> Hauptstädte";
            this.countryToCapBt.UseVisualStyleBackColor = true;
            this.countryToCapBt.Click += new System.EventHandler(this.countryToCapBt_Click);
            // 
            // ModeDg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 288);
            this.Controls.Add(this.flagToCapBt);
            this.Controls.Add(this.capToFlagBt);
            this.Controls.Add(this.countryToFlagBt);
            this.Controls.Add(this.flagToCountryBt);
            this.Controls.Add(this.capToCountryBt);
            this.Controls.Add(this.countryToCapBt);
            this.Name = "ModeDg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModeDg";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button flagToCapBt;
        private System.Windows.Forms.Button capToFlagBt;
        private System.Windows.Forms.Button countryToFlagBt;
        private System.Windows.Forms.Button flagToCountryBt;
        private System.Windows.Forms.Button capToCountryBt;
        private System.Windows.Forms.Button countryToCapBt;
    }
}