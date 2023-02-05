using System;
using System.Globalization;

namespace TaxCalculator
{
    /// <summary>f
    /// Class for calculate and show taxableamount and taxon income.
    /// </summary>
    internal class TestClass
    {
        #region PublicMethod
      
        /// <summary>
        /// Display Taxble Amount And Tax on TaxbleAmount.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            DateTime birthDate = new DateTime();
            string userGender = null;
           
           
            while (true)
            {
                Console.WriteLine(Constant.MSG_StartLine);
                Console.WriteLine("{0,60}", Constant.MSG_ProgramName);
                Console.WriteLine(Constant.MSG_StartLine);
                double home = 0;
                double income = 0;
                double invest = 0;
                while (true)
                {
                    bool IsSucess = false;
                    bool IsExit = false;
                    // Method for input user name and  check.
                    UserName(ref IsSucess,ref IsExit);
                    // Method is used for check program continue common code.
                    CommonCodeForProgramExitCheck(ref IsSucess, ref IsExit);

                    if(IsSucess==true)
                    {
                        return;
                    }

                    // Method for input user birthdate and check.
                    UserBirthdate(ref IsSucess,ref birthDate,ref IsExit);
                    // Method is used for check program continue or not.
                    CommonCodeForProgramExitCheck(ref IsSucess, ref IsExit);

                    if (IsSucess == true)
                    {
                        return;
                    }

                    // Method for input user birthdate and check.
                    UserGender(ref IsSucess, ref userGender,ref IsExit);
                    // Method is used for check program continue or not.
                    CommonCodeForProgramExitCheck(ref IsSucess, ref IsExit);

                    if (IsSucess == true)
                    {
                        return;
                    }

                    int age = CalculateAge(birthDate);
                    Console.WriteLine(Environment.NewLine + Constant.MSG_Age + age);
                  
                    // Age Limit 
                    if (age > Constant.DEF_MaxAgeLimit)
                    {
                        Console.WriteLine(Constant.ERR_AgeValid);
                        Console.ReadLine();
                        break;
                    }

                    Console.WriteLine(Environment.NewLine + Constant.MSG_FirstTitleLine);
                    Console.WriteLine(Environment.NewLine + "{0,60}", Constant.MSG_AccountDetails);
                    Console.WriteLine(Constant.MSG_FirstTitleLine);
                    string IncomeMessage = Constant.MSG_Income;
                    // Input method for user input.
                    Input(ref income,ref IsSucess,IncomeMessage,ref IsExit);
                    // Method is used for check program continue or not.
                    CommonCodeForProgramExitCheck(ref IsSucess,ref IsExit);

                    if (IsSucess == true)
                    {
                        return;
                    }

                    string InvestMessage = Constant.MSG_InvestMent;
                    Input(ref invest, ref IsSucess, InvestMessage,ref IsExit);
                    CommonCodeForProgramExitCheck(ref IsSucess,ref IsExit);

                    if (IsSucess == true)
                    {
                        return;
                    }

                    // Check invest amount is less than income.
                    if (invest > income)
                    {
                        Console.WriteLine(Constant.ERR_GreaterInvestment);
                        Console.WriteLine(Constant.MSG_ProgramContinue);
                        string inputExit = Console.ReadLine();
                        inputExit = inputExit.ToUpper();

                        if (inputExit == Constant.DEF_Capital_Y)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(Constant.MSG_EndLine);
                            Console.WriteLine(Environment.NewLine + "{0,60}", Constant.MSG_ThankYou);
                            Console.WriteLine(Constant.MSG_EndLine);
                            return;
                        }
                    }

                    string homeMessage = Constant.MSG_HomeLoan;
                    Input(ref home, ref IsSucess, homeMessage, ref IsExit);
                    CommonCodeForProgramExitCheck(ref IsSucess, ref IsExit);

                    if (IsSucess == true)
                    {
                        return;
                    }

                    // If block excute when user enter homeloanamount is more than income.
                    if (home >= income)
                    {
                        Console.WriteLine(Constant.ERR_MoreHomeLoan);
                        Console.WriteLine(Constant.MSG_ProgramContinue);
                        string inputExit = Console.ReadLine();
                        inputExit = inputExit.ToUpper();

                        if (inputExit == Constant.DEF_Capital_Y)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(Constant.MSG_EndLine);
                            Console.WriteLine(Environment.NewLine + "{0,60}", Constant.MSG_ThankYou);
                            Console.WriteLine(Constant.MSG_EndLine);
                            return;
                        }
                    }

                    // Method for age wise tax calculate.
                    TakeUserDetalisAndcalculateTax(userGender, age, income, invest, home, ref IsSucess);

                    // If block used for check user input and program continue or not.
                    if (IsSucess == true)
                    {
                        Console.WriteLine(Constant.MSG_EndLine);
                        Console.WriteLine(Environment.NewLine + "{0,60}", Constant.MSG_ThankYou);
                        Console.WriteLine(Constant.MSG_EndLine);
                        Console.ReadLine();
                        return;
                    }

