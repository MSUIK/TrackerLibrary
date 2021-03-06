﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

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
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text, 
                    prizePercentageValue.Text);
                foreach(IDataConnection db in GlobleConfig.Connections)
                {
                    db.CreatePrize(model);
                }

            }
          else
            {
                MessageBox.Show("This form ha invslid information. Pleas Check it and try again");
            }

        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            decimal prizeAmount = 0;
            double prizePercentage = 0;
         bool prizeAmountValid = decimal.TryParse(
                prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(
                prizePercentageValue.Text, out prizePercentage);
            bool placeNumberValidNumber = int.TryParse(
                placeNumberValue.Text, out placeNumber);
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
            
            if(prizeAmountValid ==false || prizePercentageValid == false)
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

        private void placeNumberValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeNameValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
