using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200333253
{
    public partial class RaceForm : Form
    {
        // store the player information
        private Dictionary<string, string> _playerInfo = new Dictionary<string, string>();

        // RaceForm constructor
        public RaceForm()
        {
            InitializeComponent();
        }

        // set the player info (receive it from the AbilitiesForm)
        public void SetPlayerInfo(Dictionary<string, string> info)
        {
            // get the values and set to the _playerInfo of RaceForm
            foreach (KeyValuePair<string, string> pair in info)
            {
                this._playerInfo.Add(pair.Key, pair.Value);
            }

            // add the property of race to the _playerInfo
            this._playerInfo.Add("race", "");
        }

        // check changed event handler for the radio buttons
        private void _RaceRadioButtonEventHandler(object sender, EventArgs args)
        {
            // casting the sender object to RadioButton
            RadioButton radioButton = sender as RadioButton;
            
                // select the case to run depending on Text value of RadioButton
                switch (radioButton.Text.ToString())
                {
                    case "Human":
                        // set the human image to the picture box
                        this.CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnment_200333253.Properties.Resources.M_Human1;

                        // all the abilities
                        string[] abilities = { "STR", "DEX", "END", "INT", "PER", "CHA" };

                        // Iterate through the _playerInfo to update the new abilities
                        foreach (string ability in abilities)
                        {
                            this._playerInfo[ability] = (radioButton.Checked) ? (Int16.Parse(this._playerInfo[ability]) + 5).ToString() : (Int16.Parse(this._playerInfo[ability]) + 5).ToString(); //increase all the abilities by 5 points
                        }

                        // if human button checked == true
                        if (radioButton.Checked)
                        {
                            // update the race in _playerInfo
                            this._playerInfo["race"] = "Human";
                            // update the message in the RacialBonusTextBox
                            this.RacialBonusTextBox.Text = "Added 5 points to all the abilities";
                        }
                        break;

                    case "Dwarf":
                        // set the dwarf image to the picture box
                        this.CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnment_200333253.Properties.Resources.M_Dwarf1;

                        // Update the abilities of players

                        // if dwarf radio button is selected
                        if (radioButton.Checked)
                        {
                            this._playerInfo["STR"] = (Int16.Parse(this._playerInfo["STR"]) + 20).ToString(); //increase STR ability by 20 points
                            this._playerInfo["PER"] = (Int16.Parse(this._playerInfo["PER"]) + 20).ToString(); //increase PER ability by 20 points
                            this._playerInfo["CHA"] = ((Int16.Parse(this._playerInfo["CHA"]) - 10) < 3) ? "0" : ((Int16.Parse(this._playerInfo["CHA"]) - 10).ToString()); //decrease CHA ability by 10 points

                            // update the message in the RacialBonusTextBox
                            this.RacialBonusTextBox.Text = "+10 STR, +20 PER, -10 CHA";

                            // update the race in _playerInfo
                            this._playerInfo["race"] = "Dwarf";
                        }
                        else
                        {
                            // if dwarf radio button is unselected
                            this._playerInfo["STR"] = (Int16.Parse(this._playerInfo["STR"]) - 20).ToString(); //decrease STR ability by 20 points
                            this._playerInfo["PER"] = (Int16.Parse(this._playerInfo["PER"]) - 20).ToString(); //decrease PER ability by 20 points
                            this._playerInfo["CHA"] = (Int16.Parse(this._playerInfo["CHA"]) + 10).ToString(); // increase CHA ability by 10 points
                        }

                        break;

                    case "Elf":
                        // set the elf image to the picture box
                        this.CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnment_200333253.Properties.Resources.M_Elf1;

                        // Update the abilities of players
                        this._playerInfo["DEX"] = ((radioButton.Checked) ? Int16.Parse(this._playerInfo["DEX"]) + 15 : Int16.Parse(this._playerInfo["DEX"]) - 15).ToString(); //update DEX ability points
                        this._playerInfo["CHA"] = ((radioButton.Checked) ? Int16.Parse(this._playerInfo["CHA"]) + 15 : Int16.Parse(this._playerInfo["CHA"]) - 15).ToString(); // update CHA ability points

                        // update the message in the RacialBonusTextBox if points increased
                        if (radioButton.Checked)
                        {
                            this.RacialBonusTextBox.Text = "+15 DEX and +15 CHA";

                            // update the race in _playerInfo
                            this._playerInfo["race"] = "Elf";
                        }
                        break;

                    case "Halfling":
                        // set the halfling image to the picture box
                        this.CharacterPictureBox.Image = COMP1004_W2017_MidTermAssgnment_200333253.Properties.Resources.M_Halfling2;

                        // Update the abilities of players


                        // if dwarf radio button is selected
                        if (radioButton.Checked)
                        {
                            this._playerInfo["DEX"] = (Int16.Parse(this._playerInfo["DEX"]) + 20).ToString(); //increase DEX ability by 20 points
                            this._playerInfo["INT"] = (Int16.Parse(this._playerInfo["INT"]) + 20).ToString(); //increase INT ability by 20 points
                            this._playerInfo["STR"] = ((Int16.Parse(this._playerInfo["STR"]) - 10) < 3) ? "0" : ((Int16.Parse(this._playerInfo["STR"]) - 10).ToString()); //decrease STR ability by 10 points

                            // update the message in the RacialBonusTextBox
                            this.RacialBonusTextBox.Text = "+20 DEX, +20 INT, -10 STR";

                            // update the race in _playerInfo
                            this._playerInfo["race"] = "Halfling";
                        }
                        else
                        {
                            this._playerInfo["DEX"] = (Int16.Parse(this._playerInfo["DEX"]) - 20).ToString(); //decrease DEX ability by 20 points
                            this._playerInfo["INT"] = (Int16.Parse(this._playerInfo["INT"]) - 20).ToString(); //decrease INT ability by 20 points
                            this._playerInfo["STR"] = (Int16.Parse(this._playerInfo["STR"]) + 10).ToString(); //increase STR ability by 10 points
                        }
                        break;
                }
        }

        // Next button click event handler
        private void _NextButtonClickEventHandler(object sender, EventArgs args)
        {
            // create an instance of the JobForm
            JobForm jobForm = new JobForm();

            // pass the abilities value (current player info)
            jobForm.SetPlayerInfo(this._playerInfo);

            // show the RaceForm
            jobForm.Show();

            // hide the AbilityForm
            this.Hide();
        }
        
    }
}
