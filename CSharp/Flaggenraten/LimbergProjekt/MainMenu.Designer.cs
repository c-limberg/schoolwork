namespace LimbergProjekt
{
    partial class MainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startGameBt = new System.Windows.Forms.Button();
            this.creditBt = new System.Windows.Forms.Button();
            this.scoreBt = new System.Windows.Forms.Button();
            this.gameVerLb = new System.Windows.Forms.Label();
            this.musicOn = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.startGameBt);
            this.panel1.Controls.Add(this.creditBt);
            this.panel1.Controls.Add(this.scoreBt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 339);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Geo-Quiz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LimbergProjekt.Properties.Resources.menumap;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // startGameBt
            // 
            this.startGameBt.Location = new System.Drawing.Point(104, 223);
            this.startGameBt.Name = "startGameBt";
            this.startGameBt.Size = new System.Drawing.Size(131, 31);
            this.startGameBt.TabIndex = 0;
            this.startGameBt.Text = "Spielen";
            this.startGameBt.UseVisualStyleBackColor = true;
            this.startGameBt.Click += new System.EventHandler(this.startGameBt_Click);
            // 
            // creditBt
            // 
            this.creditBt.Location = new System.Drawing.Point(104, 297);
            this.creditBt.Name = "creditBt";
            this.creditBt.Size = new System.Drawing.Size(131, 31);
            this.creditBt.TabIndex = 2;
            this.creditBt.Text = "Credits";
            this.creditBt.UseVisualStyleBackColor = true;
            this.creditBt.Click += new System.EventHandler(this.creditBt_Click);
            // 
            // scoreBt
            // 
            this.scoreBt.Location = new System.Drawing.Point(104, 260);
            this.scoreBt.Name = "scoreBt";
            this.scoreBt.Size = new System.Drawing.Size(131, 31);
            this.scoreBt.TabIndex = 1;
            this.scoreBt.Text = "High Scores";
            this.scoreBt.UseVisualStyleBackColor = true;
            this.scoreBt.Click += new System.EventHandler(this.scoreBt_Click);
            // 
            // gameVerLb
            // 
            this.gameVerLb.AutoSize = true;
            this.gameVerLb.Location = new System.Drawing.Point(12, 366);
            this.gameVerLb.Name = "gameVerLb";
            this.gameVerLb.Size = new System.Drawing.Size(102, 17);
            this.gameVerLb.TabIndex = 4;
            this.gameVerLb.Text = "Game Version:";
            // 
            // musicOn
            // 
            this.musicOn.AutoSize = true;
            this.musicOn.Location = new System.Drawing.Point(292, 6);
            this.musicOn.Name = "musicOn";
            this.musicOn.Size = new System.Drawing.Size(66, 21);
            this.musicOn.TabIndex = 7;
            this.musicOn.Text = "Musik";
            this.musicOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.musicOn.UseVisualStyleBackColor = true;
            this.musicOn.CheckedChanged += new System.EventHandler(this.musicOn_CheckedChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 392);
            this.Controls.Add(this.musicOn);
            this.Controls.Add(this.gameVerLb);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hauptmenü";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gameVerLb;
        private System.Windows.Forms.Button creditBt;
        private System.Windows.Forms.Button scoreBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startGameBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox musicOn;
    }
}

