using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace dcm4che_tk
{
    public partial class Form1 : Form
    {
        string ae;
        string host;
        string port;
        string toolkitPath;
        string uploadPath;
        string uploadFilename;

        public Form1()
        {
            InitializeComponent();
            ae = ConfigurationManager.AppSettings["ae"];
            host = ConfigurationManager.AppSettings["host"];
            port = ConfigurationManager.AppSettings["port"];
            uploadPath = ConfigurationManager.AppSettings["uploadPath"];
            toolkitPath = ConfigurationManager.AppSettings["toolkitPath"];
            uploadFilename = ConfigurationManager.AppSettings["uploadFilename"];
            settingsAe.Text = ae;
            settingsHost.Text = host;
            settingsPort.Text = port;
            settingsToolkitPath.Text = toolkitPath;
            settingsUploadPath.Text = uploadPath;
            settingsUploadFilename.Text = uploadFilename;
            notesTextBox.Text = shell(toolkitPath + @"\storescu.bat", " --help");
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            ae = settingsAe.Text;
            host = settingsHost.Text;
            port = settingsPort.Text;

            saveAppSetting("ae", ae);
            saveAppSetting("host", host);
            saveAppSetting("port", port);
        }

        private void echoButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(toolkitPath+@"\storescu.bat"))            
            {
                statusBarText.Text = "Command not found";
                return;
            }

            string cmd = toolkitPath + @"\storescu.bat";
            string arg = " -c " + ae + "@" + host + ":" + port + "\r\n";
            consoleBox.Text = shell(cmd, arg);
        }

        private string shell(string cmd, string arg)
        {
            string output ="";
            process1.StartInfo.FileName = cmd;
            process1.StartInfo.Arguments = arg;
            statusBarText.Text = cmd + arg;
            process1.StartInfo.RedirectStandardOutput = true;
            process1.StartInfo.UseShellExecute = false;
            process1.Start();
            output = process1.StandardOutput.ReadToEnd();
            process1.WaitForExit();
            return output;
        }

        private void saveAppSetting(string key, string value)
        {
            try { 
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            settings.Remove(key);
            settings.Add(key, value);
            configFile.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            statusBarText.Text = "Update complete ok";
            }
            catch (ConfigurationErrorsException) { statusBarText.Text = "saveAppSetting: " + key +"-" + value + " oops!" ;}
        }


        private void pathBrowseButton_Click(object sender, EventArgs e)
        {                        
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                toolkitPath = folderBrowser.SelectedPath;
                settingsToolkitPath.Text = toolkitPath;
                saveAppSetting("toolkitPath", toolkitPath);
            }            
        }

        private void uploadBrowseButton_Click(object sender, EventArgs e)
        {
            folderBrowser.RootFolder = Environment.SpecialFolder.UserProfile;
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uploadPath = folderBrowser.SelectedPath;
                settingsUploadPath.Text = uploadPath;
                saveAppSetting("uploadPath", uploadPath);
            }
        }

        private void buttonUploadBrowse_Click(object sender, EventArgs e)
        {
            fileBrowser.InitialDirectory = uploadPath;
            if (fileBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uploadFilename = fileBrowser.FileName;
                settingsUploadFilename.Text = uploadFilename;
                statusBarText.Text = uploadFilename;
                saveAppSetting("uploadFilename", uploadFilename);
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            statusBarText.Text = "upload " + uploadFilename;
            if (uploadFilename == "") return;

            string cmd = toolkitPath + @"\storescu.bat";
            string arg = " -c " + ae + "@" + host + ":" + port + " " + uploadFilename;// + "\r\n";
            textBox3.Text = cmd + arg;
            statusBarText.Text = cmd+arg;
        }
    }
}
 