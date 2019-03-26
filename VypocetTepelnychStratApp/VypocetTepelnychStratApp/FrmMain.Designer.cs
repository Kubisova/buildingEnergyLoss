namespace VypocetTepelnychStratApp
{
    partial class FrmMain
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameAndSurname = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCountryType = new System.Windows.Forms.Label();
            this.grpCountryType = new System.Windows.Forms.GroupBox();
            this.rdnWindy = new System.Windows.Forms.RadioButton();
            this.rdnNormal = new System.Windows.Forms.RadioButton();
            this.lblBuildingType = new System.Windows.Forms.Label();
            this.grpBuildingType = new System.Windows.Forms.GroupBox();
            this.rdnVeryNegative = new System.Windows.Forms.RadioButton();
            this.rdnNotProtected = new System.Windows.Forms.RadioButton();
            this.rdnProtected = new System.Windows.Forms.RadioButton();
            this.lblBuildingWidth = new System.Windows.Forms.Label();
            this.lblBuildingLength = new System.Windows.Forms.Label();
            this.lblBuildingHeigth = new System.Windows.Forms.Label();
            this.txtBuildingWidth = new System.Windows.Forms.TextBox();
            this.txtBuildingLength = new System.Windows.Forms.TextBox();
            this.txtBuildingHeight = new System.Windows.Forms.TextBox();
            this.lblMinOutTemperature = new System.Windows.Forms.Label();
            this.lblInnerTemperature = new System.Windows.Forms.Label();
            this.lblWindowsArea = new System.Windows.Forms.Label();
            this.txtWindowsSurrface = new System.Windows.Forms.TextBox();
            this.txtMinOuterTemperature = new System.Windows.Forms.TextBox();
            this.txtInnerTemperature = new System.Windows.Forms.TextBox();
            this.cmbFloorsMaterials1 = new System.Windows.Forms.ComboBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.cmbFloorsMaterials2 = new System.Windows.Forms.ComboBox();
            this.cmbFloorsMaterials3 = new System.Windows.Forms.ComboBox();
            this.cmbFloorMaterials4 = new System.Windows.Forms.ComboBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtFloorWidth1 = new System.Windows.Forms.TextBox();
            this.txtFloorWidth4 = new System.Windows.Forms.TextBox();
            this.txtFloorWidth3 = new System.Windows.Forms.TextBox();
            this.txtFloorWidth2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpCountryType.SuspendLayout();
            this.grpBuildingType.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Názov";
            // 
            // lblNameAndSurname
            // 
            this.lblNameAndSurname.AutoSize = true;
            this.lblNameAndSurname.Location = new System.Drawing.Point(50, 55);
            this.lblNameAndSurname.Name = "lblNameAndSurname";
            this.lblNameAndSurname.Size = new System.Drawing.Size(93, 13);
            this.lblNameAndSurname.TabIndex = 2;
            this.lblNameAndSurname.Text = "Meno a priezvisko";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblCountryType
            // 
            this.lblCountryType.AutoSize = true;
            this.lblCountryType.Location = new System.Drawing.Point(50, 102);
            this.lblCountryType.Name = "lblCountryType";
            this.lblCountryType.Size = new System.Drawing.Size(58, 13);
            this.lblCountryType.TabIndex = 4;
            this.lblCountryType.Text = "Typ krajiny";
            // 
            // grpCountryType
            // 
            this.grpCountryType.Controls.Add(this.rdnWindy);
            this.grpCountryType.Controls.Add(this.rdnNormal);
            this.grpCountryType.Location = new System.Drawing.Point(160, 78);
            this.grpCountryType.Name = "grpCountryType";
            this.grpCountryType.Size = new System.Drawing.Size(100, 61);
            this.grpCountryType.TabIndex = 5;
            this.grpCountryType.TabStop = false;
            // 
            // rdnWindy
            // 
            this.rdnWindy.AutoSize = true;
            this.rdnWindy.Location = new System.Drawing.Point(7, 33);
            this.rdnWindy.Name = "rdnWindy";
            this.rdnWindy.Size = new System.Drawing.Size(62, 17);
            this.rdnWindy.TabIndex = 1;
            this.rdnWindy.TabStop = true;
            this.rdnWindy.Text = "Veterná";
            this.rdnWindy.UseVisualStyleBackColor = true;
            // 
            // rdnNormal
            // 
            this.rdnNormal.AutoSize = true;
            this.rdnNormal.Location = new System.Drawing.Point(7, 10);
            this.rdnNormal.Name = "rdnNormal";
            this.rdnNormal.Size = new System.Drawing.Size(70, 17);
            this.rdnNormal.TabIndex = 0;
            this.rdnNormal.TabStop = true;
            this.rdnNormal.Text = "Normálna";
            this.rdnNormal.UseVisualStyleBackColor = true;
            // 
            // lblBuildingType
            // 
            this.lblBuildingType.AutoSize = true;
            this.lblBuildingType.Location = new System.Drawing.Point(50, 154);
            this.lblBuildingType.Name = "lblBuildingType";
            this.lblBuildingType.Size = new System.Drawing.Size(63, 13);
            this.lblBuildingType.TabIndex = 6;
            this.lblBuildingType.Text = "Typ budovy";
            // 
            // grpBuildingType
            // 
            this.grpBuildingType.Controls.Add(this.rdnVeryNegative);
            this.grpBuildingType.Controls.Add(this.rdnNotProtected);
            this.grpBuildingType.Controls.Add(this.rdnProtected);
            this.grpBuildingType.Location = new System.Drawing.Point(160, 145);
            this.grpBuildingType.Name = "grpBuildingType";
            this.grpBuildingType.Size = new System.Drawing.Size(117, 85);
            this.grpBuildingType.TabIndex = 7;
            this.grpBuildingType.TabStop = false;
            // 
            // rdnVeryNegative
            // 
            this.rdnVeryNegative.AutoSize = true;
            this.rdnVeryNegative.Location = new System.Drawing.Point(7, 56);
            this.rdnVeryNegative.Name = "rdnVeryNegative";
            this.rdnVeryNegative.Size = new System.Drawing.Size(109, 17);
            this.rdnVeryNegative.TabIndex = 2;
            this.rdnVeryNegative.TabStop = true;
            this.rdnVeryNegative.Text = "Veľmi nepriaznivá";
            this.rdnVeryNegative.UseVisualStyleBackColor = true;
            // 
            // rdnNotProtected
            // 
            this.rdnNotProtected.AutoSize = true;
            this.rdnNotProtected.Location = new System.Drawing.Point(7, 33);
            this.rdnNotProtected.Name = "rdnNotProtected";
            this.rdnNotProtected.Size = new System.Drawing.Size(84, 17);
            this.rdnNotProtected.TabIndex = 1;
            this.rdnNotProtected.TabStop = true;
            this.rdnNotProtected.Text = "Nechránená";
            this.rdnNotProtected.UseVisualStyleBackColor = true;
            // 
            // rdnProtected
            // 
            this.rdnProtected.AutoSize = true;
            this.rdnProtected.Location = new System.Drawing.Point(6, 10);
            this.rdnProtected.Name = "rdnProtected";
            this.rdnProtected.Size = new System.Drawing.Size(71, 17);
            this.rdnProtected.TabIndex = 0;
            this.rdnProtected.TabStop = true;
            this.rdnProtected.Text = "Chránená";
            this.rdnProtected.UseVisualStyleBackColor = true;
            // 
            // lblBuildingWidth
            // 
            this.lblBuildingWidth.AutoSize = true;
            this.lblBuildingWidth.Location = new System.Drawing.Point(53, 236);
            this.lblBuildingWidth.Name = "lblBuildingWidth";
            this.lblBuildingWidth.Size = new System.Drawing.Size(71, 13);
            this.lblBuildingWidth.TabIndex = 8;
            this.lblBuildingWidth.Text = "Šírka budovy";
            // 
            // lblBuildingLength
            // 
            this.lblBuildingLength.AutoSize = true;
            this.lblBuildingLength.Location = new System.Drawing.Point(53, 266);
            this.lblBuildingLength.Name = "lblBuildingLength";
            this.lblBuildingLength.Size = new System.Drawing.Size(73, 13);
            this.lblBuildingLength.TabIndex = 9;
            this.lblBuildingLength.Text = "Dĺžka budovy";
            // 
            // lblBuildingHeigth
            // 
            this.lblBuildingHeigth.AutoSize = true;
            this.lblBuildingHeigth.Location = new System.Drawing.Point(53, 295);
            this.lblBuildingHeigth.Name = "lblBuildingHeigth";
            this.lblBuildingHeigth.Size = new System.Drawing.Size(74, 13);
            this.lblBuildingHeigth.TabIndex = 10;
            this.lblBuildingHeigth.Text = "Výška budovy";
            // 
            // txtBuildingWidth
            // 
            this.txtBuildingWidth.Location = new System.Drawing.Point(160, 236);
            this.txtBuildingWidth.Name = "txtBuildingWidth";
            this.txtBuildingWidth.Size = new System.Drawing.Size(100, 20);
            this.txtBuildingWidth.TabIndex = 11;
            // 
            // txtBuildingLength
            // 
            this.txtBuildingLength.Location = new System.Drawing.Point(160, 266);
            this.txtBuildingLength.Name = "txtBuildingLength";
            this.txtBuildingLength.Size = new System.Drawing.Size(100, 20);
            this.txtBuildingLength.TabIndex = 12;
            // 
            // txtBuildingHeight
            // 
            this.txtBuildingHeight.Location = new System.Drawing.Point(160, 295);
            this.txtBuildingHeight.Name = "txtBuildingHeight";
            this.txtBuildingHeight.Size = new System.Drawing.Size(100, 20);
            this.txtBuildingHeight.TabIndex = 13;
            // 
            // lblMinOutTemperature
            // 
            this.lblMinOutTemperature.AutoSize = true;
            this.lblMinOutTemperature.Location = new System.Drawing.Point(53, 349);
            this.lblMinOutTemperature.Name = "lblMinOutTemperature";
            this.lblMinOutTemperature.Size = new System.Drawing.Size(137, 13);
            this.lblMinOutTemperature.TabIndex = 14;
            this.lblMinOutTemperature.Text = "Minimálna vonkajšia teplota";
            // 
            // lblInnerTemperature
            // 
            this.lblInnerTemperature.AutoSize = true;
            this.lblInnerTemperature.Location = new System.Drawing.Point(53, 373);
            this.lblInnerTemperature.Name = "lblInnerTemperature";
            this.lblInnerTemperature.Size = new System.Drawing.Size(85, 13);
            this.lblInnerTemperature.TabIndex = 15;
            this.lblInnerTemperature.Text = "Vnútorná teplota";
            // 
            // lblWindowsArea
            // 
            this.lblWindowsArea.AutoSize = true;
            this.lblWindowsArea.Location = new System.Drawing.Point(300, 236);
            this.lblWindowsArea.Name = "lblWindowsArea";
            this.lblWindowsArea.Size = new System.Drawing.Size(69, 13);
            this.lblWindowsArea.TabIndex = 16;
            this.lblWindowsArea.Text = "Plocha okien";
            // 
            // txtWindowsSurrface
            // 
            this.txtWindowsSurrface.Location = new System.Drawing.Point(375, 233);
            this.txtWindowsSurrface.Name = "txtWindowsSurrface";
            this.txtWindowsSurrface.Size = new System.Drawing.Size(100, 20);
            this.txtWindowsSurrface.TabIndex = 17;
            // 
            // txtMinOuterTemperature
            // 
            this.txtMinOuterTemperature.Location = new System.Drawing.Point(207, 346);
            this.txtMinOuterTemperature.Name = "txtMinOuterTemperature";
            this.txtMinOuterTemperature.Size = new System.Drawing.Size(100, 20);
            this.txtMinOuterTemperature.TabIndex = 18;
            // 
            // txtInnerTemperature
            // 
            this.txtInnerTemperature.Location = new System.Drawing.Point(207, 373);
            this.txtInnerTemperature.Name = "txtInnerTemperature";
            this.txtInnerTemperature.Size = new System.Drawing.Size(100, 20);
            this.txtInnerTemperature.TabIndex = 19;
            // 
            // cmbFloorsMaterials1
            // 
            this.cmbFloorsMaterials1.FormattingEnabled = true;
            this.cmbFloorsMaterials1.Location = new System.Drawing.Point(56, 452);
            this.cmbFloorsMaterials1.Name = "cmbFloorsMaterials1";
            this.cmbFloorsMaterials1.Size = new System.Drawing.Size(121, 21);
            this.cmbFloorsMaterials1.TabIndex = 20;
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(53, 436);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(90, 13);
            this.lblFloor.TabIndex = 21;
            this.lblFloor.Text = "Podlaha materiály";
            // 
            // cmbFloorsMaterials2
            // 
            this.cmbFloorsMaterials2.FormattingEnabled = true;
            this.cmbFloorsMaterials2.Location = new System.Drawing.Point(236, 452);
            this.cmbFloorsMaterials2.Name = "cmbFloorsMaterials2";
            this.cmbFloorsMaterials2.Size = new System.Drawing.Size(121, 21);
            this.cmbFloorsMaterials2.TabIndex = 22;
            // 
            // cmbFloorsMaterials3
            // 
            this.cmbFloorsMaterials3.FormattingEnabled = true;
            this.cmbFloorsMaterials3.Location = new System.Drawing.Point(425, 452);
            this.cmbFloorsMaterials3.Name = "cmbFloorsMaterials3";
            this.cmbFloorsMaterials3.Size = new System.Drawing.Size(121, 21);
            this.cmbFloorsMaterials3.TabIndex = 23;
            // 
            // cmbFloorMaterials4
            // 
            this.cmbFloorMaterials4.FormattingEnabled = true;
            this.cmbFloorMaterials4.Location = new System.Drawing.Point(596, 452);
            this.cmbFloorMaterials4.Name = "cmbFloorMaterials4";
            this.cmbFloorMaterials4.Size = new System.Drawing.Size(121, 21);
            this.cmbFloorMaterials4.TabIndex = 24;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(56, 480);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(42, 13);
            this.lblWidth.TabIndex = 25;
            this.lblWidth.Text = "Hrúbka";
            // 
            // txtFloorWidth1
            // 
            this.txtFloorWidth1.Location = new System.Drawing.Point(59, 497);
            this.txtFloorWidth1.Name = "txtFloorWidth1";
            this.txtFloorWidth1.Size = new System.Drawing.Size(65, 20);
            this.txtFloorWidth1.TabIndex = 26;
            // 
            // txtFloorWidth4
            // 
            this.txtFloorWidth4.Location = new System.Drawing.Point(596, 497);
            this.txtFloorWidth4.Name = "txtFloorWidth4";
            this.txtFloorWidth4.Size = new System.Drawing.Size(65, 20);
            this.txtFloorWidth4.TabIndex = 27;
            // 
            // txtFloorWidth3
            // 
            this.txtFloorWidth3.Location = new System.Drawing.Point(425, 497);
            this.txtFloorWidth3.Name = "txtFloorWidth3";
            this.txtFloorWidth3.Size = new System.Drawing.Size(65, 20);
            this.txtFloorWidth3.TabIndex = 28;
            // 
            // txtFloorWidth2
            // 
            this.txtFloorWidth2.Location = new System.Drawing.Point(236, 497);
            this.txtFloorWidth2.Name = "txtFloorWidth2";
            this.txtFloorWidth2.Size = new System.Drawing.Size(65, 20);
            this.txtFloorWidth2.TabIndex = 29;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(625, 637);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 23);
            this.btnCalculate.TabIndex = 30;
            this.btnCalculate.Text = "Vypočítaj tepelnú stratu";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 686);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFloorWidth2);
            this.Controls.Add(this.txtFloorWidth3);
            this.Controls.Add(this.txtFloorWidth4);
            this.Controls.Add(this.txtFloorWidth1);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.cmbFloorMaterials4);
            this.Controls.Add(this.cmbFloorsMaterials3);
            this.Controls.Add(this.cmbFloorsMaterials2);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.cmbFloorsMaterials1);
            this.Controls.Add(this.txtInnerTemperature);
            this.Controls.Add(this.txtMinOuterTemperature);
            this.Controls.Add(this.txtWindowsSurrface);
            this.Controls.Add(this.lblWindowsArea);
            this.Controls.Add(this.lblInnerTemperature);
            this.Controls.Add(this.lblMinOutTemperature);
            this.Controls.Add(this.txtBuildingHeight);
            this.Controls.Add(this.txtBuildingLength);
            this.Controls.Add(this.txtBuildingWidth);
            this.Controls.Add(this.lblBuildingHeigth);
            this.Controls.Add(this.lblBuildingLength);
            this.Controls.Add(this.lblBuildingWidth);
            this.Controls.Add(this.grpBuildingType);
            this.Controls.Add(this.lblBuildingType);
            this.Controls.Add(this.grpCountryType);
            this.Controls.Add(this.lblCountryType);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNameAndSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmMain";
            this.Text = "Výpočet tepelných strát budovy";
            this.grpCountryType.ResumeLayout(false);
            this.grpCountryType.PerformLayout();
            this.grpBuildingType.ResumeLayout(false);
            this.grpBuildingType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameAndSurname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCountryType;
        private System.Windows.Forms.GroupBox grpCountryType;
        private System.Windows.Forms.RadioButton rdnWindy;
        private System.Windows.Forms.RadioButton rdnNormal;
        private System.Windows.Forms.Label lblBuildingType;
        private System.Windows.Forms.GroupBox grpBuildingType;
        private System.Windows.Forms.RadioButton rdnVeryNegative;
        private System.Windows.Forms.RadioButton rdnNotProtected;
        private System.Windows.Forms.RadioButton rdnProtected;
        private System.Windows.Forms.Label lblBuildingWidth;
        private System.Windows.Forms.Label lblBuildingLength;
        private System.Windows.Forms.Label lblBuildingHeigth;
        private System.Windows.Forms.TextBox txtBuildingWidth;
        private System.Windows.Forms.TextBox txtBuildingLength;
        private System.Windows.Forms.TextBox txtBuildingHeight;
        private System.Windows.Forms.Label lblMinOutTemperature;
        private System.Windows.Forms.Label lblInnerTemperature;
        private System.Windows.Forms.Label lblWindowsArea;
        private System.Windows.Forms.TextBox txtWindowsSurrface;
        private System.Windows.Forms.TextBox txtMinOuterTemperature;
        private System.Windows.Forms.TextBox txtInnerTemperature;
        private System.Windows.Forms.ComboBox cmbFloorsMaterials1;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.ComboBox cmbFloorsMaterials2;
        private System.Windows.Forms.ComboBox cmbFloorsMaterials3;
        private System.Windows.Forms.ComboBox cmbFloorMaterials4;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtFloorWidth1;
        private System.Windows.Forms.TextBox txtFloorWidth4;
        private System.Windows.Forms.TextBox txtFloorWidth3;
        private System.Windows.Forms.TextBox txtFloorWidth2;
        private System.Windows.Forms.Button btnCalculate;
    }
}

