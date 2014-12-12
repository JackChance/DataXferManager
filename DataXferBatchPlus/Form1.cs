using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataXferBatchPlus
{
    
    public partial class DataXferForm : Form
    {
        //global variables to handle moving the file paths around.
        string targettextbox = "";
        string sourcetextbox = "";
        //template for unhiding system/hidden folders that result.
        string unhide = "attrib -h -s ";
        //access to command prompt
        ElevatedCmd runme = new ElevatedCmd();
        public DataXferForm()
        {
            InitializeComponent();
        }
        //allow the user to browse the folder to copy to
        private void BrowseTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog oFD = new FolderBrowserDialog();
            DialogResult result = oFD.ShowDialog();
            if (result == DialogResult.OK)
            {
                string location = oFD.SelectedPath;
                targettbx.Text = location;
            }
        }
        //allow the user to browse for the folder to copy from
        private void BrowseSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog oFD = new FolderBrowserDialog();
            DialogResult result = oFD.ShowDialog();
            if (result == DialogResult.OK)
            {
                string location = oFD.SelectedPath;
                sourcetbx.Text = location;
            }
        }
        //toggle qbox off it fbox is turned on
        private void fbox_CheckedChanged(object sender, EventArgs e)
        {
            if (qbox.Checked && fbox.Checked)
            {
                qbox.Checked = false;
            }
           
        }
        //toggle fbox off it qbox is turned on.
        private void qbox_CheckedChanged(object sender, EventArgs e)
        {
            if(fbox.Checked && qbox.Checked)
            {
                fbox.Checked = false;
            }
           
        }
        //on click construct the cmd command that will handle the directory transfer 
        private void transferbtn_Click(object sender, EventArgs e)
        {
            string source = this.sourcetextbox;
            string target = this.targettextbox;
            string copylaws = "xcopy ";
            //check that the file paths are valid
            if (Directory.Exists(source))
            {
                //validate the target file root
                if (Directory.Exists(target.Substring(0, 2)))
                {

                    //validate the target file path
                    if (target.IndexOfAny(Path.GetInvalidPathChars()) != -1)
                    {
                        MessageBox.Show("Invalid file path "+ target);
                    }
                    else
                    {
                        //To keep things simple all check boxes are named after the cmd switch that they need to add in order to have
                        //the proper effect and all strings end with a space when appended. Always assume the target is a directory (/i)
                        copylaws +="\"" + source + "\" " + "\"" + target + "\" /i /h ";
                        if (cbox.Checked)
                        {
                            copylaws += "/c ";
                        }
                        if (ybox.Checked)
                        {
                            copylaws += "/y ";
                        }
                        if (nbox.Checked)
                        {
                            copylaws += "/n ";
                        }
                        if (qbox.Checked)
                        {
                            copylaws += "/q ";
                        }
                        if (sbox.Checked)
                        {
                            copylaws += "/s ";
                        }
                        if (fbox.Checked)
                        {
                            copylaws += "/f ";
                        }
                        if (jbox.Checked)
                        {
                            copylaws += "/j ";
                        }
                        if (ubox.Checked)
                        {
                            copylaws += "/u ";
                        }
                        if(lBox.Checked)
                        {
                            copylaws += "/l";
                        }
                    }
                }
                else
                {
                    //check to see if the path specified is even long enough to be a root file
                    if (target.Length >= 2)
                    {
                        //let the user know that the root file doesn't exist.
                        MessageBox.Show("Invalid file root: "+target.Substring(0, 2));
                    }
                    else
                    {
                        //let the user know that the root file is unspecified.
                        MessageBox.Show("Invalid file root: path of insufficient length.");
                    }
                }
                //debugging to check display of string
                //copylaws += "/l";
                //MessageBox.Show(copylaws);
                string formatUnhide = unhide + target;
                if (runme.runElevatedCmd(copylaws, formatUnhide))
                {

                }
                else
                {
                    MessageBox.Show("An error was encountered.");
                }
            }
            else
            {
                MessageBox.Show("Source folder does not exist.");
            }


        }

        private void sourcetbx_TextChanged(object sender, EventArgs e)
        {
            // change the global variable tracking the source path
            sourcetextbox = this.sourcetbx.Text;
        }

        private void targettbx_TextChanged(object sender, EventArgs e)
        {
            //change the global variable tracking the target path
            targettextbox = this.targettbx.Text;
        }
    }
}
