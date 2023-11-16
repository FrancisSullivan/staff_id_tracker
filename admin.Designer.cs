namespace staff_id_tracker
{
    partial class Admin
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
            groupBoxInputs = new GroupBox();
            textBoxStaffID = new TextBox();
            textBoxStaffName = new TextBox();
            labelStaffName = new Label();
            labelStaffID = new Label();
            groupBoxInstructions = new GroupBox();
            textBoxInstructions = new TextBox();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            groupBoxInputs.SuspendLayout();
            groupBoxInstructions.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInputs
            // 
            groupBoxInputs.Controls.Add(textBoxStaffID);
            groupBoxInputs.Controls.Add(textBoxStaffName);
            groupBoxInputs.Controls.Add(labelStaffName);
            groupBoxInputs.Controls.Add(labelStaffID);
            groupBoxInputs.Location = new Point(1, 1);
            groupBoxInputs.Name = "groupBoxInputs";
            groupBoxInputs.Size = new Size(356, 204);
            groupBoxInputs.TabIndex = 0;
            groupBoxInputs.TabStop = false;
            groupBoxInputs.Text = "Inputs";
            // 
            // textBoxStaffID
            // 
            textBoxStaffID.Location = new Point(11, 70);
            textBoxStaffID.Name = "textBoxStaffID";
            textBoxStaffID.ReadOnly = true;
            textBoxStaffID.Size = new Size(324, 39);
            textBoxStaffID.TabIndex = 0;
            textBoxStaffID.TabStop = false;
            // 
            // textBoxStaffName
            // 
            textBoxStaffName.Location = new Point(11, 147);
            textBoxStaffName.Name = "textBoxStaffName";
            textBoxStaffName.Size = new Size(324, 39);
            textBoxStaffName.TabIndex = 1;
            // 
            // labelStaffName
            // 
            labelStaffName.AutoSize = true;
            labelStaffName.Location = new Point(11, 112);
            labelStaffName.Name = "labelStaffName";
            labelStaffName.Size = new Size(133, 32);
            labelStaffName.TabIndex = 1;
            labelStaffName.Text = "Staff Name";
            // 
            // labelStaffID
            // 
            labelStaffID.AutoSize = true;
            labelStaffID.Location = new Point(11, 35);
            labelStaffID.Name = "labelStaffID";
            labelStaffID.Size = new Size(92, 32);
            labelStaffID.TabIndex = 0;
            labelStaffID.Text = "Staff ID";
            // 
            // groupBoxInstructions
            // 
            groupBoxInstructions.Controls.Add(textBoxInstructions);
            groupBoxInstructions.Location = new Point(363, 24);
            groupBoxInstructions.Name = "groupBoxInstructions";
            groupBoxInstructions.Size = new Size(333, 354);
            groupBoxInstructions.TabIndex = 0;
            groupBoxInstructions.TabStop = false;
            groupBoxInstructions.Text = "Instructions";
            // 
            // textBoxInstructions
            // 
            textBoxInstructions.Location = new Point(6, 38);
            textBoxInstructions.Multiline = true;
            textBoxInstructions.Name = "textBoxInstructions";
            textBoxInstructions.ReadOnly = true;
            textBoxInstructions.Size = new Size(319, 307);
            textBoxInstructions.TabIndex = 0;
            textBoxInstructions.TabStop = false;
            textBoxInstructions.Text = "Alt + C\r\n    Create New Entry\r\nAlt + U\r\n    Update Existing Entry\r\nAlt + D\r\n    Delete Entry\r\nAlt + L\r\n    Close Admin Form";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(32, 32);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 388);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(704, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 12);
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 410);
            ControlBox = false;
            Controls.Add(statusStrip);
            Controls.Add(groupBoxInstructions);
            Controls.Add(groupBoxInputs);
            KeyPreview = true;
            Name = "Admin";
            Text = "Admin";
            KeyDown += Admin_KeyDown;
            groupBoxInputs.ResumeLayout(false);
            groupBoxInputs.PerformLayout();
            groupBoxInstructions.ResumeLayout(false);
            groupBoxInstructions.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxInputs;
        private GroupBox groupBoxInstructions;
        private TextBox textBoxStaffID;
        private TextBox textBoxStaffName;
        private Label labelStaffName;
        private Label labelStaffID;
        private TextBox textBoxInstructions;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
    }
}