#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Required for file operations
using System.Text.RegularExpressions;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;
using System.Reflection.Metadata;
#endregion
namespace staff_id_tracker
{
    public partial class General : Form
    {
        #region Initialisation
        public General()
        {
            InitializeComponent();
            LoadDictionary();
        }
        #endregion
        #region 4.1 Dictionary Data Structure
        /*
        Create a Dictionary data structure with a TKey of type integer and a TValue of type string, name the new data structure “MasterFile”.
        */
        public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();
        #endregion
        #region 4.2 Load Data from File to Dictionary
        /*
        Create a method that will read the data from the .csv file into the Dictionary data structure when the GUI loads.
        */
        private void LoadDictionary()
        {
            // Clear the dictionary of any existing data.
            MasterFile.Clear();
            // Set file path of .csv file that the data will be loaded from.
            string filePath = "MalinStaffNamesV2.csv";
            // Read the .csv file, take each line of the file and place it as a seperate string within a string array.
            string[] lines = File.ReadAllLines(filePath);
            // Loop though each index of the string array.
            foreach (string line in lines)
            {
                // Split each index into two strings, along the comma, place them within another string array.
                string[] splitLine = line.Split(',');
                // Parse the "Staff ID" from string to int out of the first index of the string array.
                int staffID = int.Parse(splitLine[0]);
                // Extract the Staff Name out of the second index.
                string staffName = splitLine[1];
                // Add the values to the dictionary.
                MasterFile.Add(staffID, staffName);
            }
            // Update the raw data list box.
            DisplayListBoxRawData();
        }
        #endregion
        #region 4.3 Display Raw Dictionary Data
        /*
        Create a method to display the Dictionary data into a non-selectable display only list box (ie read only).
        */
        private void DisplayListBoxRawData()
        {
            // Clear existing list box data.
            listBoxRawData.Items.Clear();
            List<string> rawList = new List<string>();
            // Loop though each entry of the dictionary.
            foreach (var entry in MasterFile)
            {
                // Add entry to list.
                rawList.Add(entry.ToString());
            }
            // Add list to list box in one go.
            listBoxRawData.DataSource = rawList;
        }
        #endregion
        #region 4.4 Filter and Display: Staff Name
        /*
        Create a method to filter the Staff Name data from the Dictionary into a second filtered and selectable list box. 
        This method must use a text box input and update as each character is entered. The list box must reflect the filtered data in real time.
        */
        // Filter search results, add results to filtered list box.
        private void FilterDisplayStaffName()
        {
            string staffNameTextBox = textBoxStaffName.Text.ToLower();
            var filteredList = MasterFile.Where(kvp => kvp.Value.ToLower().Contains(staffNameTextBox)).ToList();
            listBoxFilteredData.DataSource = filteredList;
        }

