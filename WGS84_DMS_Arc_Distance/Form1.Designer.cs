
namespace WGS84_DMS_Arc_Distance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterLatitudeLabel = new System.Windows.Forms.Label();
            this.latitudeTextbox = new System.Windows.Forms.TextBox();
            this.kilometersRadioButton = new System.Windows.Forms.RadioButton();
            this.metersRadioButton = new System.Windows.Forms.RadioButton();
            this.milesRadioButton = new System.Windows.Forms.RadioButton();
            this.feetRadioButton = new System.Windows.Forms.RadioButton();
            this.unitMeasurementGroupBox = new System.Windows.Forms.GroupBox();
            this.nautMilesRadioButton = new System.Windows.Forms.RadioButton();
            this.degreeEWLabel = new System.Windows.Forms.Label();
            this.minuteEWLabel = new System.Windows.Forms.Label();
            this.secondEWLabel = new System.Windows.Forms.Label();
            this.ewDegreeOutput = new System.Windows.Forms.Label();
            this.ewMinuteOutput = new System.Windows.Forms.Label();
            this.ewSecondOutput = new System.Windows.Forms.Label();
            this.EWDistanceGroupBox = new System.Windows.Forms.GroupBox();
            this.secondEWUnitLabel = new System.Windows.Forms.Label();
            this.minuteEWUnitLabel = new System.Windows.Forms.Label();
            this.degreeEWUnitLabel = new System.Windows.Forms.Label();
            this.degreeNSLabel = new System.Windows.Forms.Label();
            this.minuteNSLabel = new System.Windows.Forms.Label();
            this.secondNSLabel = new System.Windows.Forms.Label();
            this.nsDegreeOutput = new System.Windows.Forms.Label();
            this.nsMinuteOutput = new System.Windows.Forms.Label();
            this.nsSecondOutput = new System.Windows.Forms.Label();
            this.NSDistanceGroupBox = new System.Windows.Forms.GroupBox();
            this.secondNSUnitLabel = new System.Windows.Forms.Label();
            this.minuteNSUnitLabel = new System.Windows.Forms.Label();
            this.degreeNSUnitLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.unitMeasurementGroupBox.SuspendLayout();
            this.EWDistanceGroupBox.SuspendLayout();
            this.NSDistanceGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterLatitudeLabel
            // 
            this.enterLatitudeLabel.AutoSize = true;
            this.enterLatitudeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterLatitudeLabel.Location = new System.Drawing.Point(33, 42);
            this.enterLatitudeLabel.Name = "enterLatitudeLabel";
            this.enterLatitudeLabel.Size = new System.Drawing.Size(133, 17);
            this.enterLatitudeLabel.TabIndex = 0;
            this.enterLatitudeLabel.Text = "Enter Latitude (DD):";
            // 
            // latitudeTextbox
            // 
            this.latitudeTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.latitudeTextbox.Location = new System.Drawing.Point(173, 39);
            this.latitudeTextbox.Name = "latitudeTextbox";
            this.latitudeTextbox.Size = new System.Drawing.Size(50, 25);
            this.latitudeTextbox.TabIndex = 1;
            this.latitudeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kilometersRadioButton
            // 
            this.kilometersRadioButton.AutoSize = true;
            this.kilometersRadioButton.Checked = true;
            this.kilometersRadioButton.Location = new System.Drawing.Point(135, 27);
            this.kilometersRadioButton.Name = "kilometersRadioButton";
            this.kilometersRadioButton.Size = new System.Drawing.Size(81, 19);
            this.kilometersRadioButton.TabIndex = 2;
            this.kilometersRadioButton.TabStop = true;
            this.kilometersRadioButton.Text = "Kilometers";
            this.kilometersRadioButton.UseVisualStyleBackColor = true;
            // 
            // metersRadioButton
            // 
            this.metersRadioButton.AutoSize = true;
            this.metersRadioButton.Location = new System.Drawing.Point(135, 53);
            this.metersRadioButton.Name = "metersRadioButton";
            this.metersRadioButton.Size = new System.Drawing.Size(61, 19);
            this.metersRadioButton.TabIndex = 3;
            this.metersRadioButton.TabStop = true;
            this.metersRadioButton.Text = "Meters";
            this.metersRadioButton.UseVisualStyleBackColor = true;
            // 
            // milesRadioButton
            // 
            this.milesRadioButton.AutoSize = true;
            this.milesRadioButton.Location = new System.Drawing.Point(18, 27);
            this.milesRadioButton.Name = "milesRadioButton";
            this.milesRadioButton.Size = new System.Drawing.Size(53, 19);
            this.milesRadioButton.TabIndex = 4;
            this.milesRadioButton.TabStop = true;
            this.milesRadioButton.Text = "Miles";
            this.milesRadioButton.UseVisualStyleBackColor = true;
            // 
            // feetRadioButton
            // 
            this.feetRadioButton.AutoSize = true;
            this.feetRadioButton.Location = new System.Drawing.Point(18, 53);
            this.feetRadioButton.Name = "feetRadioButton";
            this.feetRadioButton.Size = new System.Drawing.Size(47, 19);
            this.feetRadioButton.TabIndex = 5;
            this.feetRadioButton.TabStop = true;
            this.feetRadioButton.Text = "Feet";
            this.feetRadioButton.UseVisualStyleBackColor = true;
            // 
            // unitMeasurementGroupBox
            // 
            this.unitMeasurementGroupBox.Controls.Add(this.nautMilesRadioButton);
            this.unitMeasurementGroupBox.Controls.Add(this.feetRadioButton);
            this.unitMeasurementGroupBox.Controls.Add(this.milesRadioButton);
            this.unitMeasurementGroupBox.Controls.Add(this.metersRadioButton);
            this.unitMeasurementGroupBox.Controls.Add(this.kilometersRadioButton);
            this.unitMeasurementGroupBox.Location = new System.Drawing.Point(22, 85);
            this.unitMeasurementGroupBox.Name = "unitMeasurementGroupBox";
            this.unitMeasurementGroupBox.Size = new System.Drawing.Size(240, 110);
            this.unitMeasurementGroupBox.TabIndex = 6;
            this.unitMeasurementGroupBox.TabStop = false;
            this.unitMeasurementGroupBox.Text = "Unit of Measurement";
            // 
            // nautMilesRadioButton
            // 
            this.nautMilesRadioButton.AutoSize = true;
            this.nautMilesRadioButton.Location = new System.Drawing.Point(18, 79);
            this.nautMilesRadioButton.Name = "nautMilesRadioButton";
            this.nautMilesRadioButton.Size = new System.Drawing.Size(100, 19);
            this.nautMilesRadioButton.TabIndex = 6;
            this.nautMilesRadioButton.TabStop = true;
            this.nautMilesRadioButton.Text = "Nautical Miles";
            this.nautMilesRadioButton.UseVisualStyleBackColor = true;
            // 
            // degreeEWLabel
            // 
            this.degreeEWLabel.AutoSize = true;
            this.degreeEWLabel.Location = new System.Drawing.Point(8, 29);
            this.degreeEWLabel.Name = "degreeEWLabel";
            this.degreeEWLabel.Size = new System.Drawing.Size(64, 15);
            this.degreeEWLabel.TabIndex = 7;
            this.degreeEWLabel.Text = "1 Degree =";
            // 
            // minuteEWLabel
            // 
            this.minuteEWLabel.AutoSize = true;
            this.minuteEWLabel.Location = new System.Drawing.Point(8, 58);
            this.minuteEWLabel.Name = "minuteEWLabel";
            this.minuteEWLabel.Size = new System.Drawing.Size(65, 15);
            this.minuteEWLabel.TabIndex = 8;
            this.minuteEWLabel.Text = "1 Minute =";
            // 
            // secondEWLabel
            // 
            this.secondEWLabel.AutoSize = true;
            this.secondEWLabel.Location = new System.Drawing.Point(8, 87);
            this.secondEWLabel.Name = "secondEWLabel";
            this.secondEWLabel.Size = new System.Drawing.Size(66, 15);
            this.secondEWLabel.TabIndex = 9;
            this.secondEWLabel.Text = "1 Second =";
            // 
            // ewDegreeOutput
            // 
            this.ewDegreeOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ewDegreeOutput.Location = new System.Drawing.Point(75, 28);
            this.ewDegreeOutput.Name = "ewDegreeOutput";
            this.ewDegreeOutput.Size = new System.Drawing.Size(73, 23);
            this.ewDegreeOutput.TabIndex = 10;
            this.ewDegreeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ewMinuteOutput
            // 
            this.ewMinuteOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ewMinuteOutput.Location = new System.Drawing.Point(75, 57);
            this.ewMinuteOutput.Name = "ewMinuteOutput";
            this.ewMinuteOutput.Size = new System.Drawing.Size(73, 23);
            this.ewMinuteOutput.TabIndex = 11;
            this.ewMinuteOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ewSecondOutput
            // 
            this.ewSecondOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ewSecondOutput.Location = new System.Drawing.Point(75, 86);
            this.ewSecondOutput.Name = "ewSecondOutput";
            this.ewSecondOutput.Size = new System.Drawing.Size(73, 23);
            this.ewSecondOutput.TabIndex = 12;
            this.ewSecondOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EWDistanceGroupBox
            // 
            this.EWDistanceGroupBox.Controls.Add(this.secondEWUnitLabel);
            this.EWDistanceGroupBox.Controls.Add(this.minuteEWUnitLabel);
            this.EWDistanceGroupBox.Controls.Add(this.degreeEWUnitLabel);
            this.EWDistanceGroupBox.Controls.Add(this.ewSecondOutput);
            this.EWDistanceGroupBox.Controls.Add(this.ewMinuteOutput);
            this.EWDistanceGroupBox.Controls.Add(this.ewDegreeOutput);
            this.EWDistanceGroupBox.Controls.Add(this.secondEWLabel);
            this.EWDistanceGroupBox.Controls.Add(this.minuteEWLabel);
            this.EWDistanceGroupBox.Controls.Add(this.degreeEWLabel);
            this.EWDistanceGroupBox.Location = new System.Drawing.Point(22, 208);
            this.EWDistanceGroupBox.Name = "EWDistanceGroupBox";
            this.EWDistanceGroupBox.Size = new System.Drawing.Size(240, 130);
            this.EWDistanceGroupBox.TabIndex = 13;
            this.EWDistanceGroupBox.TabStop = false;
            this.EWDistanceGroupBox.Text = "East / West Distance (longitude)";
            // 
            // secondEWUnitLabel
            // 
            this.secondEWUnitLabel.Location = new System.Drawing.Point(158, 87);
            this.secondEWUnitLabel.Name = "secondEWUnitLabel";
            this.secondEWUnitLabel.Size = new System.Drawing.Size(72, 15);
            this.secondEWUnitLabel.TabIndex = 15;
            // 
            // minuteEWUnitLabel
            // 
            this.minuteEWUnitLabel.Location = new System.Drawing.Point(158, 58);
            this.minuteEWUnitLabel.Name = "minuteEWUnitLabel";
            this.minuteEWUnitLabel.Size = new System.Drawing.Size(72, 15);
            this.minuteEWUnitLabel.TabIndex = 14;
            // 
            // degreeEWUnitLabel
            // 
            this.degreeEWUnitLabel.Location = new System.Drawing.Point(158, 29);
            this.degreeEWUnitLabel.Name = "degreeEWUnitLabel";
            this.degreeEWUnitLabel.Size = new System.Drawing.Size(72, 15);
            this.degreeEWUnitLabel.TabIndex = 13;
            // 
            // degreeNSLabel
            // 
            this.degreeNSLabel.AutoSize = true;
            this.degreeNSLabel.Location = new System.Drawing.Point(8, 29);
            this.degreeNSLabel.Name = "degreeNSLabel";
            this.degreeNSLabel.Size = new System.Drawing.Size(64, 15);
            this.degreeNSLabel.TabIndex = 14;
            this.degreeNSLabel.Text = "1 Degree =";
            // 
            // minuteNSLabel
            // 
            this.minuteNSLabel.AutoSize = true;
            this.minuteNSLabel.Location = new System.Drawing.Point(8, 58);
            this.minuteNSLabel.Name = "minuteNSLabel";
            this.minuteNSLabel.Size = new System.Drawing.Size(65, 15);
            this.minuteNSLabel.TabIndex = 15;
            this.minuteNSLabel.Text = "1 Minute =";
            // 
            // secondNSLabel
            // 
            this.secondNSLabel.AutoSize = true;
            this.secondNSLabel.Location = new System.Drawing.Point(8, 87);
            this.secondNSLabel.Name = "secondNSLabel";
            this.secondNSLabel.Size = new System.Drawing.Size(66, 15);
            this.secondNSLabel.TabIndex = 16;
            this.secondNSLabel.Text = "1 Second =";
            // 
            // nsDegreeOutput
            // 
            this.nsDegreeOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nsDegreeOutput.Location = new System.Drawing.Point(75, 28);
            this.nsDegreeOutput.Name = "nsDegreeOutput";
            this.nsDegreeOutput.Size = new System.Drawing.Size(73, 23);
            this.nsDegreeOutput.TabIndex = 17;
            this.nsDegreeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nsMinuteOutput
            // 
            this.nsMinuteOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nsMinuteOutput.Location = new System.Drawing.Point(75, 57);
            this.nsMinuteOutput.Name = "nsMinuteOutput";
            this.nsMinuteOutput.Size = new System.Drawing.Size(73, 23);
            this.nsMinuteOutput.TabIndex = 18;
            this.nsMinuteOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nsSecondOutput
            // 
            this.nsSecondOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nsSecondOutput.Location = new System.Drawing.Point(75, 86);
            this.nsSecondOutput.Name = "nsSecondOutput";
            this.nsSecondOutput.Size = new System.Drawing.Size(73, 23);
            this.nsSecondOutput.TabIndex = 19;
            this.nsSecondOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NSDistanceGroupBox
            // 
            this.NSDistanceGroupBox.Controls.Add(this.secondNSUnitLabel);
            this.NSDistanceGroupBox.Controls.Add(this.minuteNSUnitLabel);
            this.NSDistanceGroupBox.Controls.Add(this.degreeNSUnitLabel);
            this.NSDistanceGroupBox.Controls.Add(this.nsSecondOutput);
            this.NSDistanceGroupBox.Controls.Add(this.nsMinuteOutput);
            this.NSDistanceGroupBox.Controls.Add(this.nsDegreeOutput);
            this.NSDistanceGroupBox.Controls.Add(this.secondNSLabel);
            this.NSDistanceGroupBox.Controls.Add(this.minuteNSLabel);
            this.NSDistanceGroupBox.Controls.Add(this.degreeNSLabel);
            this.NSDistanceGroupBox.Location = new System.Drawing.Point(22, 351);
            this.NSDistanceGroupBox.Name = "NSDistanceGroupBox";
            this.NSDistanceGroupBox.Size = new System.Drawing.Size(240, 130);
            this.NSDistanceGroupBox.TabIndex = 20;
            this.NSDistanceGroupBox.TabStop = false;
            this.NSDistanceGroupBox.Text = "North / South Distance (latitude)";
            // 
            // secondNSUnitLabel
            // 
            this.secondNSUnitLabel.Location = new System.Drawing.Point(158, 87);
            this.secondNSUnitLabel.Name = "secondNSUnitLabel";
            this.secondNSUnitLabel.Size = new System.Drawing.Size(72, 15);
            this.secondNSUnitLabel.TabIndex = 22;
            // 
            // minuteNSUnitLabel
            // 
            this.minuteNSUnitLabel.Location = new System.Drawing.Point(158, 58);
            this.minuteNSUnitLabel.Name = "minuteNSUnitLabel";
            this.minuteNSUnitLabel.Size = new System.Drawing.Size(72, 15);
            this.minuteNSUnitLabel.TabIndex = 21;
            // 
            // degreeNSUnitLabel
            // 
            this.degreeNSUnitLabel.Location = new System.Drawing.Point(158, 29);
            this.degreeNSUnitLabel.Name = "degreeNSUnitLabel";
            this.degreeNSUnitLabel.Size = new System.Drawing.Size(72, 15);
            this.degreeNSUnitLabel.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.creditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.creditToolStripMenuItem.Text = "Credit";
            this.creditToolStripMenuItem.Click += new System.EventHandler(this.creditToolStripMenuItem_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(35, 494);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 30);
            this.calculateButton.TabIndex = 22;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(150, 494);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 30);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(225, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "°";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.NSDistanceGroupBox);
            this.Controls.Add(this.EWDistanceGroupBox);
            this.Controls.Add(this.unitMeasurementGroupBox);
            this.Controls.Add(this.latitudeTextbox);
            this.Controls.Add(this.enterLatitudeLabel);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(300, 590);
            this.MinimumSize = new System.Drawing.Size(300, 590);
            this.Name = "Form1";
            this.Text = "DMS Arc Distance";
            this.unitMeasurementGroupBox.ResumeLayout(false);
            this.unitMeasurementGroupBox.PerformLayout();
            this.EWDistanceGroupBox.ResumeLayout(false);
            this.EWDistanceGroupBox.PerformLayout();
            this.NSDistanceGroupBox.ResumeLayout(false);
            this.NSDistanceGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterLatitudeLabel;
        private System.Windows.Forms.TextBox latitudeTextbox;
        private System.Windows.Forms.RadioButton kilometersRadioButton;
        private System.Windows.Forms.RadioButton metersRadioButton;
        private System.Windows.Forms.RadioButton milesRadioButton;
        private System.Windows.Forms.RadioButton feetRadioButton;
        private System.Windows.Forms.GroupBox unitMeasurementGroupBox;
        private System.Windows.Forms.Label degreeEWLabel;
        private System.Windows.Forms.Label minuteEWLabel;
        private System.Windows.Forms.Label secondEWLabel;
        private System.Windows.Forms.Label ewDegreeOutput;
        private System.Windows.Forms.Label ewMinuteOutput;
        private System.Windows.Forms.Label ewSecondOutput;
        private System.Windows.Forms.GroupBox EWDistanceGroupBox;
        private System.Windows.Forms.Label degreeNSLabel;
        private System.Windows.Forms.Label minuteNSLabel;
        private System.Windows.Forms.Label secondNSLabel;
        private System.Windows.Forms.Label nsDegreeOutput;
        private System.Windows.Forms.Label nsMinuteOutput;
        private System.Windows.Forms.Label nsSecondOutput;
        private System.Windows.Forms.GroupBox NSDistanceGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label secondEWUnitLabel;
        private System.Windows.Forms.Label minuteEWUnitLabel;
        private System.Windows.Forms.Label degreeEWUnitLabel;
        private System.Windows.Forms.Label secondNSUnitLabel;
        private System.Windows.Forms.Label minuteNSUnitLabel;
        private System.Windows.Forms.Label degreeNSUnitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.RadioButton nautMilesRadioButton;
    }
}

