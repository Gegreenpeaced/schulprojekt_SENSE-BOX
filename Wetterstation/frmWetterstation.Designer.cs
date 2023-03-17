
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
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHum = new System.Windows.Forms.Label();
            this.lblPress = new System.Windows.Forms.Label();
            this.tbFrmTemp = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.tbFrmHum = new System.Windows.Forms.TextBox();
            this.lblUV = new System.Windows.Forms.Label();
            this.lblLight = new System.Windows.Forms.Label();
            this.tbFrmPress = new System.Windows.Forms.TextBox();
            this.tbFrmUV = new System.Windows.Forms.TextBox();
            this.tbFrmLight = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblapiApi = new System.Windows.Forms.Label();
            this.tbapiIP = new System.Windows.Forms.TextBox();
            this.gbDaten = new System.Windows.Forms.GroupBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.cbDataSource = new System.Windows.Forms.ComboBox();
            this.gbDaten.SuspendLayout();
            this.gbInfo.SuspendLayout();
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
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(14, 20);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(81, 16);
            this.lblTemp.TabIndex = 2;
            this.lblTemp.Text = "Temperatur:";
            // 
            // lblHum
            // 
            this.lblHum.AutoSize = true;
            this.lblHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHum.Location = new System.Drawing.Point(14, 46);
            this.lblHum.Name = "lblHum";
            this.lblHum.Size = new System.Drawing.Size(98, 16);
            this.lblHum.TabIndex = 3;
            this.lblHum.Text = "Luftfeuchtigkeit:";
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPress.Location = new System.Drawing.Point(14, 72);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(64, 16);
            this.lblPress.TabIndex = 4;
            this.lblPress.Text = "Luftdruck:";
            // 
            // tbFrmTemp
            // 
            this.tbFrmTemp.Enabled = false;
            this.tbFrmTemp.Location = new System.Drawing.Point(117, 19);
            this.tbFrmTemp.Name = "tbFrmTemp";
            this.tbFrmTemp.ReadOnly = true;
            this.tbFrmTemp.Size = new System.Drawing.Size(104, 20);
            this.tbFrmTemp.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(257, 253);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(230, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(12, 253);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(227, 23);
            this.btnGetData.TabIndex = 7;
            this.btnGetData.Text = "Daten Abfragen";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // tbFrmHum
            // 
            this.tbFrmHum.Enabled = false;
            this.tbFrmHum.Location = new System.Drawing.Point(117, 45);
            this.tbFrmHum.Name = "tbFrmHum";
            this.tbFrmHum.ReadOnly = true;
            this.tbFrmHum.Size = new System.Drawing.Size(104, 20);
            this.tbFrmHum.TabIndex = 8;
            // 
            // lblUV
            // 
            this.lblUV.AutoSize = true;
            this.lblUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUV.Location = new System.Drawing.Point(14, 98);
            this.lblUV.Name = "lblUV";
            this.lblUV.Size = new System.Drawing.Size(73, 16);
            this.lblUV.TabIndex = 9;
            this.lblUV.Text = "UV-Stärke:";
            // 
            // lblLight
            // 
            this.lblLight.AutoSize = true;
            this.lblLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLight.Location = new System.Drawing.Point(14, 124);
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(73, 16);
            this.lblLight.TabIndex = 10;
            this.lblLight.Text = "Lichteinfall:";
            // 
            // tbFrmPress
            // 
            this.tbFrmPress.Enabled = false;
            this.tbFrmPress.Location = new System.Drawing.Point(117, 71);
            this.tbFrmPress.Name = "tbFrmPress";
            this.tbFrmPress.ReadOnly = true;
            this.tbFrmPress.Size = new System.Drawing.Size(104, 20);
            this.tbFrmPress.TabIndex = 11;
            // 
            // tbFrmUV
            // 
            this.tbFrmUV.Enabled = false;
            this.tbFrmUV.Location = new System.Drawing.Point(117, 97);
            this.tbFrmUV.Name = "tbFrmUV";
            this.tbFrmUV.ReadOnly = true;
            this.tbFrmUV.Size = new System.Drawing.Size(104, 20);
            this.tbFrmUV.TabIndex = 12;
            // 
            // tbFrmLight
            // 
            this.tbFrmLight.Enabled = false;
            this.tbFrmLight.Location = new System.Drawing.Point(117, 123);
            this.tbFrmLight.Name = "tbFrmLight";
            this.tbFrmLight.ReadOnly = true;
            this.tbFrmLight.Size = new System.Drawing.Size(104, 20);
            this.tbFrmLight.TabIndex = 13;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(6, 127);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(118, 16);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "Letzte Abfrage um:";
            // 
            // lblapiApi
            // 
            this.lblapiApi.AutoSize = true;
            this.lblapiApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapiApi.Location = new System.Drawing.Point(6, 19);
            this.lblapiApi.Name = "lblapiApi";
            this.lblapiApi.Size = new System.Drawing.Size(84, 16);
            this.lblapiApi.TabIndex = 15;
            this.lblapiApi.Text = "Datenquelle:";
            // 
            // tbapiIP
            // 
            this.tbapiIP.Location = new System.Drawing.Point(95, 46);
            this.tbapiIP.Name = "tbapiIP";
            this.tbapiIP.Size = new System.Drawing.Size(129, 20);
            this.tbapiIP.TabIndex = 16;
            // 
            // gbDaten
            // 
            this.gbDaten.Controls.Add(this.tbFrmTemp);
            this.gbDaten.Controls.Add(this.lblTemp);
            this.gbDaten.Controls.Add(this.lblHum);
            this.gbDaten.Controls.Add(this.lblPress);
            this.gbDaten.Controls.Add(this.tbFrmLight);
            this.gbDaten.Controls.Add(this.tbFrmHum);
            this.gbDaten.Controls.Add(this.tbFrmUV);
            this.gbDaten.Controls.Add(this.lblUV);
            this.gbDaten.Controls.Add(this.tbFrmPress);
            this.gbDaten.Controls.Add(this.lblLight);
            this.gbDaten.Location = new System.Drawing.Point(12, 80);
            this.gbDaten.Name = "gbDaten";
            this.gbDaten.Size = new System.Drawing.Size(227, 152);
            this.gbDaten.TabIndex = 17;
            this.gbDaten.TabStop = false;
            this.gbDaten.Text = "Daten:";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblIP);
            this.gbInfo.Controls.Add(this.cbDataSource);
            this.gbInfo.Controls.Add(this.lblInfo);
            this.gbInfo.Controls.Add(this.tbapiIP);
            this.gbInfo.Controls.Add(this.lblapiApi);
            this.gbInfo.Location = new System.Drawing.Point(257, 80);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(230, 152);
            this.gbInfo.TabIndex = 18;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Einstellungen:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(6, 47);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(23, 16);
            this.lblIP.TabIndex = 17;
            this.lblIP.Text = "IP:";
            // 
            // cbDataSource
            // 
            this.cbDataSource.FormattingEnabled = true;
            this.cbDataSource.Items.AddRange(new object[] {
            "Markus-SenseBox",
            "IP-Adresse"});
            this.cbDataSource.Location = new System.Drawing.Point(95, 18);
            this.cbDataSource.Name = "cbDataSource";
            this.cbDataSource.Size = new System.Drawing.Size(129, 21);
            this.cbDataSource.TabIndex = 16;
            this.cbDataSource.SelectedIndexChanged += new System.EventHandler(this.cbDataSourceIndexChange);
            // 
            // frmWetterstation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 286);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbDaten);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFrm1);
            this.Name = "frmWetterstation";
            this.Text = "Hauptformular";
            this.gbDaten.ResumeLayout(false);
            this.gbDaten.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFrm1;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblHum;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.TextBox tbFrmTemp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.TextBox tbFrmHum;
        private System.Windows.Forms.Label lblUV;
        private System.Windows.Forms.Label lblLight;
        private System.Windows.Forms.TextBox tbFrmPress;
        private System.Windows.Forms.TextBox tbFrmUV;
        private System.Windows.Forms.TextBox tbFrmLight;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblapiApi;
        private System.Windows.Forms.TextBox tbapiIP;
        private System.Windows.Forms.GroupBox gbDaten;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.ComboBox cbDataSource;
        private System.Windows.Forms.Label lblIP;
    }
}

