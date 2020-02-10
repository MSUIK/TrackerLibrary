using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        ///To Create A Prizewe will Click This Button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {

            }

        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            decimal prizeAmount = 0;
            int prizePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(prizeAmountLabel.Text, out prizeAmount);
            bool prizePercentageValid = int.TryParse(prizePercentageValue.Text, out prizePercentage);
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);
            if (!placeNumberValidNumber)
            {
                output = false;
            }
            if(placeNumber <1)
            {
                output = false;
            }
            if(placeNameValue.Text.Length==0)
            {
                output = false;
            }
            
            if(!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }
            if(prizeAmount<0 && prizePercentage<0)
            {
                output = false;
            }
            if(prizeAmount<0 || prizePercentage>100)
            {
                output = false;
            }
           

            return output;
        }
    }
}
