using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessToMSSQL
{
    public partial class AccessToMSSQL : Form
    {
        private bool connectSqlServer = false;
        public static string database = string.Empty;
        public static string nameSchema = "dbo";
        public static List<string> tables = new List<string>();
        public static bool data = false;
        public AccessToMSSQL()
        {
            InitializeComponent();
        }

        private async void fileOpen_Click(object sender, EventArgs e)
        {
            fileAccess.Text = string.Empty;
            advancedWizard1.NextButtonEnabled = false;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "MS Access Database (*.accdb)|*.accdb|MS Access Database(compatibility 2002-2003) (*.mdb)|*.mdb|All files(*.*)|*.*";
            file.Title = "Select file:";
            if (file.ShowDialog() == DialogResult.OK)
            {
                fileAccess.Text = file.FileName;
                if (await AccessDB.CheckConnection(fileAccess.Text))
                {
                    fileAccess.Text = file.FileName;
                    advancedWizard1.NextButtonEnabled = true;
                }
                else
                {
                    fileAccess.Text = string.Empty;
                    advancedWizard1.NextButtonEnabled = false;
                    MessageBox.Show("Could not find the data to import!");
                }
            }
        }

        private async void advancedWizard1_PageChanged(object sender, AdvancedWizardControl.EventArguments.WizardPageChangedEventArgs e)
        {
            if (advancedWizard1.CurrentPage.Name == "advancedWizardPage1")
            {
                advancedWizard1.BackButtonEnabled = false;
            }
            else if (advancedWizard1.CurrentPage.Name == "advancedWizardPage2")
            {
                advancedWizard1.BackButtonEnabled = true;
                advancedWizard1.NextButtonEnabled = false;
            }
            else if (advancedWizard1.CurrentPage.Name == "advancedWizardPage3")
            {
                tables.Clear();
                advancedWizard1.NextButtonEnabled = false;
                authenticationСomboBox.SelectedIndex = 0;
                userNameTextBox.Text = Environment.UserDomainName + "\\" + Environment.UserName;
            }
            else if (advancedWizard1.CurrentPage.Name == "advancedWizardPage6")
            {
                advancedWizard1.NextButtonEnabled = false;
                database = nameDBComboBox.Text;
                foreach (string table in AccessDB.GetAllTables())
                    tablesCheckedListBox.Items.Add(table);
                for (int i = 0; i < tablesCheckedListBox.Items.Count; i++)
                    tablesCheckedListBox.SetItemChecked(i, true);
                selectAllTablesCheckBox.Checked = true;
            }
            else if (advancedWizard1.CurrentPage.Name == "advancedWizardPage7")
            {
                foreach (var table in tablesCheckedListBox.CheckedItems)
                {
                    tables.Add(table.ToString());
                }
                ImportProgressBar.Minimum = 0;
                ImportProgressBar.Step = 1;
                ImportProgressBar.Maximum = tables.Count();
                data = includeDataCheckBox.Checked;
                ImportProgressBar.Refresh();
                advancedWizard1.BackButtonEnabled = false;
                advancedWizard1.NextButtonEnabled = false;
                advancedWizard1.FinishButton = true;
                advancedWizard1.FinishButtonEnabled = false;

                if (await SqlServerDB.ImportToSqlServer(tables, data, database, ImportProgressBar) != true)
                {
                    MessageBox.Show("Can not import!");
                }
                else
                {
                    advancedWizard1.FinishButtonEnabled = true;
                    MessageBox.Show("Done!");
                }
            }
        }

        private void selectAllTablesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < tablesCheckedListBox.Items.Count; i++)
                tablesCheckedListBox.SetItemChecked(i, selectAllTablesCheckBox.Checked);
            advancedWizard1.NextButtonEnabled = selectAllTablesCheckBox.Checked;
        }

        private void tablesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = 0; i < tablesCheckedListBox.Items.Count; i++)
                if (tablesCheckedListBox.GetItemChecked(i) == true)
                    j++;
            if (j > 0)
                advancedWizard1.NextButtonEnabled = true;
            if (j == tablesCheckedListBox.Items.Count)
            {
                selectAllTablesCheckBox.Checked = true;
                selectAllTablesCheckBox.CheckedChanged += selectAllTablesCheckBox_CheckedChanged;
                advancedWizard1.NextButtonEnabled = true;
            }
            else if (j < tablesCheckedListBox.Items.Count)
            {
                selectAllTablesCheckBox.Checked = false;
                selectAllTablesCheckBox.CheckedChanged -= selectAllTablesCheckBox_CheckedChanged;
            }

        }

        private void advancedWizard1_Cancel(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the program?", "Close the program", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void authenticationСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            userPasswordTextBox.Text = string.Empty;
            if (authenticationСomboBox.SelectedIndex == 0)
            {
                userNamelabel.Text = "User name";
                userNameTextBox.Enabled = false;
                userNameTextBox.Text = Environment.UserDomainName + "\\" + Environment.UserName;
                userPasswordTextBox.Enabled = false;
            }
            else if (authenticationСomboBox.SelectedIndex == 1)
            {
                userNamelabel.Text = "Login name";
                userNameTextBox.Enabled = true;
                userNameTextBox.Text = string.Empty;
                userPasswordTextBox.Enabled = true;
            }
        }

        private async void connectSqlServerButton_Click(object sender, EventArgs e)
        {
            if (connectSqlServer == false)
            {
                string connectionString = string.Empty;
                if (authenticationСomboBox.SelectedIndex == 0)
                {
                    connectionString = "Server=" + serverNameTextBox.Text + ";Database=master;Trusted_Connection=True;";
                }
                else if (authenticationСomboBox.SelectedIndex == 1)
                {
                    connectionString = "Server=" + serverNameTextBox.Text + ";Database=master;User Id=" + userNameTextBox.Text + ";Password = " + userPasswordTextBox.Text + ";";
                }
                if (await SqlServerDB.CheckConnection(connectionString))
                {
                    advancedWizard1.NextButtonEnabled = true;
                    SqlServerDB.Open();
                    connectSqlServerButton.Text = "Disconnect";
                    connectSqlServer = true;
                    serverNameTextBox.Enabled = false;
                    authenticationСomboBox.Enabled = false;
                    userNameTextBox.Enabled = false;
                    userPasswordTextBox.Enabled = false;
                    nameDBComboBox.Enabled = true;
                    if (CheckDB(SqlServerDB.GetTableMS()).Count != 0)
                    {
                        nameDBComboBox.Items.AddRange(CheckDB(SqlServerDB.GetTableMS()).ToArray());
                        nameDBComboBox.SelectedIndex = 0;
                    }
                }
                else
                    MessageBox.Show("Could not connect to the server!");
            }
            else
            {
                advancedWizard1.NextButtonEnabled = false;
                SqlServerDB.Close();
                connectSqlServerButton.Text = "Connect";
                connectSqlServer = false;
                serverNameTextBox.Enabled = true;
                serverNameTextBox.Text = string.Empty;
                authenticationСomboBox.Enabled = true;
                authenticationСomboBox.SelectedIndex = 0;
                nameDBComboBox.Enabled = false;
                nameDBComboBox.Items.Clear();
                nameDBComboBox.ResetText();
                nameDBComboBox.SelectedIndex = -1;
                userNameTextBox.Text = Environment.UserDomainName + "\\" + Environment.UserName; ;
                userPasswordTextBox.Text = string.Empty;
            }

        }

        private List<string> CheckDB(List<string> listDB)
        {
            List<string> newListDb = new List<string>();
            foreach (string db in listDB)
            {
                if (db == "master" || db == "model" || db == "msdb" || db == "tempdb")
                    continue;
                else
                    newListDb.Add(db);
            }
            return newListDb;
        }

        private void advancedWizard1_Finish(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
