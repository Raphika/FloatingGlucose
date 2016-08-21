﻿using FloatingGlucose.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static FloatingGlucose.Properties.Settings;

namespace FloatingGlucose
{
    public partial class FormGlucoseSettings : Form
    {
        private bool settingsUpdatedSucessfully = false;
        public FormGlucoseSettings()
        {
            InitializeComponent();
        }

        private void txtNSURL_GotFocus(object sender, EventArgs e)
        {
            var colonPartPos = this.txtNSURL.Text.IndexOf("://");
            var azurePartPos = this.txtNSURL.Text.IndexOf(".azurewebsites.net");
            if(colonPartPos != -1 && azurePartPos != -1 && colonPartPos < azurePartPos)
            {
                this.txtNSURL.Select(colonPartPos+3, azurePartPos-colonPartPos-3);
            } 

        }
        private void txtNSURL_LostFocus(object sender, EventArgs e)
        {
            if (this.txtNSURL.Text == "")
            {
                this.txtNSURL.Text = "https://mysite.azurewebsites.net";
            }

        }


        private void updateAlarmSettingsEnabled(bool enabled=true) {
            
            var controls = this.grpAlarmSettings.Controls.OfType<NumericUpDown>().ToList();
            controls.ForEach(x =>
            {
                x.Enabled = enabled;
            });
        }

        private void updateFormControlsFromSettings() {

            var enableAlarms = Default.EnableAlarms;
            var alarmUrgentHigh = Default.AlarmUrgentHigh;
            var alarmHigh = Default.AlarmHigh;
            var alarmLow = Default.AlarmLow;
            var alarmUrgentLow = Default.AlarmUrgentLow;
            var nsurl = Default.NightscoutSite;

            var staleWarning = Default.AlarmStaleDataWarning;
            var staleUrgent = Default.AlarmStaleDataUrgent;

            this.numUrgentHigh.Value = alarmUrgentHigh;
            this.numHigh.Value = alarmHigh;
            this.numLow.Value = alarmLow;
            this.numUrgentLow.Value = alarmUrgentLow;

            this.numStaleWarning.Value = staleWarning;
            this.numStaleUrgent.Value = staleUrgent;

            this.btnUnitsMMOL.Checked = Default.GlucoseUnits == "mmol";
            this.btnUnitsMGDL.Checked = Default.GlucoseUnits == "mgdl";

            //advanced settings
            this.numScaling.Value = (decimal)Default.GuiScalingRatio;
            this.numRefreshInterval.Value = Default.RefreshIntervalInSeconds;
            this.chkEnableExceptions.Checked = Default.EnableExceptionLoggingToStderr;
            this.chkEnableRAWGlucose.Checked = Default.EnableRawGlucoseDisplay;
            

            //this is the default in the settings file
            //override it so it makes sense
            if (nsurl == "https://...")
            {
                this.txtNSURL.Text = "https://mysite.azurewebsites.net";
            }
            else
            {
                this.txtNSURL.Text = nsurl;
            }

            

            this.updateAlarmSettingsEnabled(enableAlarms);
            this.btnEnableAlarms.Checked = enableAlarms;

        }


        private void FormGlucoseSettings_Load(object sender, EventArgs e)
        {
            this.updateFormControlsFromSettings();
            this.FormClosing += this.OnClosing;

            //different increments for mmol/L and mg/dL 
            var controls = this.grpAlarmSettings.Controls.OfType<NumericUpDown>()
                .Where(x=> x.DecimalPlaces == 1).ToList();
            controls.ForEach( x => {
                x.Increment = x.Value >= 36 ? 1.0M : 0.1M;
                x.ValueChanged += new System.EventHandler(this.numericUpDowns_Value_Changed);
            });

            if (AppShared.settingsFormShouldFocusAdvancedSettings)
            {
                AppShared.settingsFormShouldFocusAdvancedSettings = false;
                this.tabSettings.SelectTab(this.tabPageAdvanced);
               
                
            }

        }

