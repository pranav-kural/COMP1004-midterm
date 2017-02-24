using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200333253
{
    public partial class AbilityForm : Form
    {
        // Random Number object
        private Random _random = new Random();

        // store the reference to the abilities text boxes
        private List<TextBox> _abilities;

        // ability form constructor
        public AbilityForm()
        {
            InitializeComponent();
            _InitializeAbilities(); // initializing the _abilities list
        }

        // add the abilities text boxes to the _abilities List
        private void _InitializeAbilities()
        {
            // instantiate the _abilities list
            this._abilities = new List<TextBox>();

            // add the TextBox object to the List
            this._abilities.Add(STRTextBox);
            this._abilities.Add(DEXTextBox);
            this._abilities.Add(ENDTextBox);
            this._abilities.Add(INTTextBox);
            this._abilities.Add(PERTextBox);
            this._abilities.Add(CHATextBox);
        }

        /// <summary>
        /// This method simulates the rolling of three 10-sided dice
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int _Roll3D10()
        {
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += _random.Next(1, 11);
            }
            return result;
        }

        // Roll button click handler
        private void _RollButton_Click(object sender, EventArgs e)
        {
            // Iterates through each TextBox inside the _abilities list and set it's value
            foreach (TextBox textBox in this._abilities)
            {
                // get a random number and set it to the current abilitiy text box
                textBox.Text = this._Roll3D10().ToString();
            }
        }

        // returns back the current playerInfo (basically current abilities values)
        public Dictionary<String, String> getPlayerInfo()
        {
            // store the character info
            Dictionary<string, string> playerInfo = new Dictionary<string, string>();
            // iterate through all the abilities text boxes and add the value to the playerInfo
            foreach (TextBox textBox in this._abilities)
            {
                // Key represents the ability name, ex. STR
                playerInfo.Add(textBox.Name.Substring(0, 3), textBox.Text);
            }
            // return the info
            return playerInfo;
        }

        private void _NextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
