using System;

namespace CMSWinFormsApp
{
    partial class JobDetailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCarNo = new System.Windows.Forms.TextBox();
            this.txtWorkerId = new System.Windows.Forms.TextBox();
            this.txtKMs = new System.Windows.Forms.TextBox();
            this.txtTuning = new System.Windows.Forms.TextBox();
            this.txtAlignment = new System.Windows.Forms.TextBox();
            this.txtBalancing = new System.Windows.Forms.TextBox();
            this.txtTires = new System.Windows.Forms.TextBox();
            this.txtWeights = new System.Windows.Forms.TextBox();
            this.txtOilChanged = new System.Windows.Forms.TextBox();
            this.txtQilQty = new System.Windows.Forms.TextBox();
            this.txtOilFilter = new System.Windows.Forms.TextBox();
            this.txtGearOil = new System.Windows.Forms.TextBox();
            this.GearOilQty = new System.Windows.Forms.TextBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.txtCondenser = new System.Windows.Forms.TextBox();
            this.txtPlug = new System.Windows.Forms.TextBox();
            this.txtPlugQty = new System.Windows.Forms.TextBox();
            this.txtFuelFilter = new System.Windows.Forms.TextBox();
            this.txtAirFilter = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textPosition = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelAll = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CarNo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "JobDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "WorkerId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "KMs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tuning";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alignment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Balancing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tires";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Weights";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "OilChanged";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(83, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "OilQty";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(400, 307);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "Remarks";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(400, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "AirFilter";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(400, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 15);
            this.label15.TabIndex = 19;
            this.label15.Text = "FuelFilter";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(400, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 15);
            this.label16.TabIndex = 18;
            this.label16.Text = "PlugQty";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(400, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 15);
            this.label17.TabIndex = 17;
            this.label17.Text = "Plug";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(400, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 15);
            this.label18.TabIndex = 16;
            this.label18.Text = "Condenser";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(400, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 15);
            this.label19.TabIndex = 15;
            this.label19.Text = "Point";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(400, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 15);
            this.label20.TabIndex = 14;
            this.label20.Text = "GearOilQty";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(400, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 15);
            this.label21.TabIndex = 13;
            this.label21.Text = "GearOil";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(400, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 15);
            this.label22.TabIndex = 12;
            this.label22.Text = "OilFilter";
            // 
            // txtCarNo
            // 
            this.txtCarNo.Location = new System.Drawing.Point(160, 16);
            this.txtCarNo.Name = "txtCarNo";
            this.txtCarNo.Size = new System.Drawing.Size(191, 25);
            this.txtCarNo.TabIndex = 22;
            this.txtCarNo.Leave += new System.EventHandler(this.txtCarNo_Leave);
            // 
            // txtWorkerId
            // 
            this.txtWorkerId.Location = new System.Drawing.Point(160, 81);
            this.txtWorkerId.Name = "txtWorkerId";
            this.txtWorkerId.Size = new System.Drawing.Size(191, 25);
            this.txtWorkerId.TabIndex = 24;
            // 
            // txtKMs
            // 
            this.txtKMs.Location = new System.Drawing.Point(160, 113);
            this.txtKMs.Name = "txtKMs";
            this.txtKMs.Size = new System.Drawing.Size(191, 25);
            this.txtKMs.TabIndex = 25;
            // 
            // txtTuning
            // 
            this.txtTuning.Location = new System.Drawing.Point(160, 145);
            this.txtTuning.Name = "txtTuning";
            this.txtTuning.Size = new System.Drawing.Size(191, 25);
            this.txtTuning.TabIndex = 26;
            // 
            // txtAlignment
            // 
            this.txtAlignment.Location = new System.Drawing.Point(160, 177);
            this.txtAlignment.Name = "txtAlignment";
            this.txtAlignment.Size = new System.Drawing.Size(191, 25);
            this.txtAlignment.TabIndex = 27;
            // 
            // txtBalancing
            // 
            this.txtBalancing.Location = new System.Drawing.Point(160, 209);
            this.txtBalancing.Name = "txtBalancing";
            this.txtBalancing.Size = new System.Drawing.Size(191, 25);
            this.txtBalancing.TabIndex = 28;
            // 
            // txtTires
            // 
            this.txtTires.Location = new System.Drawing.Point(160, 241);
            this.txtTires.Name = "txtTires";
            this.txtTires.Size = new System.Drawing.Size(191, 25);
            this.txtTires.TabIndex = 29;
            // 
            // txtWeights
            // 
            this.txtWeights.Location = new System.Drawing.Point(160, 273);
            this.txtWeights.Name = "txtWeights";
            this.txtWeights.Size = new System.Drawing.Size(191, 25);
            this.txtWeights.TabIndex = 30;
            // 
            // txtOilChanged
            // 
            this.txtOilChanged.Location = new System.Drawing.Point(160, 305);
            this.txtOilChanged.Name = "txtOilChanged";
            this.txtOilChanged.Size = new System.Drawing.Size(191, 25);
            this.txtOilChanged.TabIndex = 31;
            // 
            // txtQilQty
            // 
            this.txtQilQty.Location = new System.Drawing.Point(160, 337);
            this.txtQilQty.Name = "txtQilQty";
            this.txtQilQty.Size = new System.Drawing.Size(191, 25);
            this.txtQilQty.TabIndex = 32;
            // 
            // txtOilFilter
            // 
            this.txtOilFilter.Location = new System.Drawing.Point(493, 19);
            this.txtOilFilter.Name = "txtOilFilter";
            this.txtOilFilter.Size = new System.Drawing.Size(206, 25);
            this.txtOilFilter.TabIndex = 34;
            // 
            // txtGearOil
            // 
            this.txtGearOil.Location = new System.Drawing.Point(493, 51);
            this.txtGearOil.Name = "txtGearOil";
            this.txtGearOil.Size = new System.Drawing.Size(206, 25);
            this.txtGearOil.TabIndex = 35;
            // 
            // GearOilQty
            // 
            this.GearOilQty.Location = new System.Drawing.Point(493, 84);
            this.GearOilQty.Name = "GearOilQty";
            this.GearOilQty.Size = new System.Drawing.Size(206, 25);
            this.GearOilQty.TabIndex = 36;
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(493, 116);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(206, 25);
            this.txtPoint.TabIndex = 37;
            // 
            // txtCondenser
            // 
            this.txtCondenser.Location = new System.Drawing.Point(493, 148);
            this.txtCondenser.Name = "txtCondenser";
            this.txtCondenser.Size = new System.Drawing.Size(206, 25);
            this.txtCondenser.TabIndex = 38;
            // 
            // txtPlug
            // 
            this.txtPlug.Location = new System.Drawing.Point(493, 177);
            this.txtPlug.Name = "txtPlug";
            this.txtPlug.Size = new System.Drawing.Size(206, 25);
            this.txtPlug.TabIndex = 39;
            // 
            // txtPlugQty
            // 
            this.txtPlugQty.Location = new System.Drawing.Point(493, 209);
            this.txtPlugQty.Name = "txtPlugQty";
            this.txtPlugQty.Size = new System.Drawing.Size(206, 25);
            this.txtPlugQty.TabIndex = 40;
            // 
            // txtFuelFilter
            // 
            this.txtFuelFilter.Location = new System.Drawing.Point(493, 241);
            this.txtFuelFilter.Name = "txtFuelFilter";
            this.txtFuelFilter.Size = new System.Drawing.Size(206, 25);
            this.txtFuelFilter.TabIndex = 41;
            // 
            // txtAirFilter
            // 
            this.txtAirFilter.Location = new System.Drawing.Point(493, 272);
            this.txtAirFilter.Name = "txtAirFilter";
            this.txtAirFilter.Size = new System.Drawing.Size(206, 25);
            this.txtAirFilter.TabIndex = 42;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(493, 304);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(206, 25);
            this.txtRemarks.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(477, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(511, 380);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 23);
            this.button4.TabIndex = 47;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textPosition
            // 
            this.textPosition.Location = new System.Drawing.Point(371, 378);
            this.textPosition.Multiline = true;
            this.textPosition.Name = "textPosition";
            this.textPosition.Size = new System.Drawing.Size(100, 25);
            this.textPosition.TabIndex = 48;
            this.textPosition.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(138, 415);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 49;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(300, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(381, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.Location = new System.Drawing.Point(462, 415);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(91, 23);
            this.btnCancelAll.TabIndex = 53;
            this.btnCancelAll.Text = "CancelAll";
            this.btnCancelAll.UseVisualStyleBackColor = true;
            this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(559, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(640, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 48);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 25);
            this.dateTimePicker1.TabIndex = 56;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // JobDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancelAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.textPosition);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtAirFilter);
            this.Controls.Add(this.txtFuelFilter);
            this.Controls.Add(this.txtPlugQty);
            this.Controls.Add(this.txtPlug);
            this.Controls.Add(this.txtCondenser);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.GearOilQty);
            this.Controls.Add(this.txtGearOil);
            this.Controls.Add(this.txtOilFilter);
            this.Controls.Add(this.txtQilQty);
            this.Controls.Add(this.txtOilChanged);
            this.Controls.Add(this.txtWeights);
            this.Controls.Add(this.txtTires);
            this.Controls.Add(this.txtBalancing);
            this.Controls.Add(this.txtAlignment);
            this.Controls.Add(this.txtTuning);
            this.Controls.Add(this.txtKMs);
            this.Controls.Add(this.txtWorkerId);
            this.Controls.Add(this.txtCarNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JobDetailsForm";
            this.Text = "JobDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCarNo;
        private System.Windows.Forms.TextBox txtWorkerId;
        private System.Windows.Forms.TextBox txtKMs;
        private System.Windows.Forms.TextBox txtTuning;
        private System.Windows.Forms.TextBox txtAlignment;
        private System.Windows.Forms.TextBox txtBalancing;
        private System.Windows.Forms.TextBox txtTires;
        private System.Windows.Forms.TextBox txtWeights;
        private System.Windows.Forms.TextBox txtOilChanged;
        private System.Windows.Forms.TextBox txtQilQty;
        private System.Windows.Forms.TextBox txtOilFilter;
        private System.Windows.Forms.TextBox txtGearOil;
        private System.Windows.Forms.TextBox GearOilQty;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.TextBox txtCondenser;
        private System.Windows.Forms.TextBox txtPlug;
        private System.Windows.Forms.TextBox txtPlugQty;
        private System.Windows.Forms.TextBox txtFuelFilter;
        private System.Windows.Forms.TextBox txtAirFilter;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textPosition;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelAll;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}