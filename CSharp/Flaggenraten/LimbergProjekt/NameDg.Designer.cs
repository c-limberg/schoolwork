namespace LimbergProjekt
{
    partial class NameDg
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitNameBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(12, 59);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(270, 22);
            this.nameInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gebe deinen Spielernamen ein!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitNameBt
            // 
            this.submitNameBt.Location = new System.Drawing.Point(113, 97);
            this.submitNameBt.Name = "submitNameBt";
            this.submitNameBt.Size = new System.Drawing.Size(75, 38);
            this.submitNameBt.TabIndex = 1;
            this.submitNameBt.Text = "OK";
            this.submitNameBt.UseVisualStyleBackColor = true;
            this.submitNameBt.Click += new System.EventHandler(this.submitNameBt_Click);
            // 
            // NameDg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 168);
            this.Controls.Add(this.submitNameBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameInput);
            this.Name = "NameDg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NameDg_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitNameBt;
    }
}