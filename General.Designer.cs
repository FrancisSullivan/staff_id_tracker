﻿namespace staff_id_tracker
{
    partial class General
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
            groupBoxRawData = new GroupBox();
            listBoxRawData = new ListBox();
            statusStrip = new StatusStrip();
            groupBoxFilteredData = new GroupBox();
            textBoxStaffName = new TextBox();
            textBoxStaffID = new TextBox();
            labelStaffName = new Label();
            labelStaffID = new Label();
            listBoxFilteredData = new ListBox();
            groupBoxInstructions = new GroupBox();
            textBoxInstructions = new TextBox();
            groupBoxRawData.SuspendLayout();
            groupBoxFilteredData.SuspendLayout();
            groupBoxInstructions.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxRawData
            // 
            groupBoxRawData.Controls.Add(listBoxRawData);
            groupBoxRawData.Location = new Point(13, 13);
            groupBoxRawData.Name = "groupBoxRawData";
            groupBoxRawData.Size = new Size(400, 754);
            groupBoxRawData.TabIndex = 0;
            groupBoxRawData.TabStop = false;
            groupBoxRawData.Text = "Raw Data";
            // 
            // listBoxRawData
            // 
            listBoxRawData.FormattingEnabled = true;
            listBoxRawData.ItemHeight = 32;
            listBoxRawData.Location = new Point(6, 40);
            listBoxRawData.Name = "listBoxRawData";
            listBoxRawData.Size = new Size(388, 708);
            listBoxRawData.TabIndex = 0;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(32, 32);
            statusStrip.Location = new Point(0, 769);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1241, 38);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip";
            // 
            // groupBoxFilteredData
            // 
            groupBoxFilteredData.Controls.Add(textBoxStaffName);
            groupBoxFilteredData.Controls.Add(textBoxStaffID);
            groupBoxFilteredData.Controls.Add(labelStaffName);
            groupBoxFilteredData.Controls.Add(labelStaffID);
            groupBoxFilteredData.Controls.Add(listBoxFilteredData);
            groupBoxFilteredData.Location = new Point(419, 12);
            groupBoxFilteredData.Name = "groupBoxFilteredData";
            groupBoxFilteredData.Size = new Size(400, 754);
            groupBoxFilteredData.TabIndex = 1;
            groupBoxFilteredData.TabStop = false;
            groupBoxFilteredData.Text = "Filtered Data";
            // 
            // textBoxStaffName
            // 
            textBoxStaffName.Location = new Point(6, 147);
            textBoxStaffName.Name = "textBoxStaffName";
            textBoxStaffName.Size = new Size(382, 39);
            textBoxStaffName.TabIndex = 4;
            // 
            // textBoxStaffID
            // 
            textBoxStaffID.Location = new Point(6, 70);
            textBoxStaffID.Name = "textBoxStaffID";
            textBoxStaffID.Size = new Size(382, 39);
            textBoxStaffID.TabIndex = 3;
            // 
            // labelStaffName
            // 
            labelStaffName.AutoSize = true;
            labelStaffName.Location = new Point(6, 112);
            labelStaffName.Name = "labelStaffName";
            labelStaffName.Size = new Size(133, 32);
            labelStaffName.TabIndex = 2;
            labelStaffName.Text = "Staff Name";
            // 
            // labelStaffID
            // 
            labelStaffID.AutoSize = true;
            labelStaffID.Location = new Point(3, 35);
            labelStaffID.Name = "labelStaffID";
            labelStaffID.Size = new Size(92, 32);
            labelStaffID.TabIndex = 1;
            labelStaffID.Text = "Staff ID";
            // 
            // listBoxFilteredData
            // 
            listBoxFilteredData.FormattingEnabled = true;
            listBoxFilteredData.ItemHeight = 32;
            listBoxFilteredData.Location = new Point(6, 200);
            listBoxFilteredData.Name = "listBoxFilteredData";
            listBoxFilteredData.Size = new Size(382, 548);
            listBoxFilteredData.TabIndex = 0;
            // 
            // groupBoxInstructions
            // 
            groupBoxInstructions.Controls.Add(textBoxInstructions);
            groupBoxInstructions.Location = new Point(825, 12);
            groupBoxInstructions.Name = "groupBoxInstructions";
            groupBoxInstructions.Size = new Size(400, 754);
            groupBoxInstructions.TabIndex = 2;
            groupBoxInstructions.TabStop = false;
            groupBoxInstructions.Text = "Instructions";
            // 
            // textBoxInstructions
            // 
            textBoxInstructions.Location = new Point(3, 35);
            textBoxInstructions.Multiline = true;
            textBoxInstructions.Name = "textBoxInstructions";
            textBoxInstructions.ReadOnly = true;
            textBoxInstructions.Size = new Size(391, 713);
            textBoxInstructions.TabIndex = 0;
            textBoxInstructions.Text = "Instruction 1\r\nInstruction 2\r\n";
            // 
            // General
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 807);
            Controls.Add(groupBoxInstructions);
            Controls.Add(groupBoxFilteredData);
            Controls.Add(statusStrip);
            Controls.Add(groupBoxRawData);
            Name = "General";
            Text = "General";
            groupBoxRawData.ResumeLayout(false);
            groupBoxFilteredData.ResumeLayout(false);
            groupBoxFilteredData.PerformLayout();
            groupBoxInstructions.ResumeLayout(false);
            groupBoxInstructions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxRawData;
        private StatusStrip statusStrip;
        private GroupBox groupBoxFilteredData;
        private GroupBox groupBoxInstructions;
        private ListBox listBoxRawData;
        private ListBox listBoxFilteredData;
        private TextBox textBoxStaffName;
        private TextBox textBoxStaffID;
        private Label labelStaffName;
        private Label labelStaffID;
        private TextBox textBoxInstructions;
    }
}