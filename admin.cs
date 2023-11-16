#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion
//Name: Francis Sullivan.
//Student ID: 30034007.
//Complex Data Structures AT3.
namespace staff_id_tracker
{
    public partial class Admin : Form
    {
        #region Initialisation
        // Create Admin form versions of General Form and TraceListener.
        private General generalFormAdminInstance;
        private TextWriterTraceListener traceListenerInstance;
        public Admin(General instanceParam, string idParam, string nameParam, TextWriterTraceListener traceListenerParam)
        {
            InitializeComponent();
            // Pass from General Form Trace Listener to Admin Form.
            traceListenerInstance = traceListenerParam;
            // Pass from General Form to Admin Form.
            generalFormAdminInstance = instanceParam;
            ReceiveData(idParam, nameParam);
            // Create new ID if conditions within method are met.
            GenerateUniqueID();
        }
        #endregion
        #region 5.2 Receive Staff ID from General Form
        //Create a method that will receive the Staff ID from the General GUI 
        //and then populate text boxes with the related data. 
        private void ReceiveData(string idParam, string nameParam)
        {
            // Fill Admin Form text boxes with imported values.
            textBoxStaffID.Text = idParam;
            textBoxStaffName.Text = nameParam;
        }
        #endregion
        #region 5.3 Create New Staff ID
        //Create a method that will create a new Staff ID and input the staff name 
        //from the related text box. The Staff ID must be unique starting with 77xxxxxxx 
        //while the staff name may be duplicated. The new staff member must be added to 
        //the Dictionary data structure.
        private void CreateEntry()
        {
            // Extract selected Staff ID from textbox.
            int staffID = int.Parse(textBoxStaffID.Text);
            // Check if ID is already in dictionary.
            if (!General.MasterFile.ContainsKey(staffID))
            {
                // Add ID and Name as a new dictionary entry.
                General.MasterFile.Add(int.Parse(textBoxStaffID.Text), textBoxStaffName.Text);
                // Update Tool Strip.
                toolStripStatusLabel.Text = "New item Added";
            }
            else
                toolStripStatusLabel.Text = "Item already exits";
        }
        private void GenerateUniqueID()
        {
            // Check for "77" in ID textbox, and that name textbox is blank.
            if (textBoxStaffID.Text == "77" && textBoxStaffName.Text == "")
            {
                // Set flag.
                bool uniqueIDFound = false;
                while (uniqueIDFound == false)
                {
                    // Import random class.
                    Random random = new Random();
                    // generate random number with 9 digits.
                    int randomID = 770000000 + random.Next(0, 9999999);
                    // Check whether the ID is already in the dictionary.
                    if (!General.MasterFile.ContainsKey(randomID))
                    {
                        // Update flag.
                        uniqueIDFound = true;
                        // Send unique ID to ID textbox.
                        textBoxStaffID.Text = randomID.ToString();
                        // Update Tool Strip.
                        toolStripStatusLabel.Text = "Unique ID Generated";
                    }
                }
            }
        }
        #endregion
        #region 5.4 Update Staff ID
        //Create a method that will Update the name of the current Staff ID.
        private void UpdateEntry()
        {
            // Extract selected Staff ID from textbox.
            int staffID = int.Parse(textBoxStaffID.Text);
            // Check if ID is already in dictionary.
            if (General.MasterFile.ContainsKey(staffID))
            {
                // Start Stopwatch.
                var sw = Stopwatch.StartNew();
                // Update dictionary entry where ID matches that of the ID textbox
                // with the name from the name textbox.
                General.MasterFile[int.Parse(textBoxStaffID.Text)] = textBoxStaffName.Text;
                // Take measurement from Stopwatch, save as string.
                string swElapsedTicks = sw.ElapsedTicks.ToString();
                // Write the elapsed time to the log file.
                traceListenerInstance.WriteLine("Update time in ticks: " + swElapsedTicks);
                // Update Tool Strip.
                toolStripStatusLabel.Text = "Item Updated";
            }
            else
                toolStripStatusLabel.Text = "Item is not in dictionary, please create item first.";
        }
        #endregion
        #region 5.5 Delete Staff ID
        //Create a method that will Remove the current Staff ID and clear the text boxes.
        private void DeleteEntry()
        {
            General.MasterFile.Remove(int.Parse(textBoxStaffID.Text));
            ConfirmAndClear("Item Deleted");
            textBoxStaffName.Enabled = false;
        }
        #endregion
        #region 5.6 Save Changes to CSV
        //Create a method that will save changes to the csv file, this method should be 
        //called as the Admin GUI closes.
        private void SaveChanges()
        {
            var sw = Stopwatch.StartNew();
            File.WriteAllLines("MalinStaffNamesV2.csv", General.MasterFile.Select(kvp => $"{kvp.Key},{kvp.Value}"));
            var swSave = sw.ElapsedTicks.ToString();
            var resultUpdate = "Write to CSV time in ticks: " + swSave;
            traceListenerInstance.WriteLine(resultUpdate);
        }
        #endregion
        #region 5.7 Close Admin Form
        //Create a method that will close the Admin GUI when the Alt + L keys are pressed.
        private void CloseAdminForm()
        {
            SaveChanges();
            generalFormAdminInstance.LoadDictionary();
            Close();
        }
        #endregion
        #region 5.8 Status Strip Feedback
        //Add suitable error trapping and user feedback via a status strip or similar to 
        //ensure a fully functional User Experience. 
        //Make all methods private and ensure the Dictionary is updated. 
        private void ConfirmAndClear(string statusMessageParam)
        {
            toolStripStatusLabel.Text = statusMessageParam;
            textBoxStaffID.Text = "";
            textBoxStaffName.Text = "";
        }
        #endregion
        #region Keyboard Shortcuts
        // "KeyPreview" must be set to true for this to work.
        private void Admin_KeyDown(object sender, KeyEventArgs e)
        {
            // Checks for the "Alt" key.
            if (e.Modifiers == Keys.Alt)
            {
                // Key other than "Alt" that is held down.
                switch (e.KeyCode)
                {
                    // "C" key: Create.
                    case Keys.C:
                        CreateEntry();
                        break;
                    // "U" key: Update.
                    case Keys.U:
                        UpdateEntry();
                        break;
                    // "D" key: Delete.
                    case Keys.D:
                        DeleteEntry();
                        break;
                    // "L" key: Close Admin Form.
                    case Keys.L:
                        CloseAdminForm();
                        break;
                }
            }
        }
        #endregion
    }
}
