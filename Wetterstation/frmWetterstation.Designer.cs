
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
            this.lblTemp.Location = new System.Drawing.Point(12, 102);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(80, 16);
            this.lblTemp.TabIndex = 2;
            this.lblTemp.Text = "Temperatur:";
            // 
            // lblHum
            // 
            this.lblHum.AutoSize = true;
            this.lblHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHum.Location = new System.Drawing.Point(12, 128);
            this.lblHum.Name = "lblHum";
            this.lblHum.Size = new System.Drawing.Size(62, 16);
            this.lblHum.TabIndex = 3;
            this.lblHum.Text = "Humidity:";
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPress.Location = new System.Drawing.Point(12, 154);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(64, 16);
            this.lblPress.TabIndex = 4;
            this.lblPress.Text = "Pressure:";
            // 
            // tbFrmTemp
            // 
            this.tbFrmTemp.Enabled = false;
            this.tbFrmTemp.Location = new System.Drawing.Point(99, 101);
            this.tbFrmTemp.Name = "tbFrmTemp";
            this.tbFrmTemp.ReadOnly = true;
            this.tbFrmTemp.Size = new System.Drawing.Size(100, 20);
            this.tbFrmTemp.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(257, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(230, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(12, 415);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(239, 23);
            this.btnGetData.TabIndex = 7;
            this.btnGetData.Text = "Daten Abfragen";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // tbFrmHum
            // 
            this.tbFrmHum.Enabled = false;
            this.tbFrmHum.Location = new System.Drawing.Point(99, 127);
            this.tbFrmHum.Name = "tbFrmHum";
            this.tbFrmHum.ReadOnly = true;
            this.tbFrmHum.Size = new System.Drawing.Size(100, 20);
            this.tbFrmHum.TabIndex = 8;
            // 
            // lblUV
            // 
            this.lblUV.AutoSize = true;
            this.lblUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUV.Location = new System.Drawing.Point(12, 180);
            this.lblUV.Name = "lblUV";
            this.lblUV.Size = new System.Drawing.Size(65, 16);
            this.lblUV.TabIndex = 9;
            this.lblUV.Text = "UV-Index:";
            // 
            // lblLight
            // 
            this.lblLight.AutoSize = true;
            this.lblLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLight.Location = new System.Drawing.Point(12, 206);
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(70, 16);
            this.lblLight.TabIndex = 10;
            this.lblLight.Text = "Lichtfaktor:";
            // 
            // tbFrmPress
            // 
            this.tbFrmPress.Enabled = false;
            this.tbFrmPress.Location = new System.Drawing.Point(99, 153);
            this.tbFrmPress.Name = "tbFrmPress";
            this.tbFrmPress.ReadOnly = true;
            this.tbFrmPress.Size = new System.Drawing.Size(100, 20);
            this.tbFrmPress.TabIndex = 11;
            // 
            // tbFrmUV
            // 
            this.tbFrmUV.Enabled = false;
            this.tbFrmUV.Location = new System.Drawing.Point(99, 179);
            this.tbFrmUV.Name = "tbFrmUV";
            this.tbFrmUV.ReadOnly = true;
            this.tbFrmUV.Size = new System.Drawing.Size(100, 20);
            this.tbFrmUV.TabIndex = 12;
            // 
            // tbFrmLight
            // 
            this.tbFrmLight.Enabled = false;
            this.tbFrmLight.Location = new System.Drawing.Point(99, 205);
            this.tbFrmLight.Name = "tbFrmLight";
            this.tbFrmLight.ReadOnly = true;
            this.tbFrmLight.Size = new System.Drawing.Size(100, 20);
            this.tbFrmLight.TabIndex = 13;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(263, 389);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(117, 16);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "Letzte Abfrage um:";
            // 
            // lblapiApi
            // 
            this.lblapiApi.AutoSize = true;
            this.lblapiApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapiApi.Location = new System.Drawing.Point(13, 390);
            this.lblapiApi.Name = "lblapiApi";
            this.lblapiApi.Size = new System.Drawing.Size(47, 16);
            this.lblapiApi.TabIndex = 15;
            this.lblapiApi.Text = "API-IP:";
            // 
            // tbapiIP
            // 
            this.tbapiIP.Location = new System.Drawing.Point(66, 389);
            this.tbapiIP.Name = "tbapiIP";
            this.tbapiIP.Size = new System.Drawing.Size(185, 20);
            this.tbapiIP.TabIndex = 16;
            // 
            // frmWetterstation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.tbapiIP);
            this.Controls.Add(this.lblapiApi);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tbFrmLight);
            this.Controls.Add(this.tbFrmUV);
            this.Controls.Add(this.tbFrmPress);
            this.Controls.Add(this.lblLight);
            this.Controls.Add(this.lblUV);
            this.Controls.Add(this.tbFrmHum);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbFrmTemp);
            this.Controls.Add(this.lblPress);
            this.Controls.Add(this.lblHum);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblFrm1);
            this.Name = "frmWetterstation";
            this.Text = "Hauptformular";
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
    }
}

