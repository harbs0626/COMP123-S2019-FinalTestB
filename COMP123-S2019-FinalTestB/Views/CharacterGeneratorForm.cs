using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using COMP123_S2019_FinalTestB.Objects;

/*
 * Student Name: Harbin Ramo
 * Student ID  : 301046044
 * Description : This is the Character Generator Form - the main form of the application
 */

namespace COMP123_S2019_FinalTestB.Views
{
    public partial class CharacterGeneratorForm : MasterForm
    {
        public CharacterGeneratorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the BackButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (this.MainTabControl.SelectedIndex != 0)
            {
                this.MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the NextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (this.MainTabControl.SelectedIndex < this.MainTabControl.TabPages.Count - 1)
            {
                this.MainTabControl.SelectedIndex++;
            }
        }

        private void CharacterGeneratorForm_Load(object sender, EventArgs e)
        {
            this.LoadNames();
            this.GenerateNames();
            this.LoadInventory();
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            this.GenerateNames();
            this.FirstNameDataLabel.Text = Program.character.FirstName;
            this.LastNameDataLabel.Text = Program.character.LastName;
        }

        /// <summary>
        /// This method randomly gets the first and last names from each list
        /// </summary>
        private void GenerateNames()
        {
            Random randFirstName = new Random();
            Random randLastName = new Random();

            Program.character.FirstName = Program.character.FirstNameList[randFirstName.Next(Program.character.FirstNameList.Count)];
            Program.character.LastName = Program.character.LastNameList[randFirstName.Next(Program.character.LastNameList.Count)];
        }

        /// <summary>
        /// This method loads the name from first and last names list
        /// </summary>
        private void LoadNames()
        {
            try
            {
                using (StreamReader strFirstName = new StreamReader("..\\..\\Data\\firstNames.txt"))
                {
                    Program.character.FirstNameList = new List<string>();
                    string myLine;
                    while ((myLine = strFirstName.ReadLine()) != null)
                    {
                        Program.character.FirstNameList.Add(myLine);
                    }
                    strFirstName.Close();
                    strFirstName.Dispose();
                }
                using (StreamReader strLastName = new StreamReader("..\\..\\Data\\lastNames.txt"))
                {
                    Program.character.LastNameList = new List<string>();
                    string myLine;
                    while ((myLine = strLastName.ReadLine()) != null)
                    {
                        Program.character.LastNameList.Add(myLine);
                    }
                    strLastName.Close();
                    strLastName.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Unable to load file(s) due to error {ex.Message}");
                return;
            }
        }

        /// <summary>
        /// This method for Generate Abilities
        /// </summary>
        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            Random valStrength = new Random();
            Random valDexterity = new Random();
            Random valConstitution = new Random();
            Random valIntelligence = new Random();
            Random valWisdom = new Random();
            Random valCharisma = new Random();

            Program.character.Strength = valStrength.Next(3,18).ToString();
            Program.character.Dexterity = valDexterity.Next(3, 18).ToString();
            Program.character.Constitution = valConstitution.Next(3, 18).ToString();
            Program.character.Intelligence = valIntelligence.Next(3, 18).ToString();
            Program.character.Wisdom = valWisdom.Next(3, 18).ToString();
            Program.character.Charisma = valCharisma.Next(3, 18).ToString();

            this.StrengthDataLabel.Text = Program.character.Strength;
            this.DexterityDataLabel.Text = Program.character.Dexterity;
            this.ConstitutionDataLabel.Text = Program.character.Constitution;
            this.IntelligenceDataLabel.Text = Program.character.Intelligence;
            this.WisdomDataLabel.Text = Program.character.Wisdom;
            this.CharismaDataLabel.Text = Program.character.Charisma;
        }

        /// <summary>
        /// This method for Generate Inventory
        /// </summary>
        private void GenerateInventoryButton_Click(object sender, EventArgs e)
        {
            this.GenerateRandomInventory();
            this.Inventory1DataLabel.Text = Program.inventory[0];
            this.Inventory2DataLabel.Text = Program.inventory[1];
            this.Inventory3DataLabel.Text = Program.inventory[2];
            this.Inventory4DataLabel.Text = Program.inventory[3];
        }

        private void GenerateRandomInventory()
        {
            Random randInventory = new Random();

            Program.inventory = new List<string>{
                Program.character.InventoryList[randInventory.Next(Program.character.InventoryList.Count)],
                Program.character.InventoryList[randInventory.Next(Program.character.InventoryList.Count)],
                Program.character.InventoryList[randInventory.Next(Program.character.InventoryList.Count)],
                Program.character.InventoryList[randInventory.Next(Program.character.InventoryList.Count)]
            };
        }

        private void LoadInventory()
        {
            using (StreamReader strInventory = new StreamReader("..\\..\\Data\\inventory.txt"))
            {
                Program.character.InventoryList = new List<string>();
                string myLine;
                while ((myLine = strInventory.ReadLine()) != null)
                {
                    Program.character.InventoryList.Add(myLine);
                }
                strInventory.Close();
                strInventory.Dispose();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveDialog.FileName = "CharacterCreation.txt";

            using (StreamWriter wrData = new StreamWriter(saveDialog.FileName))
            {
                wrData.WriteLine(Program.character.FirstName);
                wrData.WriteLine(Program.character.LastName);
                wrData.WriteLine(Program.character.Strength);
                wrData.WriteLine(Program.character.Dexterity);
                wrData.WriteLine(Program.character.Constitution);
                wrData.WriteLine(Program.character.Intelligence);
                wrData.WriteLine(Program.character.Wisdom);
                wrData.WriteLine(Program.character.Charisma);
                wrData.WriteLine(Program.character.InventoryList[0]);
                wrData.WriteLine(Program.character.InventoryList[1]);
                wrData.WriteLine(Program.character.InventoryList[2]);
                wrData.WriteLine(Program.character.InventoryList[3]);
                wrData.Close();
                wrData.Dispose();
            }
            MessageBox.Show("Character Recorded!");
            return;
        }
    }
}
