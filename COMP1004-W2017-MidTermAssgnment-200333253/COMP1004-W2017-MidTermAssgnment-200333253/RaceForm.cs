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

        // set the player info (receive it from the AbilitiesForm
        public void SetPlayerInfo(Dictionary<string, string> info)
        {
            foreach (KeyValuePair<string, string> pair in info)
            {
                this._playerInfo.Add(pair.Key, pair.Value);
            }
        }

        // check changed event handler for the radio buttons
        private void _RaceRadioButtonEventHandler(object sender, EventArgs args)
        {
            // casting the sender object to RadioButton
            RadioButton radioButton = sender as RadioButton;

            // if radio button checked is true
            if (radioButton.Checked)
            {
                // select the case to run depending on Text value of RadioButton
                switch (radioButton.Text.ToString())
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
        }
    }
}
