#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Required for file operations
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
        Create a Dictionary data structure with a TKey of type integer and a TValue of type string, name the new data structure �MasterFile�.
        */
        public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();
        #endregion
        #region 4.2 Load Dictionary Data from File
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
            LoadListBoxRawData();
        }
        #endregion
        #region 4.3 Display Dictionary Data
        /*
        Create a method to display the Dictionary data into a non-selectable display only list box (ie read only).
        */
        private void LoadListBoxRawData() 
        { 
            // Clear list box.
            listBoxRawData.Items.Clear();
            // Loop though each entry of the dictionary.
            foreach (var entry in MasterFile)
            {
                // Add the entry to the the list box.
                listBoxRawData.Items.Add(entry);
            }
        }
        #endregion
        #region 4.4 Filter Staff Name
        /*
        Create a method to filter the Staff Name data from the Dictionary into a second filtered and selectable list box. 
        This method must use a text box input and update as each character is entered. The list box must reflect the filtered data in real time.
        */
        #endregion
        #region 4.5 Filter Staff ID
        /*
        Create a method to filter the Staff ID data from the Dictionary into the second filtered and selectable list box. 
        This method must use a text box input and update as each number is entered. The list box must reflect the filtered data in real time.
        */
        #endregion
        #region 4.6 Cear and Focus: Staff Name
        /*
        Create a method for the Staff Name text box which will clear the contents and place the focus into the Staff Name text box. Utilise a keyboard shortcut.
        */
        #endregion
        #region 4.7 Cear and Focus: Staff ID
        /*
        Create a method for the Staff ID text box which will clear the contents and place the focus into the text box. Utilise a keyboard shortcut.
        */
        #endregion
        #region 4.8 Display Selected Staff
        /*
        Create a method for the filtered and selectable list box which will populate the two text boxes when a staff record is selected. 
        Utilise the Tab and keyboard keys.
        */
        #endregion
        #region 4.9 Open Admin Form
        /*
        Create a method that will open the Admin GUI when the Alt + A keys are pressed. Ensure the General GUI sends the currently selected Staff ID and Staff 
        Name to the Admin GUI for Update and Delete purposes and is opened as modal. Create modified logic to open the Admin GUI to Create a new user when the 
        Staff ID 77 and the Staff Name is empty. Read the appropriate criteria in the Admin GUI for further information.
        */
        #endregion
    }
}