namespace AccessToMSSQL
{
    partial class AccessToMSSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessToMSSQL));
            this.advancedWizard1 = new AdvancedWizardControl.Wizard.AdvancedWizard();
            this.advancedWizardPage1 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.label1 = new System.Windows.Forms.Label();
            this.advancedWizardPage7 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.ImportProgressBar = new System.Windows.Forms.ProgressBar();
            this.advancedWizardPage6 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.selectAllTablesCheckBox = new System.Windows.Forms.CheckBox();
            this.includeDataCheckBox = new System.Windows.Forms.CheckBox();
            this.tablesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.advancedWizardPage3 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nameDBComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectSqlServerButton = new System.Windows.Forms.Button();
            this.authenticationСomboBox = new System.Windows.Forms.ComboBox();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userNamelabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.advancedWizardPage2 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.button1 = new System.Windows.Forms.Button();
            this.fileAccess = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.advancedWizardPage4 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.advancedWizardPage5 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.advancedWizard1.SuspendLayout();
            this.advancedWizardPage1.SuspendLayout();
            this.advancedWizardPage7.SuspendLayout();
            this.advancedWizardPage6.SuspendLayout();
            this.advancedWizardPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.advancedWizardPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedWizard1
            // 
            this.advancedWizard1.BackButtonEnabled = false;
            this.advancedWizard1.BackButtonText = "< Back";
            this.advancedWizard1.ButtonLayout = AdvancedWizardControl.Enums.ButtonLayoutKind.Default;
            this.advancedWizard1.ButtonsVisible = true;
            this.advancedWizard1.CancelButtonText = "&Cancel";
            this.advancedWizard1.Controls.Add(this.advancedWizardPage1);
            this.advancedWizard1.Controls.Add(this.advancedWizardPage7);
            this.advancedWizard1.Controls.Add(this.advancedWizardPage6);
            this.advancedWizard1.Controls.Add(this.advancedWizardPage3);
            this.advancedWizard1.Controls.Add(this.advancedWizardPage2);
            this.advancedWizard1.CurrentPageIsFinishPage = false;
            this.advancedWizard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizard1.FinishButton = false;
            this.advancedWizard1.FinishButtonEnabled = true;
            this.advancedWizard1.FinishButtonText = "&Finish";
            this.advancedWizard1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.advancedWizard1.HelpButton = false;
            this.advancedWizard1.HelpButtonText = "&Help";
            this.advancedWizard1.Location = new System.Drawing.Point(0, 0);
            this.advancedWizard1.Name = "advancedWizard1";
            this.advancedWizard1.NextButtonEnabled = true;
            this.advancedWizard1.NextButtonText = "Next >";
            this.advancedWizard1.ProcessKeys = false;
            this.advancedWizard1.Size = new System.Drawing.Size(644, 361);
            this.advancedWizard1.TabIndex = 0;
            this.advancedWizard1.TouchScreen = false;
            this.advancedWizard1.WizardPages.Add(this.advancedWizardPage1);
            this.advancedWizard1.WizardPages.Add(this.advancedWizardPage2);
            this.advancedWizard1.WizardPages.Add(this.advancedWizardPage3);
            this.advancedWizard1.WizardPages.Add(this.advancedWizardPage6);
            this.advancedWizard1.WizardPages.Add(this.advancedWizardPage7);
            this.advancedWizard1.Cancel += new System.EventHandler(this.advancedWizard1_Cancel);
            this.advancedWizard1.Finish += new System.EventHandler(this.advancedWizard1_Finish);
            this.advancedWizard1.PageChanged += new System.EventHandler<AdvancedWizardControl.EventArguments.WizardPageChangedEventArgs>(this.advancedWizard1_PageChanged);
            // 
            // advancedWizardPage1
            // 
            this.advancedWizardPage1.Controls.Add(this.label1);
            this.advancedWizardPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage1.Header = true;
            this.advancedWizardPage1.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage1.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage1.HeaderImage")));
            this.advancedWizardPage1.HeaderImageVisible = true;
            this.advancedWizardPage1.HeaderTitle = "MS Access to MSSQL Conversion";
            this.advancedWizardPage1.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage1.Name = "advancedWizardPage1";
            this.advancedWizardPage1.PreviousPage = 0;
            this.advancedWizardPage1.Size = new System.Drawing.Size(644, 321);
            this.advancedWizardPage1.SubTitle = "This wizard will lead you through the conversion of a MS Access database to a MSS" +
    "QL database.";
            this.advancedWizardPage1.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // advancedWizardPage7
            // 
            this.advancedWizardPage7.Controls.Add(this.ImportProgressBar);
            this.advancedWizardPage7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage7.Header = true;
            this.advancedWizardPage7.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage7.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage7.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage7.HeaderImage")));
            this.advancedWizardPage7.HeaderImageVisible = true;
            this.advancedWizardPage7.HeaderTitle = "Import process";
            this.advancedWizardPage7.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage7.Name = "advancedWizardPage7";
            this.advancedWizardPage7.PreviousPage = 0;
            this.advancedWizardPage7.Size = new System.Drawing.Size(644, 321);
            this.advancedWizardPage7.SubTitle = "Please wait while program imports all needed data to SQL Server";
            this.advancedWizardPage7.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage7.TabIndex = 5;
            // 
            // ImportProgressBar
            // 
            this.ImportProgressBar.Location = new System.Drawing.Point(21, 84);
            this.ImportProgressBar.Name = "ImportProgressBar";
            this.ImportProgressBar.Size = new System.Drawing.Size(598, 23);
            this.ImportProgressBar.TabIndex = 18;
            // 
            // advancedWizardPage6
            // 
            this.advancedWizardPage6.Controls.Add(this.selectAllTablesCheckBox);
            this.advancedWizardPage6.Controls.Add(this.includeDataCheckBox);
            this.advancedWizardPage6.Controls.Add(this.tablesCheckedListBox);
            this.advancedWizardPage6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage6.Header = true;
            this.advancedWizardPage6.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage6.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage6.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage6.HeaderImage")));
            this.advancedWizardPage6.HeaderImageVisible = true;
            this.advancedWizardPage6.HeaderTitle = "Select Tables";
            this.advancedWizardPage6.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage6.Name = "advancedWizardPage6";
            this.advancedWizardPage6.PreviousPage = 2;
            this.advancedWizardPage6.Size = new System.Drawing.Size(644, 321);
            this.advancedWizardPage6.SubTitle = "Select the tables you want to transfer from the source database to the destinatio" +
    "n database.";
            this.advancedWizardPage6.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage6.TabIndex = 4;
            // 
            // selectAllTablesCheckBox
            // 
            this.selectAllTablesCheckBox.AutoSize = true;
            this.selectAllTablesCheckBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectAllTablesCheckBox.Location = new System.Drawing.Point(21, 218);
            this.selectAllTablesCheckBox.Name = "selectAllTablesCheckBox";
            this.selectAllTablesCheckBox.Size = new System.Drawing.Size(150, 19);
            this.selectAllTablesCheckBox.TabIndex = 20;
            this.selectAllTablesCheckBox.Text = "Select All \\ Select None";
            this.selectAllTablesCheckBox.UseVisualStyleBackColor = true;
            this.selectAllTablesCheckBox.CheckedChanged += new System.EventHandler(this.selectAllTablesCheckBox_CheckedChanged);
            // 
            // includeDataCheckBox
            // 
            this.includeDataCheckBox.AutoSize = true;
            this.includeDataCheckBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.includeDataCheckBox.Location = new System.Drawing.Point(21, 243);
            this.includeDataCheckBox.Name = "includeDataCheckBox";
            this.includeDataCheckBox.Size = new System.Drawing.Size(115, 19);
            this.includeDataCheckBox.TabIndex = 19;
            this.includeDataCheckBox.Text = "Import with Data";
            this.includeDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // tablesCheckedListBox
            // 
            this.tablesCheckedListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablesCheckedListBox.FormattingEnabled = true;
            this.tablesCheckedListBox.Location = new System.Drawing.Point(21, 75);
            this.tablesCheckedListBox.Name = "tablesCheckedListBox";
            this.tablesCheckedListBox.Size = new System.Drawing.Size(330, 130);
            this.tablesCheckedListBox.TabIndex = 17;
            this.tablesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.tablesCheckedListBox_SelectedIndexChanged);
            // 
            // advancedWizardPage3
            // 
            this.advancedWizardPage3.Controls.Add(this.groupBox2);
            this.advancedWizardPage3.Controls.Add(this.groupBox1);
            this.advancedWizardPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage3.Header = true;
            this.advancedWizardPage3.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage3.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage3.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage3.HeaderImage")));
            this.advancedWizardPage3.HeaderImageVisible = true;
            this.advancedWizardPage3.HeaderTitle = "Destination Database";
            this.advancedWizardPage3.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage3.Name = "advancedWizardPage3";
            this.advancedWizardPage3.PreviousPage = 1;
            this.advancedWizardPage3.Size = new System.Drawing.Size(644, 321);
            this.advancedWizardPage3.SubTitle = "Specify the MSSQL destination database and connection information.";
            this.advancedWizardPage3.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameDBComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(15, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 48);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MSSQL Destiantion Database";
            // 
            // nameDBComboBox
            // 
            this.nameDBComboBox.Enabled = false;
            this.nameDBComboBox.FormattingEnabled = true;
            this.nameDBComboBox.Location = new System.Drawing.Point(150, 15);
            this.nameDBComboBox.Name = "nameDBComboBox";
            this.nameDBComboBox.Size = new System.Drawing.Size(175, 21);
            this.nameDBComboBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Destiantion Database";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectSqlServerButton);
            this.groupBox1.Controls.Add(this.authenticationСomboBox);
            this.groupBox1.Controls.Add(this.userPasswordLabel);
            this.groupBox1.Controls.Add(this.userPasswordTextBox);
            this.groupBox1.Controls.Add(this.userNamelabel);
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.serverNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MSSQL Connection Options";
            // 
            // connectSqlServerButton
            // 
            this.connectSqlServerButton.Location = new System.Drawing.Point(110, 119);
            this.connectSqlServerButton.Name = "connectSqlServerButton";
            this.connectSqlServerButton.Size = new System.Drawing.Size(103, 23);
            this.connectSqlServerButton.TabIndex = 9;
            this.connectSqlServerButton.Text = "Connect";
            this.connectSqlServerButton.UseVisualStyleBackColor = true;
            this.connectSqlServerButton.Click += new System.EventHandler(this.connectSqlServerButton_Click);
            // 
            // authenticationСomboBox
            // 
            this.authenticationСomboBox.FormattingEnabled = true;
            this.authenticationСomboBox.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.authenticationСomboBox.Location = new System.Drawing.Point(111, 40);
            this.authenticationСomboBox.Name = "authenticationСomboBox";
            this.authenticationСomboBox.Size = new System.Drawing.Size(175, 21);
            this.authenticationСomboBox.TabIndex = 8;
            this.authenticationСomboBox.SelectedIndexChanged += new System.EventHandler(this.authenticationСomboBox_SelectedIndexChanged);
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPasswordLabel.Location = new System.Drawing.Point(36, 94);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(68, 16);
            this.userPasswordLabel.TabIndex = 7;
            this.userPasswordLabel.Text = "Password";
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Enabled = false;
            this.userPasswordTextBox.Location = new System.Drawing.Point(110, 93);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(176, 20);
            this.userPasswordTextBox.TabIndex = 6;
            // 
            // userNamelabel
            // 
            this.userNamelabel.AutoSize = true;
            this.userNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNamelabel.Location = new System.Drawing.Point(30, 67);
            this.userNamelabel.Name = "userNamelabel";
            this.userNamelabel.Size = new System.Drawing.Size(71, 16);
            this.userNamelabel.TabIndex = 5;
            this.userNamelabel.Text = "Username";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Enabled = false;
            this.userNameTextBox.Location = new System.Drawing.Point(110, 67);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(176, 20);
            this.userNameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Authentication";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(56, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server";
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Location = new System.Drawing.Point(110, 15);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(339, 20);
            this.serverNameTextBox.TabIndex = 0;
            // 
            // advancedWizardPage2
            // 
            this.advancedWizardPage2.Controls.Add(this.button1);
            this.advancedWizardPage2.Controls.Add(this.fileAccess);
            this.advancedWizardPage2.Controls.Add(this.label2);
            this.advancedWizardPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage2.Header = true;
            this.advancedWizardPage2.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage2.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage2.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage2.HeaderImage")));
            this.advancedWizardPage2.HeaderImageVisible = true;
            this.advancedWizardPage2.HeaderTitle = "Source Database";
            this.advancedWizardPage2.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage2.Name = "advancedWizardPage2";
            this.advancedWizardPage2.PreviousPage = 0;
            this.advancedWizardPage2.Size = new System.Drawing.Size(644, 321);
            this.advancedWizardPage2.SubTitle = "Specify which MS Access database to use as data source for the transfer.";
            this.advancedWizardPage2.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // fileAccess
            // 
            this.fileAccess.Location = new System.Drawing.Point(95, 91);
            this.fileAccess.Name = "fileAccess";
            this.fileAccess.Size = new System.Drawing.Size(474, 20);
            this.fileAccess.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filename";
            // 
            // advancedWizardPage4
            // 
            this.advancedWizardPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage4.Header = true;
            this.advancedWizardPage4.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage4.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage4.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage4.HeaderImage")));
            this.advancedWizardPage4.HeaderImageVisible = true;
            this.advancedWizardPage4.HeaderTitle = "Step 3: Select data";
            this.advancedWizardPage4.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage4.Name = "advancedWizardPage4";
            this.advancedWizardPage4.PreviousPage = 2;
            this.advancedWizardPage4.Size = new System.Drawing.Size(644, 321);
            this.advancedWizardPage4.SubTitle = "Select data, which will be import to ";
            this.advancedWizardPage4.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage4.TabIndex = 4;
            // 
            // advancedWizardPage5
            // 
            this.advancedWizardPage5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage5.Header = true;
            this.advancedWizardPage5.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage5.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage5.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage5.HeaderImage")));
            this.advancedWizardPage5.HeaderImageVisible = true;
            this.advancedWizardPage5.HeaderTitle = "It is importing now";
            this.advancedWizardPage5.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage5.Name = "advancedWizardPage5";
            this.advancedWizardPage5.PreviousPage = 3;
            this.advancedWizardPage5.Size = new System.Drawing.Size(644, 321);
            this.advancedWizardPage5.SubTitle = "";
            this.advancedWizardPage5.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage5.TabIndex = 5;
            // 
            // AccessToMSSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 361);
            this.Controls.Add(this.advancedWizard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AccessToMSSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import DB from Access to SQL Server";
            this.advancedWizard1.ResumeLayout(false);
            this.advancedWizardPage1.ResumeLayout(false);
            this.advancedWizardPage1.PerformLayout();
            this.advancedWizardPage7.ResumeLayout(false);
            this.advancedWizardPage6.ResumeLayout(false);
            this.advancedWizardPage6.PerformLayout();
            this.advancedWizardPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.advancedWizardPage2.ResumeLayout(false);
            this.advancedWizardPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AdvancedWizardControl.Wizard.AdvancedWizard advancedWizard1;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage3;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage2;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage1;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage4;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileAccess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox nameDBComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox authenticationСomboBox;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.Label userNamelabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.Button connectSqlServerButton;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage6;
        private System.Windows.Forms.CheckBox selectAllTablesCheckBox;
        private System.Windows.Forms.CheckBox includeDataCheckBox;
        private System.Windows.Forms.CheckedListBox tablesCheckedListBox;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage7;
        private System.Windows.Forms.ProgressBar ImportProgressBar;
    }
}