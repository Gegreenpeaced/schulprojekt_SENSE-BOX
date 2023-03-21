
namespace Wetterstation
{
    partial class frmWetterstation
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFrm1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.gbDaten = new System.Windows.Forms.GroupBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblFrm1
            // 
            this.lblFrm1.AutoSize = true;
            this.lblFrm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrm1.Location = new System.Drawing.Point(89, 9);
            this.lblFrm1.Name = "lblFrm1";
            this.lblFrm1.Size = new System.Drawing.Size(306, 55);
            this.lblFrm1.TabIndex = 1;
            this.lblFrm1.Text = "Wetterstation";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(257, 347);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(230, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(12, 347);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(227, 23);
            this.btnGetData.TabIndex = 7;
            this.btnGetData.Text = "Daten Abfragen";
            this.btnGetData.UseVisualStyleBackColor = true;
            // 
            // gbDaten
            // 
            this.gbDaten.Location = new System.Drawing.Point(12, 80);
            this.gbDaten.Name = "gbDaten";
            this.gbDaten.Size = new System.Drawing.Size(227, 261);
            this.gbDaten.TabIndex = 17;
            this.gbDaten.TabStop = false;
            this.gbDaten.Text = "Daten:";
            // 
            // gbInfo
            // 
            this.gbInfo.Location = new System.Drawing.Point(257, 80);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(230, 261);
            this.gbInfo.TabIndex = 18;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Einstellungen:";
            // 
            // frmWetterstation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 382);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbDaten);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFrm1);
            this.Name = "frmWetterstation";
            this.Text = "Hauptformular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFrm1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.GroupBox gbDaten;
        private System.Windows.Forms.GroupBox gbInfo;
    }
}

