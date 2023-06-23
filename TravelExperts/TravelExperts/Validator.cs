using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsGUI
{
    /// <summary>
    /// a repository of validation methods
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// checks if text box has text in it
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsPresent(TextBox textBox)
        {
            bool isValid = true;
            if(textBox.Text == "") // bad
            {
                MessageBox.Show(textBox.Tag + " is required");
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if combo box has value selected
        /// </summary>
        /// <param name="comboBox">combo box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsSelected(ComboBox comboBox)
        {
            bool isValid = true;
            if (comboBox.SelectedIndex == -1) // bad
            {
                MessageBox.Show(comboBox.Tag + " must be selected");
                comboBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains a non-negative int value
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeInt(TextBox textBox)
        {
            bool isValid = true;
            int result;
            if(!Int32.TryParse(textBox.Text, out result)) // not an int
            {
                MessageBox.Show(textBox.Tag + " has to be a whole number");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if(result < 0) // it is an int but negative
            {
                MessageBox.Show(textBox.Tag + " has to be positive or zero");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// checks if text box contains a non-negative decimal value
        /// </summary>
        /// <param name="textBox">text box to check (Tag property is set)</param>
        /// <returns>true if valid and false if not</returns>
        public static bool IsNonNegativeDecimal(TextBox textBox)
        {
            bool isValid = true;
            decimal result;
            if (!Decimal.TryParse(textBox.Text, out result)) // not a decimal
            {
                MessageBox.Show(textBox.Tag + " has to be a number");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            else if (result < 0) // it is a decimal but negative
            {
                MessageBox.Show(textBox.Tag + " has to be positive or zero");
                textBox.SelectAll(); // select all text in the box for replacement
                textBox.Focus();
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// Check if an input is greater than the second input
        /// </summary>
        /// <param name="value1">first value from textbox</param>
        /// <param name="value2">second value from textbox</param>
        /// <returns>true if valid</returns>
        public static bool IsGreaterThan(TextBox value1, TextBox value2)
        {
            bool isValid = true;
            if (Convert.ToDecimal(value2.Text) >= Convert.ToDecimal(value1.Text))
            {
                MessageBox.Show(value2.Tag + " must be less than " + value1.Tag);
                value2.SelectAll();
                value2.Focus();
                isValid = false;
            }
            return isValid;
        }


        /// <summary>
        /// Check if end date is later than start date
        /// </summary>
        /// <param name="start">start date from DTP</param>
        /// <param name="end">end date from second DTP</param>
        /// <returns>true if valid</returns>
        public static bool IsLaterThan(DateTimePicker start, DateTimePicker end)
        {
            bool isValid = true;
            if (start.Value >= end.Value)
            {
                MessageBox.Show(end.Tag + " must be later than " + start.Tag);
                end.Select();
                end.Focus();
                isValid = false;
            }

            return isValid;
        }
    }
}
