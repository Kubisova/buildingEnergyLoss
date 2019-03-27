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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameAndSurname = new System.Windows.Forms.Label();
            this.txtNameAndSurname = new System.Windows.Forms.TextBox();
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
            this.lblMinOutTemperature = new System.Windows.Forms.Label();
            this.lblInnerTemperature = new System.Windows.Forms.Label();
            this.cmbFloorsMaterials1 = new System.Windows.Forms.ComboBox();
            this.lblFloor = new System.Windows.Forms.Label();
            this.cmbFloorsMaterials2 = new System.Windows.Forms.ComboBox();
            this.cmbFloorsMaterials3 = new System.Windows.Forms.ComboBox();
            this.cmbFloorMaterials4 = new System.Windows.Forms.ComboBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtFloorThickness1 = new System.Windows.Forms.TextBox();
            this.txtFloorThickness4 = new System.Windows.Forms.TextBox();
            this.txtFloorThickness3 = new System.Windows.Forms.TextBox();
            this.txtFloorThickness2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRoofMaterials1 = new System.Windows.Forms.ComboBox();
            this.cmbWallsMaterials1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoofThickness1 = new System.Windows.Forms.TextBox();
            this.txtWallsThickness1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numUpDBuildingWidth = new System.Windows.Forms.NumericUpDown();
            this.numUpDBuildingLength = new System.Windows.Forms.NumericUpDown();
            this.numUpDBuildingHeight = new System.Windows.Forms.NumericUpDown();
            this.numUpDInnerTemperature = new System.Windows.Forms.NumericUpDown();
            this.numUpDMinOuterTemperature = new System.Windows.Forms.NumericUpDown();
            this.lblResultLoss = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.grpCountryType.SuspendLayout();
            this.grpBuildingType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDBuildingWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDBuildingLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDBuildingHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDInnerTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinOuterTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 0;
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
            this.lblNameAndSurname.Location = new System.Drawing.Point(319, 28);
            this.lblNameAndSurname.Name = "lblNameAndSurname";
            this.lblNameAndSurname.Size = new System.Drawing.Size(93, 13);
            this.lblNameAndSurname.TabIndex = 2;
            this.lblNameAndSurname.Text = "Meno a priezvisko";
            // 
            // txtNameAndSurname
            // 
            this.txtNameAndSurname.Location = new System.Drawing.Point(418, 25);
            this.txtNameAndSurname.Name = "txtNameAndSurname";
            this.txtNameAndSurname.Size = new System.Drawing.Size(182, 20);
            this.txtNameAndSurname.TabIndex = 3;
            // 
            // lblCountryType
            // 
            this.lblCountryType.AutoSize = true;
            this.lblCountryType.Location = new System.Drawing.Point(50, 68);
            this.lblCountryType.Name = "lblCountryType";
            this.lblCountryType.Size = new System.Drawing.Size(58, 13);
            this.lblCountryType.TabIndex = 4;
            this.lblCountryType.Text = "Typ krajiny";
            // 
            // grpCountryType
            // 
            this.grpCountryType.Controls.Add(this.rdnWindy);
            this.grpCountryType.Controls.Add(this.rdnNormal);
            this.grpCountryType.Location = new System.Drawing.Point(160, 59);
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
            this.lblBuildingType.Location = new System.Drawing.Point(319, 68);
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
            this.grpBuildingType.Location = new System.Drawing.Point(418, 59);
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
            this.lblBuildingWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBuildingWidth.Location = new System.Drawing.Point(50, 185);
            this.lblBuildingWidth.Name = "lblBuildingWidth";
            this.lblBuildingWidth.Size = new System.Drawing.Size(83, 13);
            this.lblBuildingWidth.TabIndex = 8;
            this.lblBuildingWidth.Text = "Šírka budovy";
            // 
            // lblBuildingLength
            // 
            this.lblBuildingLength.AutoSize = true;
            this.lblBuildingLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBuildingLength.Location = new System.Drawing.Point(51, 218);
            this.lblBuildingLength.Name = "lblBuildingLength";
            this.lblBuildingLength.Size = new System.Drawing.Size(85, 13);
            this.lblBuildingLength.TabIndex = 9;
            this.lblBuildingLength.Text = "Dĺžka budovy";
            // 
            // lblBuildingHeigth
            // 
            this.lblBuildingHeigth.AutoSize = true;
            this.lblBuildingHeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBuildingHeigth.Location = new System.Drawing.Point(50, 247);
            this.lblBuildingHeigth.Name = "lblBuildingHeigth";
            this.lblBuildingHeigth.Size = new System.Drawing.Size(86, 13);
            this.lblBuildingHeigth.TabIndex = 10;
            this.lblBuildingHeigth.Text = "Výška budovy";
            // 
            // lblMinOutTemperature
            // 
            this.lblMinOutTemperature.AutoSize = true;
            this.lblMinOutTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinOutTemperature.Location = new System.Drawing.Point(319, 185);
            this.lblMinOutTemperature.Name = "lblMinOutTemperature";
            this.lblMinOutTemperature.Size = new System.Drawing.Size(164, 13);
            this.lblMinOutTemperature.TabIndex = 14;
            this.lblMinOutTemperature.Text = "Minimálna vonkajšia teplota";
            // 
            // lblInnerTemperature
            // 
            this.lblInnerTemperature.AutoSize = true;
            this.lblInnerTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInnerTemperature.Location = new System.Drawing.Point(319, 216);
            this.lblInnerTemperature.Name = "lblInnerTemperature";
            this.lblInnerTemperature.Size = new System.Drawing.Size(101, 13);
            this.lblInnerTemperature.TabIndex = 15;
            this.lblInnerTemperature.Text = "Vnútorná teplota";
            // 
            // cmbFloorsMaterials1
            // 
            this.cmbFloorsMaterials1.FormattingEnabled = true;
            this.cmbFloorsMaterials1.Location = new System.Drawing.Point(53, 309);
            this.cmbFloorsMaterials1.Name = "cmbFloorsMaterials1";
            this.cmbFloorsMaterials1.Size = new System.Drawing.Size(121, 21);
            this.cmbFloorsMaterials1.TabIndex = 20;
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFloor.Location = new System.Drawing.Point(50, 293);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(107, 13);
            this.lblFloor.TabIndex = 21;
            this.lblFloor.Text = "Podlaha materiály";
            // 
            // cmbFloorsMaterials2
            // 
            this.cmbFloorsMaterials2.FormattingEnabled = true;
            this.cmbFloorsMaterials2.Location = new System.Drawing.Point(218, 309);
            this.cmbFloorsMaterials2.Name = "cmbFloorsMaterials2";
            this.cmbFloorsMaterials2.Size = new System.Drawing.Size(121, 21);
            this.cmbFloorsMaterials2.TabIndex = 22;
            // 
            // cmbFloorsMaterials3
            // 
            this.cmbFloorsMaterials3.FormattingEnabled = true;
            this.cmbFloorsMaterials3.Location = new System.Drawing.Point(388, 309);
            this.cmbFloorsMaterials3.Name = "cmbFloorsMaterials3";
            this.cmbFloorsMaterials3.Size = new System.Drawing.Size(121, 21);
            this.cmbFloorsMaterials3.TabIndex = 23;
            // 
            // cmbFloorMaterials4
            // 
            this.cmbFloorMaterials4.FormattingEnabled = true;
            this.cmbFloorMaterials4.Location = new System.Drawing.Point(549, 309);
            this.cmbFloorMaterials4.Name = "cmbFloorMaterials4";
            this.cmbFloorMaterials4.Size = new System.Drawing.Size(121, 21);
            this.cmbFloorMaterials4.TabIndex = 24;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(56, 333);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(42, 13);
            this.lblWidth.TabIndex = 25;
            this.lblWidth.Text = "Hrúbka";
            // 
            // txtFloorThickness1
            // 
            this.txtFloorThickness1.Location = new System.Drawing.Point(53, 349);
            this.txtFloorThickness1.Name = "txtFloorThickness1";
            this.txtFloorThickness1.Size = new System.Drawing.Size(65, 20);
            this.txtFloorThickness1.TabIndex = 26;
            // 
            // txtFloorThickness4
            // 
            this.txtFloorThickness4.Location = new System.Drawing.Point(549, 349);
            this.txtFloorThickness4.Name = "txtFloorThickness4";
            this.txtFloorThickness4.Size = new System.Drawing.Size(65, 20);
            this.txtFloorThickness4.TabIndex = 27;
            // 
            // txtFloorThickness3
            // 
            this.txtFloorThickness3.Location = new System.Drawing.Point(388, 349);
            this.txtFloorThickness3.Name = "txtFloorThickness3";
            this.txtFloorThickness3.Size = new System.Drawing.Size(65, 20);
            this.txtFloorThickness3.TabIndex = 28;
            // 
            // txtFloorThickness2
            // 
            this.txtFloorThickness2.Location = new System.Drawing.Point(218, 349);
            this.txtFloorThickness2.Name = "txtFloorThickness2";
            this.txtFloorThickness2.Size = new System.Drawing.Size(65, 20);
            this.txtFloorThickness2.TabIndex = 29;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(53, 632);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 23);
            this.btnCalculate.TabIndex = 30;
            this.btnCalculate.Text = "Vypočítaj tepelnú stratu";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(622, 59);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Steny materiály";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(53, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Strecha materiály";
            // 
            // cmbRoofMaterials1
            // 
            this.cmbRoofMaterials1.FormattingEnabled = true;
            this.cmbRoofMaterials1.Location = new System.Drawing.Point(53, 430);
            this.cmbRoofMaterials1.Name = "cmbRoofMaterials1";
            this.cmbRoofMaterials1.Size = new System.Drawing.Size(121, 21);
            this.cmbRoofMaterials1.TabIndex = 34;
            // 
            // cmbWallsMaterials1
            // 
            this.cmbWallsMaterials1.FormattingEnabled = true;
            this.cmbWallsMaterials1.Location = new System.Drawing.Point(53, 533);
            this.cmbWallsMaterials1.Name = "cmbWallsMaterials1";
            this.cmbWallsMaterials1.Size = new System.Drawing.Size(121, 21);
            this.cmbWallsMaterials1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Hrúbka";
            // 
            // txtRoofThickness1
            // 
            this.txtRoofThickness1.Location = new System.Drawing.Point(53, 470);
            this.txtRoofThickness1.Name = "txtRoofThickness1";
            this.txtRoofThickness1.Size = new System.Drawing.Size(65, 20);
            this.txtRoofThickness1.TabIndex = 37;
            // 
            // txtWallsThickness1
            // 
            this.txtWallsThickness1.Location = new System.Drawing.Point(53, 573);
            this.txtWallsThickness1.Name = "txtWallsThickness1";
            this.txtWallsThickness1.Size = new System.Drawing.Size(65, 20);
            this.txtWallsThickness1.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Hrúbka";
            // 
            // numUpDBuildingWidth
            // 
            this.numUpDBuildingWidth.DecimalPlaces = 2;
            this.numUpDBuildingWidth.Location = new System.Drawing.Point(160, 183);
            this.numUpDBuildingWidth.Name = "numUpDBuildingWidth";
            this.numUpDBuildingWidth.Size = new System.Drawing.Size(100, 20);
            this.numUpDBuildingWidth.TabIndex = 40;
            // 
            // numUpDBuildingLength
            // 
            this.numUpDBuildingLength.DecimalPlaces = 2;
            this.numUpDBuildingLength.Location = new System.Drawing.Point(160, 216);
            this.numUpDBuildingLength.Name = "numUpDBuildingLength";
            this.numUpDBuildingLength.Size = new System.Drawing.Size(100, 20);
            this.numUpDBuildingLength.TabIndex = 41;
            // 
            // numUpDBuildingHeight
            // 
            this.numUpDBuildingHeight.DecimalPlaces = 2;
            this.numUpDBuildingHeight.Location = new System.Drawing.Point(160, 247);
            this.numUpDBuildingHeight.Name = "numUpDBuildingHeight";
            this.numUpDBuildingHeight.Size = new System.Drawing.Size(100, 20);
            this.numUpDBuildingHeight.TabIndex = 42;
            // 
            // numUpDInnerTemperature
            // 
            this.numUpDInnerTemperature.DecimalPlaces = 2;
            this.numUpDInnerTemperature.Location = new System.Drawing.Point(500, 218);
            this.numUpDInnerTemperature.Name = "numUpDInnerTemperature";
            this.numUpDInnerTemperature.Size = new System.Drawing.Size(100, 20);
            this.numUpDInnerTemperature.TabIndex = 43;
            // 
            // numUpDMinOuterTemperature
            // 
            this.numUpDMinOuterTemperature.DecimalPlaces = 2;
            this.numUpDMinOuterTemperature.Location = new System.Drawing.Point(500, 183);
            this.numUpDMinOuterTemperature.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.numUpDMinOuterTemperature.Name = "numUpDMinOuterTemperature";
            this.numUpDMinOuterTemperature.Size = new System.Drawing.Size(100, 20);
            this.numUpDMinOuterTemperature.TabIndex = 44;
            // 
            // lblResultLoss
            // 
            this.lblResultLoss.AutoSize = true;
            this.lblResultLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResultLoss.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblResultLoss.Location = new System.Drawing.Point(281, 635);
            this.lblResultLoss.Name = "lblResultLoss";
            this.lblResultLoss.Size = new System.Drawing.Size(164, 15);
            this.lblResultLoss.TabIndex = 45;
            this.lblResultLoss.Text = "Tepelné straty budovy sú";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtResult.Location = new System.Drawing.Point(451, 632);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 21);
            this.txtResult.TabIndex = 46;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 686);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResultLoss);
            this.Controls.Add(this.numUpDMinOuterTemperature);
            this.Controls.Add(this.numUpDInnerTemperature);
            this.Controls.Add(this.numUpDBuildingHeight);
            this.Controls.Add(this.numUpDBuildingLength);
            this.Controls.Add(this.numUpDBuildingWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWallsThickness1);
            this.Controls.Add(this.txtRoofThickness1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbWallsMaterials1);
            this.Controls.Add(this.cmbRoofMaterials1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtFloorThickness2);
            this.Controls.Add(this.txtFloorThickness3);
            this.Controls.Add(this.txtFloorThickness4);
            this.Controls.Add(this.txtFloorThickness1);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.cmbFloorMaterials4);
            this.Controls.Add(this.cmbFloorsMaterials3);
            this.Controls.Add(this.cmbFloorsMaterials2);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.cmbFloorsMaterials1);
            this.Controls.Add(this.lblInnerTemperature);
            this.Controls.Add(this.lblMinOutTemperature);
            this.Controls.Add(this.lblBuildingHeigth);
            this.Controls.Add(this.lblBuildingLength);
            this.Controls.Add(this.lblBuildingWidth);
            this.Controls.Add(this.grpBuildingType);
            this.Controls.Add(this.lblBuildingType);
            this.Controls.Add(this.grpCountryType);
            this.Controls.Add(this.lblCountryType);
            this.Controls.Add(this.txtNameAndSurname);
            this.Controls.Add(this.lblNameAndSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "FrmMain";
            this.Text = "Výpočet tepelných strát budovy";
            this.grpCountryType.ResumeLayout(false);
            this.grpCountryType.PerformLayout();
            this.grpBuildingType.ResumeLayout(false);
            this.grpBuildingType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDBuildingWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDBuildingLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDBuildingHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDInnerTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDMinOuterTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameAndSurname;
        private System.Windows.Forms.TextBox txtNameAndSurname;
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
        private System.Windows.Forms.Label lblMinOutTemperature;
        private System.Windows.Forms.Label lblInnerTemperature;
        private System.Windows.Forms.ComboBox cmbFloorsMaterials1;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.ComboBox cmbFloorsMaterials2;
        private System.Windows.Forms.ComboBox cmbFloorsMaterials3;
        private System.Windows.Forms.ComboBox cmbFloorMaterials4;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtFloorThickness1;
        private System.Windows.Forms.TextBox txtFloorThickness4;
        private System.Windows.Forms.TextBox txtFloorThickness3;
        private System.Windows.Forms.TextBox txtFloorThickness2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRoofMaterials1;
        private System.Windows.Forms.ComboBox cmbWallsMaterials1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoofThickness1;
        private System.Windows.Forms.TextBox txtWallsThickness1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUpDBuildingWidth;
        private System.Windows.Forms.NumericUpDown numUpDBuildingLength;
        private System.Windows.Forms.NumericUpDown numUpDBuildingHeight;
        private System.Windows.Forms.NumericUpDown numUpDInnerTemperature;
        private System.Windows.Forms.NumericUpDown numUpDMinOuterTemperature;
        private System.Windows.Forms.Label lblResultLoss;
        private System.Windows.Forms.TextBox txtResult;
    }
}

