using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBGenerator
{
    public partial class Form1 : Form
    {
        private List<string> instanceNames = new List<string>();

        private string installationFolder = null;

        private string databaseName = null;

        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            FillInstanceNames();
            FillDomainUpDown();
        }
        private void maskedTextBox_database_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.Match(e.KeyChar.ToString(), @"^[a-zA-Z0-9\\_\b]+$").Success)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox_database_name_TextChanged(object sender, EventArgs e)
        {
            databaseName = maskedTextBox_database_name.Text;
        }

        private void btn_select_folder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofDialog = new CommonOpenFileDialog();
            cofDialog.IsFolderPicker = true;
            if (cofDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBox_Folder.Text = cofDialog.FileName;
                installationFolder = cofDialog.FileName;
            }

        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
            if (installationFolder == null || databaseName == null || installationFolder == "" || databaseName == "")
            {
                MessageBox.Show("Select the installation folder and type name of Database", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection myConn = new SqlConnection($"Server={Environment.MachineName}\\{domainUpDown_select_Instance.SelectedItem};Integrated security=SSPI;database=master");

            String str = $"CREATE DATABASE {databaseName} ON PRIMARY " +
             $"(NAME = {databaseName}_Data, " +
             $"FILENAME = '{installationFolder}{databaseName}.mdf', " +
             "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
             $"LOG ON (NAME = {databaseName}_Log, " +
             $"FILENAME = '{installationFolder}{databaseName}.ldf', " +
             "SIZE = 1MB, " +
             "MAXSIZE = 5MB, " +
             "FILEGROWTH = 10%)";

            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

        private void FillDomainUpDown()
        {
            domainUpDown_select_Instance.Text = instanceNames[0];
            foreach (var s in instanceNames)
            {
                domainUpDown_select_Instance.Items.Add(s);
            }
        }

        private void FillInstanceNames()
        {
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        instanceNames.Add(instanceName);
                    }
                }
            }
        }
    }
}
