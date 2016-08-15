﻿namespace FloatingGlucose
{
    partial class FloatingGlucose
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
            this.components = new System.ComponentModel.Container();
            this.lblGlucoseValue = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.lblDebugModeOn = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDelta = new System.Windows.Forms.Label();
            this.lblRawBG = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGlucoseValue
            // 
            this.lblGlucoseValue.AutoSize = true;
            this.lblGlucoseValue.BackColor = System.Drawing.Color.Black;
            this.lblGlucoseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlucoseValue.ForeColor = System.Drawing.Color.Green;
            this.lblGlucoseValue.Location = new System.Drawing.Point(77, 9);
            this.lblGlucoseValue.Name = "lblGlucoseValue";
            this.lblGlucoseValue.Size = new System.Drawing.Size(104, 55);
            this.lblGlucoseValue.TabIndex = 2;
            this.lblGlucoseValue.Text = "N/A";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdate.ForeColor = System.Drawing.Color.Green;
            this.lblLastUpdate.Location = new System.Drawing.Point(83, 77);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(42, 24);
            this.lblLastUpdate.TabIndex = 4;
            this.lblLastUpdate.Text = "N/A";
            // 
            // lblDebugModeOn
            // 
            this.lblDebugModeOn.AutoSize = true;
            this.lblDebugModeOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebugModeOn.ForeColor = System.Drawing.Color.Yellow;
            this.lblDebugModeOn.Location = new System.Drawing.Point(8, 92);
            this.lblDebugModeOn.Name = "lblDebugModeOn";
            this.lblDebugModeOn.Size = new System.Drawing.Size(35, 13);
            this.lblDebugModeOn.TabIndex = 6;
            this.lblDebugModeOn.Text = "(DEV)";
            this.lblDebugModeOn.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 76);
            // 
            // showApplicationToolStripMenuItem
            // 
            this.showApplicationToolStripMenuItem.Name = "showApplicationToolStripMenuItem";
            this.showApplicationToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.showApplicationToolStripMenuItem.Text = "Show &Application";
            this.showApplicationToolStripMenuItem.Click += new System.EventHandler(this.showApplicationToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.BackColor = System.Drawing.Color.Black;
            this.lblDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelta.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDelta.Location = new System.Drawing.Point(83, 53);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(45, 24);
            this.lblDelta.TabIndex = 7;
            this.lblDelta.Text = "N/A";
            this.lblDelta.Click += new System.EventHandler(this.lblDelta_Click);
            // 
            // lblRawBG
            // 
            this.lblRawBG.AutoSize = true;
            this.lblRawBG.BackColor = System.Drawing.Color.Black;
            this.lblRawBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRawBG.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRawBG.Location = new System.Drawing.Point(28, 27);
            this.lblRawBG.Name = "lblRawBG";
            this.lblRawBG.Size = new System.Drawing.Size(27, 29);
            this.lblRawBG.TabIndex = 8;
            this.lblRawBG.Text = "0";
            this.lblRawBG.Visible = false;
            this.lblRawBG.Click += new System.EventHandler(this.lblRawBG_Click);
            // 
            // FloatingGlucose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(216, 106);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblRawBG);
            this.Controls.Add(this.lblDelta);
            this.Controls.Add(this.lblDebugModeOn);
            this.Controls.Add(this.lblLastUpdate);
            this.Controls.Add(this.lblGlucoseValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FloatingGlucose";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FloatingGlucose";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.FloatingGlucose_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGlucoseValue;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Label lblDebugModeOn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label lblRawBG;
    }
}

