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
            groupBoxInstructions = new GroupBox();
            labelStaffID = new Label();
            labelStaffName = new Label();
            textBoxStaffName = new TextBox();
            textBoxStaffID = new TextBox();
            textBoxInstructions = new TextBox();
            groupBoxInputs.SuspendLayout();
            groupBoxInstructions.SuspendLayout();
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
            // groupBoxInstructions
            // 
            groupBoxInstructions.Controls.Add(textBoxInstructions);
            groupBoxInstructions.Location = new Point(12, 211);
            groupBoxInstructions.Name = "groupBoxInstructions";
            groupBoxInstructions.Size = new Size(345, 354);
            groupBoxInstructions.TabIndex = 0;
            groupBoxInstructions.TabStop = false;
            groupBoxInstructions.Text = "Instructions";
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
            // labelStaffName
            // 
            labelStaffName.AutoSize = true;
            labelStaffName.Location = new Point(11, 112);
            labelStaffName.Name = "labelStaffName";
            labelStaffName.Size = new Size(133, 32);
            labelStaffName.TabIndex = 1;
            labelStaffName.Text = "Staff Name";
            // 
            // textBoxStaffName
            // 
            textBoxStaffName.Location = new Point(11, 147);
            textBoxStaffName.Name = "textBoxStaffName";
            textBoxStaffName.Size = new Size(324, 39);
            textBoxStaffName.TabIndex = 2;
            // 
            // textBoxStaffID
            // 
            textBoxStaffID.Location = new Point(11, 70);
            textBoxStaffID.Name = "textBoxStaffID";
            textBoxStaffID.Size = new Size(324, 39);
            textBoxStaffID.TabIndex = 3;
            // 
            // textBoxInstructions
            // 
            textBoxInstructions.Location = new Point(0, 38);
            textBoxInstructions.Multiline = true;
            textBoxInstructions.Name = "textBoxInstructions";
            textBoxInstructions.ReadOnly = true;
            textBoxInstructions.Size = new Size(325, 307);
            textBoxInstructions.TabIndex = 0;
            textBoxInstructions.Text = "Instruction 1\r\nInstruction 2";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 583);
            Controls.Add(groupBoxInstructions);
            Controls.Add(groupBoxInputs);
            Name = "Admin";
            Text = "Admin";
            groupBoxInputs.ResumeLayout(false);
            groupBoxInputs.PerformLayout();
            groupBoxInstructions.ResumeLayout(false);
            groupBoxInstructions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInputs;
        private GroupBox groupBoxInstructions;
        private TextBox textBoxStaffID;
        private TextBox textBoxStaffName;
        private Label labelStaffName;
        private Label labelStaffID;
        private TextBox textBoxInstructions;
    }
}