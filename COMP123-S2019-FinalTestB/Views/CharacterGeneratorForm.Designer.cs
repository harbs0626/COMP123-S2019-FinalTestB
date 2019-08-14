namespace COMP123_S2019_FinalTestB.Views
{
    partial class CharacterGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterGeneratorForm));
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.IdentityTablelLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.CharacterNameTextBox = new System.Windows.Forms.TextBox();
            this.GenerateNameButton = new System.Windows.Forms.Button();
            this.CharaterNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.AbilityPage = new System.Windows.Forms.TabPage();
            this.AbilityTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DexterityDataLabel = new System.Windows.Forms.Label();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.GenerateAbilitiesButton = new System.Windows.Forms.Button();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.ConstitutionLabel = new System.Windows.Forms.Label();
            this.IntelligenceLabel = new System.Windows.Forms.Label();
            this.WisdomLabel = new System.Windows.Forms.Label();
            this.CharismaLabel = new System.Windows.Forms.Label();
            this.ConstitutionDataLabel = new System.Windows.Forms.Label();
            this.IntelligenceDataLabel = new System.Windows.Forms.Label();
            this.WisdomDataLabel = new System.Windows.Forms.Label();
            this.CharismaDataLabel = new System.Windows.Forms.Label();
            this.InventoryPage = new System.Windows.Forms.TabPage();
            this.CharacterSheetPage = new System.Windows.Forms.TabPage();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.InventoryItemsLabel = new System.Windows.Forms.Label();
            this.Inventory1Label = new System.Windows.Forms.Label();
            this.Inventory3Label = new System.Windows.Forms.Label();
            this.Inventory4Label = new System.Windows.Forms.Label();
            this.Inventory2Label = new System.Windows.Forms.Label();
            this.GenerateInventoryButton = new System.Windows.Forms.Button();
            this.Inventory1DataLabel = new System.Windows.Forms.Label();
            this.Inventory2DataLabel = new System.Windows.Forms.Label();
            this.Inventory3DataLabel = new System.Windows.Forms.Label();
            this.Inventory4DataLabel = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.IdentityTablelLayoutPanel.SuspendLayout();
            this.AbilityPage.SuspendLayout();
            this.AbilityTableLayout.SuspendLayout();
            this.InventoryPage.SuspendLayout();
            this.CharacterSheetPage.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(671, 499);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(101, 50);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 499);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(101, 50);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentityPage);
            this.MainTabControl.Controls.Add(this.AbilityPage);
            this.MainTabControl.Controls.Add(this.InventoryPage);
            this.MainTabControl.Controls.Add(this.CharacterSheetPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(784, 493);
            this.MainTabControl.TabIndex = 4;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.IdentityTablelLayoutPanel);
            this.IdentityPage.Location = new System.Drawing.Point(4, 33);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Padding = new System.Windows.Forms.Padding(3);
            this.IdentityPage.Size = new System.Drawing.Size(776, 456);
            this.IdentityPage.TabIndex = 0;
            this.IdentityPage.Text = "Identity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // IdentityTablelLayoutPanel
            // 
            this.IdentityTablelLayoutPanel.ColumnCount = 4;
            this.IdentityTablelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.IdentityTablelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTablelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTablelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTablelLayoutPanel.Controls.Add(this.LastNameDataLabel, 1, 2);
            this.IdentityTablelLayoutPanel.Controls.Add(this.FirstNameLabel, 0, 1);
            this.IdentityTablelLayoutPanel.Controls.Add(this.CharacterNameTextBox, 1, 0);
            this.IdentityTablelLayoutPanel.Controls.Add(this.GenerateNameButton, 2, 4);
            this.IdentityTablelLayoutPanel.Controls.Add(this.CharaterNameLabel, 0, 0);
            this.IdentityTablelLayoutPanel.Controls.Add(this.LastNameLabel, 0, 2);
            this.IdentityTablelLayoutPanel.Controls.Add(this.FirstNameDataLabel, 1, 1);
            this.IdentityTablelLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.IdentityTablelLayoutPanel.Name = "IdentityTablelLayoutPanel";
            this.IdentityTablelLayoutPanel.RowCount = 5;
            this.IdentityTablelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTablelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTablelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTablelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTablelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTablelLayoutPanel.Size = new System.Drawing.Size(776, 364);
            this.IdentityTablelLayoutPanel.TabIndex = 0;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTablelLayoutPanel.SetColumnSpan(this.LastNameDataLabel, 3);
            this.LastNameDataLabel.Location = new System.Drawing.Point(235, 144);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(538, 72);
            this.LastNameDataLabel.TabIndex = 11;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLabel.Location = new System.Drawing.Point(3, 72);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(226, 72);
            this.FirstNameLabel.TabIndex = 8;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CharacterNameTextBox
            // 
            this.CharacterNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityTablelLayoutPanel.SetColumnSpan(this.CharacterNameTextBox, 3);
            this.CharacterNameTextBox.Location = new System.Drawing.Point(235, 3);
            this.CharacterNameTextBox.Multiline = true;
            this.CharacterNameTextBox.Name = "CharacterNameTextBox";
            this.CharacterNameTextBox.Size = new System.Drawing.Size(538, 66);
            this.CharacterNameTextBox.TabIndex = 10;
            // 
            // GenerateNameButton
            // 
            this.GenerateNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityTablelLayoutPanel.SetColumnSpan(this.GenerateNameButton, 2);
            this.GenerateNameButton.Location = new System.Drawing.Point(390, 291);
            this.GenerateNameButton.Name = "GenerateNameButton";
            this.GenerateNameButton.Size = new System.Drawing.Size(383, 70);
            this.GenerateNameButton.TabIndex = 5;
            this.GenerateNameButton.Text = "Generate Name";
            this.GenerateNameButton.UseVisualStyleBackColor = true;
            this.GenerateNameButton.Click += new System.EventHandler(this.GenerateNameButton_Click);
            // 
            // CharaterNameLabel
            // 
            this.CharaterNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharaterNameLabel.Location = new System.Drawing.Point(3, 0);
            this.CharaterNameLabel.Name = "CharaterNameLabel";
            this.CharaterNameLabel.Size = new System.Drawing.Size(226, 72);
            this.CharaterNameLabel.TabIndex = 6;
            this.CharaterNameLabel.Text = "Character Name";
            this.CharaterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLabel.Location = new System.Drawing.Point(3, 144);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(226, 72);
            this.LastNameLabel.TabIndex = 9;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTablelLayoutPanel.SetColumnSpan(this.FirstNameDataLabel, 3);
            this.FirstNameDataLabel.Location = new System.Drawing.Point(235, 72);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(538, 72);
            this.FirstNameDataLabel.TabIndex = 8;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AbilityPage
            // 
            this.AbilityPage.Controls.Add(this.AbilityTableLayout);
            this.AbilityPage.Location = new System.Drawing.Point(4, 33);
            this.AbilityPage.Name = "AbilityPage";
            this.AbilityPage.Padding = new System.Windows.Forms.Padding(3);
            this.AbilityPage.Size = new System.Drawing.Size(776, 456);
            this.AbilityPage.TabIndex = 1;
            this.AbilityPage.Text = "Abilities";
            this.AbilityPage.UseVisualStyleBackColor = true;
            // 
            // AbilityTableLayout
            // 
            this.AbilityTableLayout.ColumnCount = 4;
            this.AbilityTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilityTableLayout.Controls.Add(this.DexterityDataLabel, 1, 1);
            this.AbilityTableLayout.Controls.Add(this.StrengthDataLabel, 1, 0);
            this.AbilityTableLayout.Controls.Add(this.GenerateAbilitiesButton, 2, 7);
            this.AbilityTableLayout.Controls.Add(this.StrengthLabel, 0, 0);
            this.AbilityTableLayout.Controls.Add(this.DexterityLabel, 0, 1);
            this.AbilityTableLayout.Controls.Add(this.ConstitutionLabel, 0, 2);
            this.AbilityTableLayout.Controls.Add(this.IntelligenceLabel, 0, 3);
            this.AbilityTableLayout.Controls.Add(this.WisdomLabel, 0, 4);
            this.AbilityTableLayout.Controls.Add(this.CharismaLabel, 0, 5);
            this.AbilityTableLayout.Controls.Add(this.ConstitutionDataLabel, 1, 2);
            this.AbilityTableLayout.Controls.Add(this.IntelligenceDataLabel, 1, 3);
            this.AbilityTableLayout.Controls.Add(this.WisdomDataLabel, 1, 4);
            this.AbilityTableLayout.Controls.Add(this.CharismaDataLabel, 1, 5);
            this.AbilityTableLayout.Location = new System.Drawing.Point(0, 0);
            this.AbilityTableLayout.Name = "AbilityTableLayout";
            this.AbilityTableLayout.RowCount = 8;
            this.AbilityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AbilityTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AbilityTableLayout.Size = new System.Drawing.Size(776, 364);
            this.AbilityTableLayout.TabIndex = 0;
            // 
            // DexterityDataLabel
            // 
            this.DexterityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DexterityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DexterityDataLabel.Location = new System.Drawing.Point(197, 45);
            this.DexterityDataLabel.Name = "DexterityDataLabel";
            this.DexterityDataLabel.Size = new System.Drawing.Size(188, 45);
            this.DexterityDataLabel.TabIndex = 19;
            this.DexterityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDataLabel.Location = new System.Drawing.Point(197, 0);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(188, 45);
            this.StrengthDataLabel.TabIndex = 16;
            this.StrengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GenerateAbilitiesButton
            // 
            this.GenerateAbilitiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilityTableLayout.SetColumnSpan(this.GenerateAbilitiesButton, 2);
            this.GenerateAbilitiesButton.Location = new System.Drawing.Point(391, 318);
            this.GenerateAbilitiesButton.Name = "GenerateAbilitiesButton";
            this.GenerateAbilitiesButton.Size = new System.Drawing.Size(382, 43);
            this.GenerateAbilitiesButton.TabIndex = 6;
            this.GenerateAbilitiesButton.Text = "Generate Abilities";
            this.GenerateAbilitiesButton.UseVisualStyleBackColor = true;
            this.GenerateAbilitiesButton.Click += new System.EventHandler(this.GenerateAbilitiesButton_Click);
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthLabel.Location = new System.Drawing.Point(3, 0);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(188, 45);
            this.StrengthLabel.TabIndex = 10;
            this.StrengthLabel.Text = "Strength";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityLabel.Location = new System.Drawing.Point(3, 45);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(188, 45);
            this.DexterityLabel.TabIndex = 11;
            this.DexterityLabel.Text = "Dexterity";
            this.DexterityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConstitutionLabel
            // 
            this.ConstitutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConstitutionLabel.Location = new System.Drawing.Point(3, 90);
            this.ConstitutionLabel.Name = "ConstitutionLabel";
            this.ConstitutionLabel.Size = new System.Drawing.Size(188, 45);
            this.ConstitutionLabel.TabIndex = 12;
            this.ConstitutionLabel.Text = "Constitution";
            this.ConstitutionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IntelligenceLabel
            // 
            this.IntelligenceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntelligenceLabel.Location = new System.Drawing.Point(3, 135);
            this.IntelligenceLabel.Name = "IntelligenceLabel";
            this.IntelligenceLabel.Size = new System.Drawing.Size(188, 45);
            this.IntelligenceLabel.TabIndex = 13;
            this.IntelligenceLabel.Text = "Intelligence";
            this.IntelligenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WisdomLabel
            // 
            this.WisdomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WisdomLabel.Location = new System.Drawing.Point(3, 180);
            this.WisdomLabel.Name = "WisdomLabel";
            this.WisdomLabel.Size = new System.Drawing.Size(188, 45);
            this.WisdomLabel.TabIndex = 14;
            this.WisdomLabel.Text = "Wisdom";
            this.WisdomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CharismaLabel
            // 
            this.CharismaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharismaLabel.Location = new System.Drawing.Point(3, 225);
            this.CharismaLabel.Name = "CharismaLabel";
            this.CharismaLabel.Size = new System.Drawing.Size(188, 45);
            this.CharismaLabel.TabIndex = 15;
            this.CharismaLabel.Text = "Charisma";
            this.CharismaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConstitutionDataLabel
            // 
            this.ConstitutionDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConstitutionDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ConstitutionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConstitutionDataLabel.Location = new System.Drawing.Point(197, 90);
            this.ConstitutionDataLabel.Name = "ConstitutionDataLabel";
            this.ConstitutionDataLabel.Size = new System.Drawing.Size(188, 45);
            this.ConstitutionDataLabel.TabIndex = 17;
            this.ConstitutionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IntelligenceDataLabel
            // 
            this.IntelligenceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntelligenceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntelligenceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntelligenceDataLabel.Location = new System.Drawing.Point(197, 135);
            this.IntelligenceDataLabel.Name = "IntelligenceDataLabel";
            this.IntelligenceDataLabel.Size = new System.Drawing.Size(188, 45);
            this.IntelligenceDataLabel.TabIndex = 18;
            this.IntelligenceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WisdomDataLabel
            // 
            this.WisdomDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WisdomDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WisdomDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WisdomDataLabel.Location = new System.Drawing.Point(197, 180);
            this.WisdomDataLabel.Name = "WisdomDataLabel";
            this.WisdomDataLabel.Size = new System.Drawing.Size(188, 45);
            this.WisdomDataLabel.TabIndex = 20;
            this.WisdomDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CharismaDataLabel
            // 
            this.CharismaDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharismaDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CharismaDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CharismaDataLabel.Location = new System.Drawing.Point(197, 225);
            this.CharismaDataLabel.Name = "CharismaDataLabel";
            this.CharismaDataLabel.Size = new System.Drawing.Size(188, 45);
            this.CharismaDataLabel.TabIndex = 21;
            this.CharismaDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InventoryPage
            // 
            this.InventoryPage.Controls.Add(this.tableLayoutPanel1);
            this.InventoryPage.Location = new System.Drawing.Point(4, 33);
            this.InventoryPage.Name = "InventoryPage";
            this.InventoryPage.Size = new System.Drawing.Size(776, 456);
            this.InventoryPage.TabIndex = 2;
            this.InventoryPage.Text = "Inventory";
            this.InventoryPage.UseVisualStyleBackColor = true;
            // 
            // CharacterSheetPage
            // 
            this.CharacterSheetPage.Controls.Add(this.MainToolStrip);
            this.CharacterSheetPage.Controls.Add(this.MainMenuStrip);
            this.CharacterSheetPage.Location = new System.Drawing.Point(4, 33);
            this.CharacterSheetPage.Name = "CharacterSheetPage";
            this.CharacterSheetPage.Size = new System.Drawing.Size(776, 456);
            this.CharacterSheetPage.TabIndex = 3;
            this.CharacterSheetPage.Text = "Character Sheet";
            this.CharacterSheetPage.UseVisualStyleBackColor = true;
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator7,
            this.helpToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(776, 25);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(776, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.InventoryItemsLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Inventory1Label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Inventory3Label, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Inventory4Label, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Inventory2Label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.GenerateInventoryButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Inventory1DataLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Inventory2DataLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Inventory3DataLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Inventory4DataLabel, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 364);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // InventoryItemsLabel
            // 
            this.InventoryItemsLabel.AutoSize = true;
            this.InventoryItemsLabel.Location = new System.Drawing.Point(3, 0);
            this.InventoryItemsLabel.Name = "InventoryItemsLabel";
            this.InventoryItemsLabel.Size = new System.Drawing.Size(135, 24);
            this.InventoryItemsLabel.TabIndex = 0;
            this.InventoryItemsLabel.Text = "Inventory Items";
            // 
            // Inventory1Label
            // 
            this.Inventory1Label.AutoSize = true;
            this.Inventory1Label.Location = new System.Drawing.Point(3, 91);
            this.Inventory1Label.Name = "Inventory1Label";
            this.Inventory1Label.Size = new System.Drawing.Size(58, 24);
            this.Inventory1Label.TabIndex = 1;
            this.Inventory1Label.Text = "Skill 1";
            // 
            // Inventory3Label
            // 
            this.Inventory3Label.AutoSize = true;
            this.Inventory3Label.Location = new System.Drawing.Point(391, 91);
            this.Inventory3Label.Name = "Inventory3Label";
            this.Inventory3Label.Size = new System.Drawing.Size(58, 24);
            this.Inventory3Label.TabIndex = 2;
            this.Inventory3Label.Text = "Skill 3";
            // 
            // Inventory4Label
            // 
            this.Inventory4Label.AutoSize = true;
            this.Inventory4Label.Location = new System.Drawing.Point(391, 182);
            this.Inventory4Label.Name = "Inventory4Label";
            this.Inventory4Label.Size = new System.Drawing.Size(58, 24);
            this.Inventory4Label.TabIndex = 3;
            this.Inventory4Label.Text = "Skill 4";
            // 
            // Inventory2Label
            // 
            this.Inventory2Label.AutoSize = true;
            this.Inventory2Label.Location = new System.Drawing.Point(3, 182);
            this.Inventory2Label.Name = "Inventory2Label";
            this.Inventory2Label.Size = new System.Drawing.Size(58, 24);
            this.Inventory2Label.TabIndex = 4;
            this.Inventory2Label.Text = "Skill 2";
            // 
            // GenerateInventoryButton
            // 
            this.GenerateInventoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.GenerateInventoryButton, 2);
            this.GenerateInventoryButton.Location = new System.Drawing.Point(391, 276);
            this.GenerateInventoryButton.Name = "GenerateInventoryButton";
            this.GenerateInventoryButton.Size = new System.Drawing.Size(382, 85);
            this.GenerateInventoryButton.TabIndex = 6;
            this.GenerateInventoryButton.Text = "Generate Inventory";
            this.GenerateInventoryButton.UseVisualStyleBackColor = true;
            this.GenerateInventoryButton.Click += new System.EventHandler(this.GenerateInventoryButton_Click);
            // 
            // Inventory1DataLabel
            // 
            this.Inventory1DataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inventory1DataLabel.AutoSize = true;
            this.Inventory1DataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Inventory1DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inventory1DataLabel.Location = new System.Drawing.Point(197, 91);
            this.Inventory1DataLabel.Name = "Inventory1DataLabel";
            this.Inventory1DataLabel.Size = new System.Drawing.Size(188, 91);
            this.Inventory1DataLabel.TabIndex = 7;
            // 
            // Inventory2DataLabel
            // 
            this.Inventory2DataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inventory2DataLabel.AutoSize = true;
            this.Inventory2DataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Inventory2DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inventory2DataLabel.Location = new System.Drawing.Point(197, 182);
            this.Inventory2DataLabel.Name = "Inventory2DataLabel";
            this.Inventory2DataLabel.Size = new System.Drawing.Size(188, 91);
            this.Inventory2DataLabel.TabIndex = 8;
            // 
            // Inventory3DataLabel
            // 
            this.Inventory3DataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inventory3DataLabel.AutoSize = true;
            this.Inventory3DataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Inventory3DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inventory3DataLabel.Location = new System.Drawing.Point(585, 91);
            this.Inventory3DataLabel.Name = "Inventory3DataLabel";
            this.Inventory3DataLabel.Size = new System.Drawing.Size(188, 91);
            this.Inventory3DataLabel.TabIndex = 9;
            // 
            // Inventory4DataLabel
            // 
            this.Inventory4DataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Inventory4DataLabel.AutoSize = true;
            this.Inventory4DataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Inventory4DataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Inventory4DataLabel.Location = new System.Drawing.Point(585, 182);
            this.Inventory4DataLabel.Name = "Inventory4DataLabel";
            this.Inventory4DataLabel.Size = new System.Drawing.Size(188, 91);
            this.Inventory4DataLabel.TabIndex = 10;
            // 
            // CharacterGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Name = "CharacterGeneratorForm";
            this.Text = "Character Generator";
            this.Load += new System.EventHandler(this.CharacterGeneratorForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.IdentityPage.ResumeLayout(false);
            this.IdentityTablelLayoutPanel.ResumeLayout(false);
            this.IdentityTablelLayoutPanel.PerformLayout();
            this.AbilityPage.ResumeLayout(false);
            this.AbilityTableLayout.ResumeLayout(false);
            this.InventoryPage.ResumeLayout(false);
            this.CharacterSheetPage.ResumeLayout(false);
            this.CharacterSheetPage.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TabPage AbilityPage;
        private System.Windows.Forms.TabPage InventoryPage;
        private System.Windows.Forms.TabPage CharacterSheetPage;
        private System.Windows.Forms.TableLayoutPanel IdentityTablelLayoutPanel;
        private System.Windows.Forms.Button GenerateNameButton;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox CharacterNameTextBox;
        private System.Windows.Forms.Label CharaterNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.TableLayoutPanel AbilityTableLayout;
        private System.Windows.Forms.Label DexterityDataLabel;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Button GenerateAbilitiesButton;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.Label ConstitutionLabel;
        private System.Windows.Forms.Label IntelligenceLabel;
        private System.Windows.Forms.Label WisdomLabel;
        private System.Windows.Forms.Label CharismaLabel;
        private System.Windows.Forms.Label ConstitutionDataLabel;
        private System.Windows.Forms.Label IntelligenceDataLabel;
        private System.Windows.Forms.Label WisdomDataLabel;
        private System.Windows.Forms.Label CharismaDataLabel;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label InventoryItemsLabel;
        private System.Windows.Forms.Label Inventory1Label;
        private System.Windows.Forms.Label Inventory3Label;
        private System.Windows.Forms.Label Inventory4Label;
        private System.Windows.Forms.Label Inventory2Label;
        private System.Windows.Forms.Button GenerateInventoryButton;
        private System.Windows.Forms.Label Inventory1DataLabel;
        private System.Windows.Forms.Label Inventory2DataLabel;
        private System.Windows.Forms.Label Inventory3DataLabel;
        private System.Windows.Forms.Label Inventory4DataLabel;
    }
}
