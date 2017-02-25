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
    public partial class JobForm : Form
    {

        // store the player information
        private Dictionary<string, string> _playerInfo;

        public JobForm()
        {
            InitializeComponent();
            _playerInfo = new Dictionary<string, string>();
        }

        // set the player info (receive it from the AbilitiesForm)
        public void SetPlayerInfo(Dictionary<string, string> info)
        {
            // get the values and set to the _playerInfo of RaceForm
            foreach (KeyValuePair<string, string> pair in info)
            {
                this._playerInfo.Add(pair.Key, pair.Value);
            }

            // add the property of job to the _playerInfo
            this._playerInfo.Add("job", "");
            this._playerInfo.Add("health", "");
        }

        // Checked change event handler for the Radio Buttons
        private void _JobRadioButtonEventHandler(object sender, EventArgs args)
        {
            RadioButton radioButton = sender as RadioButton;

            switch (radioButton.Text)
            {
                case "Soldier":
                    // update the health text box value
                    this.HealthTextBox.Text = (30 + Int16.Parse(this._playerInfo["END"])).ToString();

                    // update the values to the _playerInfo
                    this._playerInfo["job"] = "Soldier";
                    
                    break;
                case "Rogue":
                    // update the health text box value
                    this.HealthTextBox.Text = (28 + Int16.Parse(this._playerInfo["DEX"])).ToString();

                    // update the values to the _playerInfo
                    this._playerInfo["job"] = "Rogue";
                    this._playerInfo["health"] = this.HealthTextBox.Text;

                    break;
                case "Magicker":
                    // update the health text box value
                    this.HealthTextBox.Text = (15 + Int16.Parse(this._playerInfo["INT"])).ToString();

                    // update the values to the _playerInfo
                    this._playerInfo["job"] = "Magicker";
                    break;
                case "Cultist":
                    // update the health text box value
                    this.HealthTextBox.Text = (24 + Int16.Parse(this._playerInfo["CHA"])).ToString();

                    // update the values to the _playerInfo
                    this._playerInfo["job"] = "Cultist";
                    break;
            }
            // update the value of health to the _playerInfo
            this._playerInfo["health"] = this.HealthTextBox.Text;
        }


        // Next button click event handler
        private void _NextButtonClickEventHandler(object sender, EventArgs args)
        {
            // create an instance of the JobForm
            FinalForm finalForm = new FinalForm();

            // pass the abilities value (current player info)
            finalForm.SetPlayerInfo(this._playerInfo);

            // show the RaceForm
            finalForm.Show();

            // hide the AbilityForm
            this.Hide();
        }


    }
}
