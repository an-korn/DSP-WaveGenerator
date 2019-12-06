namespace WaveGenerator
{
    partial class WaveGenerator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.generateWave = new System.Windows.Forms.Button();
            this.WaveTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AmplitudeTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.FrequencyTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DutyFactor = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.removeSignal = new System.Windows.Forms.Button();
            this.WaveTypeList = new System.Windows.Forms.ListBox();
            this.addSignal = new System.Windows.Forms.Button();
            this.generatePoly = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FrequencyPoly = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.AmplitudePoly = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.WaveTypePolyBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GenModButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.ModulationTypeBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AmplitudeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyTrackBar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DutyFactor)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyPoly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmplitudePoly)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateWave
            // 
            this.generateWave.Location = new System.Drawing.Point(15, 276);
            this.generateWave.Name = "generateWave";
            this.generateWave.Size = new System.Drawing.Size(227, 41);
            this.generateWave.TabIndex = 0;
            this.generateWave.Text = "Generate Wave";
            this.generateWave.UseVisualStyleBackColor = true;
            this.generateWave.Click += new System.EventHandler(this.generateWave_Click);
            // 
            // WaveTypeBox
            // 
            this.WaveTypeBox.FormattingEnabled = true;
            this.WaveTypeBox.Location = new System.Drawing.Point(6, 32);
            this.WaveTypeBox.Name = "WaveTypeBox";
            this.WaveTypeBox.Size = new System.Drawing.Size(227, 21);
            this.WaveTypeBox.TabIndex = 1;
            this.WaveTypeBox.SelectedIndexChanged += new System.EventHandler(this.WaveTypeBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wave Type:";
            // 
            // AmplitudeTrackBar
            // 
            this.AmplitudeTrackBar.Location = new System.Drawing.Point(9, 79);
            this.AmplitudeTrackBar.Maximum = 32760;
            this.AmplitudeTrackBar.Minimum = -32760;
            this.AmplitudeTrackBar.Name = "AmplitudeTrackBar";
            this.AmplitudeTrackBar.Size = new System.Drawing.Size(224, 45);
            this.AmplitudeTrackBar.TabIndex = 3;
            this.AmplitudeTrackBar.Scroll += new System.EventHandler(this.AmplitudeTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amplitude:";
            // 
            // FrequencyTrackBar
            // 
            this.FrequencyTrackBar.Location = new System.Drawing.Point(12, 151);
            this.FrequencyTrackBar.Maximum = 7903;
            this.FrequencyTrackBar.Minimum = 1;
            this.FrequencyTrackBar.Name = "FrequencyTrackBar";
            this.FrequencyTrackBar.Size = new System.Drawing.Size(224, 45);
            this.FrequencyTrackBar.TabIndex = 5;
            this.FrequencyTrackBar.Value = 176;
            this.FrequencyTrackBar.Scroll += new System.EventHandler(this.FrequencyTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frequency:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(275, 382);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.DutyFactor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.generateWave);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.WaveTypeBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.AmplitudeTrackBar);
            this.tabPage1.Controls.Add(this.FrequencyTrackBar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(267, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mono Wave Generation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(208, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Duty Factor:";
            // 
            // DutyFactor
            // 
            this.DutyFactor.Location = new System.Drawing.Point(15, 222);
            this.DutyFactor.Maximum = 100;
            this.DutyFactor.Name = "DutyFactor";
            this.DutyFactor.Size = new System.Drawing.Size(221, 45);
            this.DutyFactor.TabIndex = 9;
            this.DutyFactor.Scroll += new System.EventHandler(this.DutyFactor_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.removeSignal);
            this.tabPage2.Controls.Add(this.WaveTypeList);
            this.tabPage2.Controls.Add(this.addSignal);
            this.tabPage2.Controls.Add(this.generatePoly);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.FrequencyPoly);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.AmplitudePoly);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.WaveTypePolyBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(267, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Poly Wave Generation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // removeSignal
            // 
            this.removeSignal.Location = new System.Drawing.Point(78, 299);
            this.removeSignal.Name = "removeSignal";
            this.removeSignal.Size = new System.Drawing.Size(62, 23);
            this.removeSignal.TabIndex = 12;
            this.removeSignal.Text = "Remove";
            this.removeSignal.UseVisualStyleBackColor = true;
            this.removeSignal.Click += new System.EventHandler(this.removeSignal_Click);
            // 
            // WaveTypeList
            // 
            this.WaveTypeList.FormattingEnabled = true;
            this.WaveTypeList.Location = new System.Drawing.Point(9, 7);
            this.WaveTypeList.Name = "WaveTypeList";
            this.WaveTypeList.Size = new System.Drawing.Size(242, 69);
            this.WaveTypeList.TabIndex = 11;
            // 
            // addSignal
            // 
            this.addSignal.Location = new System.Drawing.Point(9, 299);
            this.addSignal.Name = "addSignal";
            this.addSignal.Size = new System.Drawing.Size(63, 23);
            this.addSignal.TabIndex = 10;
            this.addSignal.Text = "Add";
            this.addSignal.UseVisualStyleBackColor = true;
            this.addSignal.Click += new System.EventHandler(this.addSignal_Click);
            // 
            // generatePoly
            // 
            this.generatePoly.Location = new System.Drawing.Point(161, 299);
            this.generatePoly.Name = "generatePoly";
            this.generatePoly.Size = new System.Drawing.Size(90, 23);
            this.generatePoly.TabIndex = 9;
            this.generatePoly.Text = "Generate";
            this.generatePoly.UseVisualStyleBackColor = true;
            this.generatePoly.Click += new System.EventHandler(this.generatePoly_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Frequency:";
            // 
            // FrequencyPoly
            // 
            this.FrequencyPoly.Location = new System.Drawing.Point(6, 229);
            this.FrequencyPoly.Maximum = 7903;
            this.FrequencyPoly.Minimum = 1;
            this.FrequencyPoly.Name = "FrequencyPoly";
            this.FrequencyPoly.Size = new System.Drawing.Size(245, 45);
            this.FrequencyPoly.TabIndex = 5;
            this.FrequencyPoly.Value = 176;
            this.FrequencyPoly.Scroll += new System.EventHandler(this.FrequencyPoly_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Amplitude:";
            // 
            // AmplitudePoly
            // 
            this.AmplitudePoly.Location = new System.Drawing.Point(6, 157);
            this.AmplitudePoly.Maximum = 32760;
            this.AmplitudePoly.Minimum = -32760;
            this.AmplitudePoly.Name = "AmplitudePoly";
            this.AmplitudePoly.Size = new System.Drawing.Size(245, 45);
            this.AmplitudePoly.TabIndex = 3;
            this.AmplitudePoly.Scroll += new System.EventHandler(this.AmplitudePoly_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Wave Type:";
            // 
            // WaveTypePolyBox
            // 
            this.WaveTypePolyBox.FormattingEnabled = true;
            this.WaveTypePolyBox.Location = new System.Drawing.Point(6, 113);
            this.WaveTypePolyBox.Name = "WaveTypePolyBox";
            this.WaveTypePolyBox.Size = new System.Drawing.Size(245, 21);
            this.WaveTypePolyBox.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GenModButton);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.ModulationTypeBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(267, 356);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modulation";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // GenModButton
            // 
            this.GenModButton.Location = new System.Drawing.Point(6, 69);
            this.GenModButton.Name = "GenModButton";
            this.GenModButton.Size = new System.Drawing.Size(75, 23);
            this.GenModButton.TabIndex = 5;
            this.GenModButton.Text = "Generate";
            this.GenModButton.UseVisualStyleBackColor = true;
            this.GenModButton.Click += new System.EventHandler(this.GenModButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Modulation Type:";
            // 
            // ModulationTypeBox
            // 
            this.ModulationTypeBox.FormattingEnabled = true;
            this.ModulationTypeBox.Location = new System.Drawing.Point(6, 23);
            this.ModulationTypeBox.Name = "ModulationTypeBox";
            this.ModulationTypeBox.Size = new System.Drawing.Size(121, 21);
            this.ModulationTypeBox.TabIndex = 3;
            // 
            // WaveGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 353);
            this.Controls.Add(this.tabControl1);
            this.Name = "WaveGenerator";
            this.Text = "Wave Generator";
            this.Load += new System.EventHandler(this.WaveGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AmplitudeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyTrackBar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DutyFactor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyPoly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmplitudePoly)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateWave;
        private System.Windows.Forms.ComboBox WaveTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar AmplitudeTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar FrequencyTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox WaveTypePolyBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar FrequencyPoly;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar AmplitudePoly;
        private System.Windows.Forms.Button generatePoly;
        private System.Windows.Forms.Button addSignal;
        private System.Windows.Forms.ListBox WaveTypeList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar DutyFactor;
        private System.Windows.Forms.Button removeSignal;
        private System.Windows.Forms.ComboBox ModulationTypeBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button GenModButton;
    }
}