        void OnClosing(object sender, FormClosingEventArgs e)
        {

            if (this.settingsUpdatedSucessfully) {
                base.OnClosing(e);
                this.settingsUpdatedSucessfully = false;
                return;

            }
            // If shown modal, it means the initial setup is not complete
            // Close the app
            if (this.Modal)
            {
                Application.Exit();
            }

            base.OnClosing(e);
            
        }

        private void btnEnableAlarms_CheckedChanged(object sender, EventArgs e)
        {
            this.updateAlarmSettingsEnabled(this.btnEnableAlarms.Checked);
            
        }

        private void btnVerifySubmit_Click(object sender, EventArgs e)
        {
            if (!Validators.isUrl(this.txtNSURL.Text) || this.txtNSURL.Text == "https://mysite.azurewebsites.net") {
                MessageBox.Show("You have entered an invalid nightscout site URL", AppShared.appName, MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            Default.NightscoutSite = this.txtNSURL.Text;
            Default.EnableAlarms = this.btnEnableAlarms.Checked;
            Default.AlarmUrgentHigh = this.numUrgentHigh.Value;
            Default.AlarmHigh = this.numHigh.Value;
            Default.AlarmLow = this.numLow.Value;
            Default.AlarmUrgentLow = this.numUrgentLow.Value;
            Default.GlucoseUnits = this.btnUnitsMMOL.Checked ? "mmol" : "mgdl";

            Default.AlarmStaleDataUrgent = (int)this.numStaleUrgent.Value;
            Default.AlarmStaleDataWarning = (int)this.numStaleWarning.Value;

            //advanced settings
            Default.GuiScalingRatio = (float)this.numScaling.Value;
            Default.RefreshIntervalInSeconds = (int)this.numRefreshInterval.Value;
            Default.EnableExceptionLoggingToStderr = this.chkEnableExceptions.Checked;

            Default.EnableRawGlucoseDisplay = this.chkEnableRAWGlucose.Checked;

            Default.Save();

            this.settingsUpdatedSucessfully = true;
            MessageBox.Show("Settings have been saved! Please note: some settings might require a restart to take effect!",
                AppShared.appName, MessageBoxButtons.OK,MessageBoxIcon.Information);
            AppShared.notifyFormSettingsHaveChanged();
            this.Close();
        }

        private void numericUpDowns_Value_Changed(object sender, EventArgs e)
        {
            if (sender == null) {
                return;
            }

            var button = sender as NumericUpDown;

            //if above 36,assume this is a mg/dl value rather than mmol/L
            button.Increment = button.Value >= 36 ? 1.0M : 0.1M;


            

        }

        private void GlucoseUnit_Changed(object sender, EventArgs e)
        {
            var isMMOL = this.btnUnitsMMOL.Checked;
            
            if (isMMOL) {
                if (this.numUrgentHigh.Value >= 36)
                {
                    this.numUrgentHigh.Value = GlucoseStatus.toMMOL(this.numUrgentHigh.Value);
                }
                if (this.numHigh.Value >= 36)
                {
                    this.numHigh.Value = GlucoseStatus.toMMOL(this.numHigh.Value);
                }

                if (this.numLow.Value >= 36)
                {
                    this.numLow.Value = GlucoseStatus.toMMOL(this.numLow.Value);
                }

                if (this.numUrgentLow.Value >= 36)
                {
                    this.numUrgentLow.Value = GlucoseStatus.toMMOL(this.numUrgentLow.Value);
                }

            }

            else 
            {
                if (this.numUrgentHigh.Value < 36)
                {
                    this.numUrgentHigh.Value = GlucoseStatus.toMGDL(this.numUrgentHigh.Value);
                }
                if (this.numHigh.Value < 36)
                {
                    this.numHigh.Value = GlucoseStatus.toMGDL(this.numHigh.Value);
                }

                if (this.numLow.Value < 36)
                {
                    this.numLow.Value = GlucoseStatus.toMGDL(this.numLow.Value);
                }

                if (this.numUrgentLow.Value < 36)
                {
                    this.numUrgentLow.Value = GlucoseStatus.toMGDL(this.numUrgentLow.Value);
                }

            }


        }
    }
}
