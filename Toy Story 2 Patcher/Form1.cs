using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toy_Story_2_Patcher
{
    public partial class Form1 : Form
    {
        const float VERSION = 1.0f; //Version number in window title
        const String FILENAME = "toy2.exe"; //The game's exe filename

        //Set up patch info
        //offset | original bytes | new bytes
        Patch pchASPECT    = new Patch(0xCE092, new byte[] { 0x00, 0x00, 0x40, 0x3F });
        Patch pch32BIT     = new Patch(0xACA44, new byte[] { 0x74 }, new byte[] { 0xEB });
        Patch pchENUMERATE = new Patch(0xAC9EB, new byte[] { 0x75, 0x10, 0xF6, 0xC5, 0x01 }, new byte[] { 0xE9, 0x18, 0x01, 0x00, 0x00 });

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Append version number to window title
            this.Text = this.Text + " (v" + VERSION + ")";

            //Automatically detect Toy2.exe in default directories         
            String[] filePaths = { "\\"
                                   , "C:\\Program Files (x86)\\Disney Interactive\\Toy Story 2\\"
                                   , "C:\\Program Files\\Disney Interactive\\Toy Story 2\\"
                                   , "M:\\Games\\Installed\\Toy Story 2\\"
                                 };

            //Check if file exists in any of the paths
            foreach (String fp in filePaths)
            {
                String fullPath = fp + FILENAME;

                if (File.Exists(fullPath))
                {
                    foundExeEvent(fullPath);
                    break;
                }
            }

        }

        //Browse button
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //Setup dialog box
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Executable Files (*.exe)|*.exe"; //Limit to .exe files
            dialog.FileName = FILENAME;
            dialog.CheckFileExists = true;

            //Set dialog path to the inputed string or default to this program's working directory
            string path = tbFilePath.Text;
            if (path.Equals(""))
                path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            dialog.InitialDirectory = Path.GetDirectoryName(path);

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Warn user if they aren't opening a toy2.exe file
                if (!String.Equals(FILENAME, dialog.FileName))
                    MessageBox.Show("Warning! This program only works with " + FILENAME + ".\nIt will damage or corrupt other kinds of .exe files.");

                foundExeEvent(Path.GetFullPath(dialog.FileName));
            }
        }

        //Call this function every time a valid exe file is chosen
        private void foundExeEvent(String path)
        {
            //Fill in the file path text box
            tbFilePath.Text = path;

            //Check if patches are already applied
            byte[] fileBuffer = File.ReadAllBytes(path);

            cb32Bit.Checked = patchIsApplied(ref fileBuffer, pch32BIT);
            cbSuitableDevice.Checked = patchIsApplied(ref fileBuffer, pchENUMERATE);            
        }

        //Check and return if a patch was already installed
        //returns true only if the new bytes match
        private bool patchIsApplied(ref byte[] fileBuffer, Patch patch)
        {
            bool result = true;

            int count = 0;
            foreach (byte b in patch.newBytes)
            {
                if (fileBuffer[patch.offset + count] != b)
                {
                    result = false;
                    break;
                }
                count++;
            }

            return result;
        }

        //Aspect apply button
        private void btnAspectApply_Click(object sender, EventArgs e)
        {            
            btnAspectApply.Enabled = false; //Disable button while function does its thing

            if (gameExeExists() == true)
            {
                int width = StringToNumber(tbWidth.Text);
                int height = StringToNumber(tbHeight.Text);

                if (width == -1 || height == -1)
                {
                    //Input error
                    MessageBox.Show("Width and height must be a number.");
                }
                else
                {
                    //Get aspect bytes and give it to the patch object
                    float aspect = (float)height / (float)width;
                    pchASPECT.newBytes = BitConverter.GetBytes(aspect);

                    byte[] fileBuffer = File.ReadAllBytes(tbFilePath.Text); //Read game file into memory
                    fileBackup(ref fileBuffer); //Try to backup file before patching it

                    applyPatch(ref fileBuffer, pchASPECT);

                    File.WriteAllBytes(tbFilePath.Text, fileBuffer); //Re write file

                    MessageBox.Show("Patch complete!");
                }
            }
            else
            {
                MessageBox.Show("Game exe path was not found, or could not be opened.");
            }

            btnAspectApply.Enabled = true; //Re enable button
        }

        //Apply game fixes button
        private void btnFixApply_Click(object sender, EventArgs e)
        {
            btnFixApply.Enabled = false; //Disable button while the function does its thing

            if (gameExeExists() == true)
            {
                byte[] fileBuffer = File.ReadAllBytes(tbFilePath.Text); //Read exe file into memory
                fileBackup(ref fileBuffer); //Try to backup file before patching it

                //Apply or restore patches depending on checkbox state
                applyPatch(ref fileBuffer, pch32BIT, cb32Bit.Checked);
                applyPatch(ref fileBuffer, pchENUMERATE, cbSuitableDevice.Checked);

                File.WriteAllBytes(tbFilePath.Text, fileBuffer); //Re write exe file

                MessageBox.Show("Patch complete!");
            }
            else
            {
                MessageBox.Show("Game exe path was not found, or could not be opened.");
            }

            btnFixApply.Enabled = true; //Re enable button
        }

        //Insert patch data into virtual version of the game file
        private void applyPatch(ref byte[] fileBuffer, Patch patch, bool usenew = true)
        {
            byte[] thisPatch = patch.newBytes;

            //Insert original bytes instead of the new ones
            if (usenew == false)
                thisPatch = patch.oldBytes;

            int count = 0;
            foreach (byte b in thisPatch)
            {
                fileBuffer[patch.offset + count] = b;
                count++;
            }
        }

        //Checks if the chosen file exists and is valid
        private bool gameExeExists()
        {
            if (File.Exists(tbFilePath.Text))
                return true;

            //Do further accuracy checks

            return false;
        }

        //convert text box string to number
        //returns -1 if error
        private int StringToNumber(String str)
        {
            //Remove whitespace
            str.Trim();
            str.Replace(" ", "");

            //Check if input converts to an int
            int result = -1;
            if ( (int.TryParse(str, out result)) )
                return result;

            return -1;
        }

        //Backup file only if a backup does not already exist
        private void fileBackup(ref byte[] fileBuffer)
        {
            String bakPath = tbFilePath.Text + ".bak";

            if (!File.Exists(bakPath))
                File.WriteAllBytes(bakPath, fileBuffer);
        }

        //Automatically insert primary monitor resolution into input boxes
        private void btnAuto_Click(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width,
                h = Screen.PrimaryScreen.Bounds.Height;

            tbWidth.Text = "" + w;
            tbHeight.Text = "" + h;
        }

        //Insert original aspect ratio into input boxes
        private void btnReset_Click(object sender, EventArgs e)
        {
            tbWidth.Text = "4";
            tbHeight.Text = "3";
        }

        //Link labels
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.speedrun.com/toys2/thread/mh6ev/3#rk874");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.speedrun.com/toys2/thread/mh6ev/3#rk874");
        }    
    }

    public class Patch
    {
        public long offset;
        public byte[] newBytes;
        public byte[] oldBytes;

        public Patch() { }

        public Patch(long offset, byte[] oldBytes)
        {
            //Used for aspect ratio patch
            //new bytes will be changed later
            this.offset = offset;
            this.oldBytes = oldBytes;
        }

        public Patch(long offset, byte[] oldBytes, byte[] newBytes)
        {
            //Used for checkbox patches
            this.offset = offset;
            this.newBytes = newBytes;
            this.oldBytes = oldBytes;
        }
    }
}
