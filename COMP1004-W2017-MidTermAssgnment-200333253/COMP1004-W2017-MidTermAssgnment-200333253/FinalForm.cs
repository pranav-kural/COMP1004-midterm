using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// COMP 1004 Midterm Assignment
/// February 24th, 2017
/// Author: Pranav Kural
/// StudentId: 200333253
/// </summary>

namespace COMP1004_W2017_MidTermAssgnment_200333253
{
    public partial class FinalForm : Form
    {

        // store the player information
        private Dictionary<string, string> _playerInfo;

        // FinalForm constructor
        public FinalForm()
        {
            InitializeComponent();
            this._playerInfo = new Dictionary<string, string>(); // instantiate the _playerInfo
        }


        // set the player info (receive it from the AbilitiesForm)
        public void SetPlayerInfo(Dictionary<string, string> playerInfo)
        {
            // Display the player information
            this.JobTextBox.Text = playerInfo["job"];
            this.RaceTextBox.Text = playerInfo["race"];
            this.HealthPointTextBox.Text = playerInfo["health"];
            this.STRTextBox.Text = playerInfo["STR"];
            this.DEXTextBox.Text = playerInfo["DEX"];
            this.ENDTextBox.Text = playerInfo["END"];
            this.INTTextBox.Text = playerInfo["INT"];
            this.PERTextBox.Text = playerInfo["PER"];
            this.CHATextBox.Text = playerInfo["CHA"];

            switch (playerInfo["race"])
            {
                case "Human":
                    // set the human image to the picture box
                    this.CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnment_200333253.Properties.Resources.M_Human1;
                    break;
                case "Dwarf":
                    // set the dwarf image to the picture box
                    this.CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnment_200333253.Properties.Resources.M_Dwarf1;
                    break;
                case "Elf":
                    // set the elf image to the picture box
                    this.CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnment_200333253.Properties.Resources.M_Elf1;
                    break;
                case "Halfling":
                    // set the halfling image to the picture box
                    this.CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnment_200333253.Properties.Resources.M_Halfling2;
                    break;
            }
        }


        /// <summary>
        /// Event handler for menu items
        /// </summary>
        /// <param name="sender">Menu item associated with the event</param>
        /// <param name="e">Event arguments</param>
        private void _menuStripEventHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            // select the menu item selected
            switch (menuItem.Tag.ToString())
            {
                case "exit":
                    // close the form (calls the form closing)
                    this.Close();
                    break;

                case "print":
                    // print a mock print preview message
                    MessageBox.Show("Sending the final form data to be printed.", "Printing Final Form");
                    break;
                    
                case "font":
                    // show font dialog
                    FinalFormFontDialog.ShowDialog();
                    // applying the changes
                    this.CharacterInformationGroupBox.Font = FinalFormFontDialog.Font;
                    this.CharacterProfileGroupBox.Font = FinalFormFontDialog.Font;
                    this.AbilitiesGroupBox.Font = FinalFormFontDialog.Font;
                    break;

                case "about":
                    // show a model about form
                    (new CharacterAboutBox()).ShowDialog(); 
                    break;

            }
        }




    }
}
