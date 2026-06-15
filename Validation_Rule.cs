using System;
using System.Globalization;
using System.Windows.Controls;

namespace Budget_Planner_Alnur_Madiyev_w68646.Validation_Rules
{
    public class Validation_Rule : ValidationRule 
    {
        public int validation_Rule { get; set; } //get and set value that determins which rule to use
        /// <summary>
        /// ValidationRule method that test user inputs 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double test;
            if (double.TryParse(value.ToString(), out test)) //if object value can be converted to a double then
            {
                test = Convert.ToDouble(value);
            }
            else //value can not be converted therefore return error 
            {
                return new ValidationResult(false, "Please enter a valid integer value.");
            }
            #region Validation Rules
            if (validation_Rule == 1) // validation for can not be negative
            {
                if (test < 0)
                {
                    return new ValidationResult(false, "Amount can not be negative.");
                }
            }
            else if (validation_Rule == 2)  // validation for can not be negative or 0
            {
                if (test <= 0)
                {
                    return new ValidationResult(false, "Amount can not be negative or equal to 0.");
                }
            }
            else if (validation_Rule == 3) // validation for repay months
            {

                if (test > 360)
                {
                    return new ValidationResult(false, "Please enter an amount between 240 and 360.");
                }
                if (test < 240)
                {
                    return new ValidationResult(false, "Please enter an amount between 240 and 360.");
                }
            }
            else if (validation_Rule == 4) // validation for percentages
            {
                if (test <= 0)
                {
                    return new ValidationResult(false, "Please enter an value greater than 0 and less than 100.");
                }
                if (test > 100)
                {
                    return new ValidationResult(false, "Please enter an value between 0 and 100.");
                }
            }
            #endregion

            return new ValidationResult(true, null); //if pass Validation Rules return true
        }
    }
}
