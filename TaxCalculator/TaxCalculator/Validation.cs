using System;
using System.Text.RegularExpressions;

namespace TaxCalculator
{
    /// <summary>
    /// Validation class for all input validate.
    /// </summary>
    internal class Validation
    {
        #region PublicMethod

        /// <summary>
        /// Validate Method Used for Name validation.
        /// </summary>
        /// <param name="name"> Name variable pass for check name format valid or not.</param>
        /// <returns> Bool value true/false.</returns>
        public static bool ValidateName(string name)
        {
            string trim = name.Trim();
            Regex regex = new Regex(@"^[A-Za-z\s]*$");

            if (regex.IsMatch(trim))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Method used for input validation.
        /// </summary>
        /// <param name="IsSucess"> IsSucess is used for reference.</param>
        /// <param name="income"> Income is used for pass userincome.</param>
        /// <param name="count"> Count is used for repeat input.</param>
        public static void InputValidation(ref bool IsSucess, double income, ref int count,ref bool IsNegative)
        {
            // If block is used for check input format.
            if (IsSucess!= true && IsNegative!=true)
            {
                Console.WriteLine(Constant.ERR_InvalidFormat);
                InputRepeatValidation(ref count, ref IsSucess);
            }

            // If block is used for check value is negavtive.
            if (income < 0)
            {
                Console.WriteLine(Constant.ERR_NegativeOrZeroValue);
                InputRepeatValidation(ref count, ref IsSucess);
            }
        }

        /// <summary>
        /// Method for string input reenter.
        /// </summary>
        /// <param name="count">count variable use for count the number of time user reenter input.</param>
        /// <param name="IsSucess">IsSucess varaible use for take ref of input.</param>
        public static void InputRepeatValidation(ref int count, ref bool IsSucess)
        {
            string exitInput = null;
            Console.WriteLine(Environment.NewLine + Constant.MSG_ReEnterInput);
            //char input for contiue or exist the program
            exitInput = Console.ReadLine();
            exitInput = exitInput.ToUpper();

            if (exitInput != Constant.DEF_Capital_Y)
            {
                IsSucess = true;
            }

            if (exitInput == Constant.DEF_Capital_Y)
            {
                count++;
            }
        }

        #endregion
    }
}
