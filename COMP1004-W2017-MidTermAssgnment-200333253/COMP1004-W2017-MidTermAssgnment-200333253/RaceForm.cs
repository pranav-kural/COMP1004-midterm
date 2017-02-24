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
    }
}