        // Event for text being changed within the "Staff Name" text box, applies filter and display method.
        private void textBoxStaffName_TextChanged(object sender, EventArgs e)
        {
            FilterDisplayStaffName();
        }
        // KeyPress event for "Staff Name" text box.
        private void textBoxStaffName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Block unwanted characters.
            FilterKeypressesStaffName(sender, e, textBoxStaffName);
            // Clear the "Staff ID" text box.
            if (listBoxFilteredData.Focused == false)
                textBoxStaffID.Clear();
            // Clear the filtered list box if using backspace from index 0 or 1.
            if (e.KeyChar == '\b' && (textBoxStaffName.SelectionStart == 0 || textBoxStaffName.SelectionStart == 1))
                listBoxFilteredData.DataSource = null;
            // Prevents bug where list box will not clear when focusing on Staff ID text box.
            if (textBoxStaffID.Focused == true && textBoxStaffID.Text == "")
                listBoxFilteredData.DataSource = null;
            // Prevents bug where focusing to list box selects item.
            if (listBoxFilteredData.Focused == true && listBoxFilteredData.Items.Count > 1 && textBoxStaffID.Text != "")
                FilterDisplayStaffID();
        }
        // Block unwanted characters: Staff Name.
        private void FilterKeypressesStaffName(object sender, KeyPressEventArgs e, System.Windows.Forms.TextBox textBox)
        {
            /*
            Blocks all key entries except:
                "\s"        space
                "'"         apostrophe.
                "\b"        backspace and delete.
                "a-zA-Z"    alphabetic characters.
            */
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[a-zA-Z\b\s']"))
                e.Handled = true;
            // Disallow the use of the space in the first index of the text box.
            if (e.KeyChar == ' ' && textBox.SelectionStart == 0)
                e.Handled = true;
            // Allow only one space within the text box.
            if (e.KeyChar == ' ' && textBox.Text.Contains(" "))
                e.Handled = true;
        }
        #endregion
        #region 4.5 Filter and Display: Staff ID
        /*
        Create a method to filter the Staff ID data from the Dictionary into the second filtered and selectable list box. 
        This method must use a text box input and update as each number is entered. The list box must reflect the filtered data in real time.
        */
        private void FilterDisplayStaffID()
        {
            string staffIDTextBox = textBoxStaffID.Text;
            var filteredList = MasterFile.Where(kvp => kvp.Key.ToString().Contains(staffIDTextBox)).ToList();
            listBoxFilteredData.DataSource = filteredList;
        }
        // KeyPress event: Staff ID text box.
        private void textBoxStaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Block unwanted characters: Staff ID text box.
            //Blocks all key entries except:
            //    "\d"    numeric characters
            //    "\b"    backspace and delete
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b]"))
                e.Handled = true;
            // Only if character input is accepted.
            if (e.Handled == false) FilterDisplayStaffID();
            // Clear the "Staff Name" text box.
            if (listBoxFilteredData.Focused == false)
                textBoxStaffName.Clear();
            // Clear the filtered list box if using backspace from index 0 or 1.
            if (e.KeyChar == '\b' && (textBoxStaffID.SelectionStart == 0 || textBoxStaffID.SelectionStart == 1))
                listBoxFilteredData.DataSource = null;
        }
        #endregion
        #region 4.6 Clear and Focus: Staff Name
        /*
        Create a method for the Staff Name text box which will clear the contents and place the focus into the Staff Name text box. Utilise a keyboard shortcut.
        */
        private void ClearFocusStaffName()
        {
            // Clear the "Staff ID" text box.
            textBoxStaffID.Clear();
            // Clear the "Staff Name" text box.
            textBoxStaffName.Clear();
            // Focus the cursor to the "Staff Name" text box.
            textBoxStaffName.Focus();
            // Clear the filtered list box.
            List<string> blankList = new List<string>();
            listBoxFilteredData.DataSource = blankList;
        }
        #endregion
        #region 4.7 Clear and Focus: Staff ID
        /*
        Create a method for the Staff ID text box which will clear the contents and place the focus into the text box. Utilise a keyboard shortcut.
        */
        private void ClearFocusStaffID()
        {
            // Clear the "Staff ID" text box.
            textBoxStaffID.Clear();
            // Clear the "Staff Name" text box.
            textBoxStaffName.Clear();
            // Focus the cursor to the "Staff Name" text box.
            textBoxStaffID.Focus();
            // Clear the filtered list box.
            listBoxFilteredData.DataSource = null;
        }
        #endregion
        #region 4.8 Display Selected Staff
        /*
        Create a method for the filtered and selectable list box which will populate the two text boxes when a staff record is selected. 
        Utilise the Tab and keyboard keys.
        */
        private void DisplaySelectedItem()
        {
            // Only peform this action if there is actually an item in the list box.
            if (listBoxFilteredData.SelectedItem != null)
            {
                // Take the selected item in the list box and convert it to a string.
                string line = listBoxFilteredData.SelectedItem.ToString();
                // Split the string along the comma, placing each side within a string array.
                string[] splitLine = line.Split(',');
                // Extract the "Staff ID" from the array, trim the square bracket from the start of the string.
                string staffID = splitLine[0].TrimStart('[');
                // Extract the "Staff ID" from the array, trim the square bracket and blak space from the end of the string.
                string staffName = splitLine[1].TrimEnd(']').TrimStart(' ');
                // Populate the "Staff ID" text box.
                textBoxStaffID.Text = staffID;
                // Populate the "Staff Name" text box.
                textBoxStaffName.Text = staffName;
                // Reload the filtered items list box to display only the selected item.
                FilterDisplayStaffID();
            }
        }
        #endregion
        #region 4.9 Open Admin Form
        /*
        Create a method that will open the Admin GUI when the Alt + A keys are pressed. Ensure the General GUI sends the currently selected Staff ID and Staff 
        Name to the Admin GUI for Update and Delete purposes and is opened as modal. Create modified logic to open the Admin GUI to Create a new user when the 
        Staff ID 77 and the Staff Name is empty. Read the appropriate criteria in the Admin GUI for further information.
        */

        #endregion
        #region 4.10 StatusStrip Feedback

        #endregion
        #region KeyDown Shortcuts
        // KeyDown: Multi-key Shortcuts.
        // "KeyPreview" must be set to true for this to work.
        private void General_KeyDown(object sender, KeyEventArgs e)
        {
            // Checks for the "alt" key.
            if (e.Modifiers == Keys.Control)
            {
                // Key other than "alt" that is held down.
                switch (e.KeyCode)
                {
                    // "I" key: Refreshes ID text box.
                    case Keys.I:
                        ClearFocusStaffID();
                        break;
                    // "N" key: Refreshes Name text box.
                    case Keys.N:
                        ClearFocusStaffName();
                        break;
                    // "F" key: Focuses on the "Filtered Data" list box.
                    case Keys.F:
                        listBoxFilteredData.Focus();
                        break;
                    // "U" key: Focuses on the "Unfiltered Data" list box.
                    case Keys.U:
                        listBoxRawData.Focus();
                        break;
                    // "R" key: Focuses on the "Raw Data" list box.
                    case Keys.Q:
                        Application.Exit();
                        break;
                }
            }
            // Checks for "Enter" key.
            if (e.KeyCode == Keys.Enter)
            {
                // Focuses to the filted data list box.
                listBoxFilteredData.Focus();
                // Displays selected item.
                DisplaySelectedItem();
            }
        }
        #endregion
        #region Clipboard

        #endregion
    }
}
