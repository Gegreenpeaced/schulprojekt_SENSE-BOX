
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblFrm1 = new System.Windows.Forms.Label();
            this.lblFrm2 = new System.Windows.Forms.Label();
            this.lblHum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFrmTemp = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.tbHum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 415);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // lblFrm1
            // 
            this.lblFrm1.AutoSize = true;
            this.lblFrm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrm1.Location = new System.Drawing.Point(82, 9);
            this.lblFrm1.Name = "lblFrm1";
            this.lblFrm1.Size = new System.Drawing.Size(319, 55);
            this.lblFrm1.TabIndex = 1;
            this.lblFrm1.Text = "Wetterstation:";
            // 
            // lblFrm2
            // 
            this.lblFrm2.AutoSize = true;
            this.lblFrm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrm2.Location = new System.Drawing.Point(12, 97);
            this.lblFrm2.Name = "lblFrm2";
            this.lblFrm2.Size = new System.Drawing.Size(81, 16);
            this.lblFrm2.TabIndex = 2;
            this.lblFrm2.Text = "Temperatur:";
            // 
            // lblHum
            // 
            this.lblHum.AutoSize = true;
            this.lblHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHum.Location = new System.Drawing.Point(12, 128);
            this.lblHum.Name = "lblHum";
            this.lblHum.Size = new System.Drawing.Size(63, 16);
            this.lblHum.TabIndex = 3;
            this.lblHum.Text = "Humidity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperatur:";
            // 
            // tbFrmTemp
            // 
            this.tbFrmTemp.Enabled = false;
            this.tbFrmTemp.Location = new System.Drawing.Point(99, 96);
            this.tbFrmTemp.Name = "tbFrmTemp";
            this.tbFrmTemp.ReadOnly = true;
            this.tbFrmTemp.Size = new System.Drawing.Size(100, 20);
            this.tbFrmTemp.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(412, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(99, 415);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(302, 23);
            this.btnGetData.TabIndex = 7;
            this.btnGetData.Text = "Daten Abfragen";
            this.btnGetData.UseVisualStyleBackColor = true;
            // 
            // tbHum
            // 
            this.tbHum.Enabled = false;
            this.tbHum.Location = new System.Drawing.Point(99, 127);
            this.tbHum.Name = "tbHum";
            this.tbHum.ReadOnly = true;
            this.tbHum.Size = new System.Drawing.Size(100, 20);
            this.tbHum.TabIndex = 8;
            // 
            // frmWetterstation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.tbHum);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbFrmTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHum);
            this.Controls.Add(this.lblFrm2);
            this.Controls.Add(this.lblFrm1);
            this.Controls.Add(this.btnSettings);
            this.Name = "frmWetterstation";
            this.Text = "Hauptformular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblFrm1;
        private System.Windows.Forms.Label lblFrm2;
        private System.Windows.Forms.Label lblHum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFrmTemp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.TextBox tbHum;
    }
}