                    if (IsSucess != true)
                    {
                        break;
                    }
                }
            }
        }
        #endregion

        #region PrivateMethods

        /// <summary>
        /// Method for take user input and check.
        /// </summary>
        /// <param name="Issucess"> IsSucess variable use for take ref of input.</param>
        /// <returns> Ref sucess and double value.</returns>
        private static double TakeUserInput(ref bool IsSucess,ref bool IsNegative)
        {
            double parameter = 0;

            try
            {
                string inputOption = Console.ReadLine();
                IsSucess = double.TryParse(inputOption, out parameter);
            }
            catch (Exception ex) when (ex is FormatException || ex is OverflowException)
            {
                Console.WriteLine(Constant.ERR_InvalidFormat);
            }

            if(parameter < 0)
            {
                IsNegative = true;
            }

            return parameter;
        }

        /// <summary>
        /// Method for show output.
        /// </summary>
        /// <param name="taxableIncome"> TaxableIncome used for show user taxableincome.</param>
        /// <param name="paybleTax"> Used for show user paybletax.</param>
        private static void DisplayTax(double taxableIncome, double paybleTax)
        {
            Console.WriteLine(Environment.NewLine + Constant.MSG_FirstTitleLine);
            Console.WriteLine(Environment.NewLine + "{0,60}", Constant.MSG_Result);
            Console.WriteLine(Constant.MSG_FirstTitleLine);
            Console.WriteLine(Environment.NewLine + Constant.MSG_TaxableIncome + taxableIncome.ToString("N", new CultureInfo("hi-IN")));
            Console.WriteLine(Environment.NewLine + Constant.MSG_PayableAmount + paybleTax.ToString("N", new CultureInfo("hi-IN")));
        }

        /// <summary>
        /// Take user birthdate.
        /// </summary>
        /// <returns> Method return valid Date.</returns>
        private static DateTime TakeBirthDate(out bool IsStatus)
        {
            IsStatus = true;
            DateTime result = DateTime.Now;
            string dateString = Console.ReadLine();
            string format = Constant.MSG_DateFormat;

            try
            {
                result = DateTime.ParseExact(dateString, format, new CultureInfo("en-GB"));
            }
            catch (Exception ex) when (ex is FormatException)
            {
                IsStatus = false;
            }

            return result;
        }

        /// <summary>  
        /// For calculating only age.
        /// </summary>  
        /// <param name="dateOfBirth">Date of birth use for calculate age.</param>  
        /// <returns> age e.g. 26</returns>  
        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;

            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            {
                age = age - 1;
            }

            return age;
        }

        /// <summary>
        /// Input Method for used to perform input operation.
        /// </summary>
        /// <param name="income"></param>
        /// <param name="IsSucess"></param>
        /// <param name="inputMessage"></param>
        private static void Input(ref double income,ref bool IsSucess,string inputMessage,ref bool IsExit)
        {
            for (int i = 0; i < Constant.DEF_MaxLoopRange;)
            {
                bool IsValid = false;
                bool IsNegative = false;
                Console.Write(Environment.NewLine + inputMessage);
                income = TakeUserInput(ref IsValid,ref IsNegative);

                if(IsValid==true && IsNegative==false)
                {
                     return;
                }

                Validation.InputValidation(ref IsExit, income, ref i,ref IsNegative);

                if(IsExit==true)
                {
                    break;
                }

                if (i == Constant.DEF_MaxLoopRange)
                {
                    IsSucess = true;
                }
            }
        }

        /// <summary>
        /// UserName method is used for input user name and check.
        /// </summary>
        /// <param name="IsSucess"> IsSucess is pass for ref.</param>
        /// <param name="IsName"> IsName is pass for name ref.</param>
        private static void UserName(ref bool IsSucess,ref bool IsName)
        {
            // For loop used for user name.
            for (int i = 0; i < Constant.DEF_MaxLoopRange;)
            {
                Console.WriteLine(Environment.NewLine + Constant.MSG_FirstTitleLine);
                Console.WriteLine("{0,60}", Constant.MSG_UserDetalis);
                Console.WriteLine(Constant.MSG_FirstTitleLine);
                Console.Write(Environment.NewLine + Constant.MSG_UserName);
                string name = Console.ReadLine();
                bool IsValid = Validation.ValidateName(name);

                if (IsValid == true)
                {
                    return;
                }

                Console.WriteLine(Constant.ERR_InvalidName);
                Validation.InputRepeatValidation(ref i, ref IsName);

                // If block check for reenter user option.
                if (IsName == true)
                {
                    break;
                }

                // If user enter maximun three times input the program is exit.
                if (i == Constant.DEF_MaxLoopRange)
                {
                    IsSucess = true;
                }
            }
        }

       /// <summary>
       /// UserBirthdate method is used for input date and check.
       /// </summary>
       /// <param name="IsSucess"> IsSucess is used for ref.</param>
       /// <param name="birthDate"> birthdate is used for date ref.</param>
       /// <param name="IsBirthdate"> IsBirthdate is used for check birthdate.</param>
        private static void UserBirthdate(ref bool IsSucess,ref DateTime birthDate,ref bool IsBirthdate)
        {
            // For loop used for user birthdate.
            for (int i = 0; i < Constant.DEF_MaxLoopRange;)
            {
                Console.Write(Environment.NewLine + Constant.MSG_BirthDate);
                birthDate = TakeBirthDate(out bool IsValid);

                if (IsValid == true)
                {
                    break;
                }

                Console.WriteLine(Constant.ERR_InvalidBirthDate);
                Validation.InputRepeatValidation(ref i, ref IsBirthdate);

                // If block check for reenter user option.
                if (IsBirthdate == true)
                {
                    break;
                }

                // If user enter maximun three times input the program is exit.
                if (i == Constant.DEF_MaxLoopRange)
                {
                    IsSucess = true;
                }
            }
        }

        /// <summary>
        /// UserGender method is used for input gender and check.
        /// </summary>
        /// <param name="IsSucess"> IsSucess is used for ref.</param>
        /// <param name="userGender"> userGender is used for ref gender.</param>
        /// <param name="IsGender"> IsGender ref is used for check valid gender.</param>
        private static void UserGender(ref bool IsSucess,ref string userGender,ref bool IsGender)
        {
            // For loop used for user Gender.
            for (int i = 0; i < Constant.DEF_MaxLoopRange;)
            {
                Console.Write(Environment.NewLine + Constant.MSG_UserGender);
                userGender = Console.ReadLine();
                userGender = userGender.ToUpper();

                // If block for gender check.
                if (userGender == Constant.DEF_M || userGender == Constant.DEF_F || userGender == Constant.DEF_Female || userGender == Constant.DEF_Male)
                {
                    break;
                }

                Console.WriteLine(Constant.ERR_InvalidGender);
                Validation.InputRepeatValidation(ref i, ref IsGender);

                // If block check for reenter user option.
                if (IsGender == true)
                {
                    break;
                }

                // If user enter maximun three times input the program is exit.
                if (i == Constant.DEF_MaxLoopRange)
                {
                    IsSucess = true;
                }
            }
        }

        /// <summary>
        /// Method is used for check program is continue or not.
        /// </summary>
        /// <param name="IsSucess"> IsSucess is used for ref.</param>
        /// <param name="IsExit"> IsExit is used for exit ref.</param>
        private static void CommonCodeForProgramExitCheck( ref bool IsSucess,ref bool IsExit)
        {
            if (IsSucess == true)
            {
                Console.WriteLine(Constant.ERR_MaximumAttempt);
                Console.ReadLine();
                IsSucess=true;
            }

            if (IsExit == true)
            {
                Console.WriteLine(Constant.MSG_ThankYou);
                Console.ReadLine();
                IsSucess=true;
            }
        }

        /// <summary>
        /// Method for check age wise slab and call classes.
        /// </summary>
        /// <param name="gender">gender variable use for user gender.</param>
        /// <param name="age">age variable use for define age.</param>
        /// <param name="income">income variable use for define user income.</param>
        /// <param name="invest">invest variable use for define user investment.</param>
        /// <param name="home">home variable use for define user home loan.</param>
        /// <param name="IsSucess">IsSucess is used for refernce.</param>
        private static void TakeUserDetalisAndcalculateTax(string gender, int age, double income, double invest, double home, ref bool IsSucess)
        {
            //If else if Block for check gender and age of user
            if ((gender == Constant.DEF_M || gender == Constant.DEF_Male) && age < 60)
            {
                MenSlab Menslab = new MenSlab();
                double men_TaxableIncome = Menslab.CalculateTaxableIncome(income, invest, home);
                double men_taxOnIncome = Menslab.TaxOnIncome(men_TaxableIncome);
                DisplayTax(men_TaxableIncome, men_taxOnIncome);
            }
            else if ((gender == Constant.DEF_F || gender == Constant.DEF_Female) && age < 60)
            {
                WomenSlab womenslab = new WomenSlab();
                double women_TaxableIncome = womenslab.CalculateTaxableIncome(income, invest, home);
                double women_TaxOnIncome = womenslab.TaxOnIncome(women_TaxableIncome);
                DisplayTax(women_TaxableIncome, women_TaxOnIncome);
            }
            else if (age >= 60)
            {
                SeniorSlab seniorslab = new SeniorSlab();
                double senior_TaxableIncome = seniorslab.CalculateTaxableIncome(income, invest, home);
                double senior_TaxOnIncome = seniorslab.TaxOnIncome(senior_TaxableIncome);
                DisplayTax(senior_TaxableIncome, senior_TaxOnIncome);
            }
            else
            {
                Console.WriteLine(Environment.NewLine + Constant.ERR_InvalidDataError);
            }

            Console.WriteLine(Environment.NewLine + Constant.MSG_ProgramContinue);
            //char input for contiue or exist the program
            string charForExit = Console.ReadLine();
            charForExit = charForExit.ToUpper();

            // If block are used for Exit the program
            if (charForExit != Constant.DEF_Capital_Y)
            {
                IsSucess = true;
            }
        }

        #endregion
    }
}