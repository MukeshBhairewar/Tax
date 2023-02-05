namespace TaxCalculator
{
    /// <summary>
    /// Constant class for store constant variable.
    /// </summary>
    class Constant
    {
        #region MemberVariables
        /// <summary>
        /// Variable Show the non taxable Investment.
        /// </summary>
        public const double DEF_InvestMentRange = 100000;

        /// <summary>
        /// Home loan tax.
        /// </summary>
        public const double DEF_HomeLoanPercentage = 0.2;

        /// <summary>
        /// Variable show 10% Interset rate.
        /// </summary>
        public const double DEF_TenPercentageInterest = 0.10;

        /// <summary>
        /// Variable show 20% interset rate.
        /// </summary>
        public const double DEF_TwentyPercentageInterest = 0.20;

        /// <summary>
        /// Variable show 30% interset rate.
        /// </summary>
        public const double DEF_ThirtyPercentageInterest = 0.30;

        /// <summary>
        /// Range of second slab.
        /// </summary>
        public const double DEF_SlabMiddleRange = 300000;

        /// <summary>
        /// Highest Range of slab.
        /// </summary>
        public const double DEF_SlabHigherRange = 500000;

        // Men Class variables
        /// <summary>
        /// Menslab class lowestrange.
        /// </summary>
        public const double DEF_MenSlabLowerRange = 160000;

        /// <summary>
        /// Interset of second slab.
        /// </summary>
        public const double DEF_MenSlabFirstInterest = 14000;

        /// <summary>
        /// Interset of third slab.
        /// </summary>
        public const double DEF_MenSlabSecondInterset = 14000 + 40000;

        /// <summary>
        /// Womenslab class lowsetrange.
        /// </summary>
        public const double DEF_WomenSlabLowerRange = 190000;

        /// <summary>
        /// Interset of second slab.
        /// </summary>
        public const double DEF_WomenSlabFirstInterset = 11000;

        /// <summary>
        /// Interset of third slab.
        /// </summary>
        public const double DEF_WomenSlabSecondInterset = 11000 + 40000;

        /// <summary>
        /// Seniorslab class lowest range.
        /// </summary>
        public const double DEF_SeniorSlablowerRange = 240000;

        /// <summary>
        /// Interset of firstslab.
        /// </summary>
        public const double DEF_SeniorFirstInterset = 6000;

        /// <summary>
        /// Interset of secondslab.
        /// </summary>
        public const double DEF_SeniorSlabSecondInterset = 6000 + 40000;

        /// <summary>
        /// Message Show User enter string as input.
        /// </summary>
        public const string ERR_InvalidFormat = "String Format Is Invalid";

        /// <summary>
        /// Message show when user enter less than 0 value.
        /// </summary>
        public const string ERR_NegativeOrZeroValue = "Negative value or 0 are invalid inputs";

        /// <summary>
        /// Message show to choice of reenter the input.
        /// </summary>
        public const string MSG_ReEnterInput = "Would You Like To Continue you can reenter maximum three times[Y / N].";

        /// <summary>
        /// Message show when user enter three times wronf input.
        /// </summary>
        public const string ERR_MaximumAttempt = "You enter maximum attempt program is exit.";

        /// <summary>
        /// Message for enter name.
        /// </summary>
        public const string MSG_UserName = "Enter Name                  :";

        /// <summary>
        /// Message show when user enter invalid name format.
        /// </summary>
        public const string ERR_InvalidName = "Enter Name Format is Invalid.";

        /// <summary>
        /// Message show for user detalis.
        /// </summary>
        public const string MSG_UserDetalis = "Enter User Details";

        /// <summary>
        /// Message show for birthdate format.
        /// </summary>
        public const string MSG_BirthDate = "Birth Date [DD-MM-YYYY]     :";

        /// <summary>
        /// Message show when user enter invalid birthdate format.
        /// </summary>
        public const string ERR_InvalidBirthDate = "Enter Date Format is Invalid";

        /// <summary>
        /// Message show for gender choice.
        /// </summary>
        public const string MSG_UserGender = "Gender[M/F]                 :";

        /// <summary>
        /// Message show when user enter wrong gender.
        /// </summary>
        public const string ERR_InvalidGender = "Choose Correct Gender";

        /// <summary>
        /// Message for choice male.
        /// </summary>
        public const string DEF_M = "M";

        /// <summary>
        /// Message for choice female.
        /// </summary>
        public const string DEF_F = "F";

        /// <summary>
        /// Message for choice male.
        /// </summary>
        public const string DEF_Male = "MALE";

        /// <summary>
        /// Message for choice female.
        /// </summary>
        public const string DEF_Female = "FEMALE";

        /// <summary>
        /// Message show for income input.
        /// </summary>
        public const string MSG_Income = "Income                      :";

        /// <summary>
        /// Message show for age input.
        /// </summary>
        public const string MSG_Age = "Age                         :";

        /// <summary>
        /// Message for enter account detalis.
        /// </summary>
        public const string MSG_AccountDetails = "Enter Account Details";

        /// <summary>
        /// Message for enter Investment.
        /// </summary>
        public const string MSG_InvestMent = "Investment                  :";

        /// <summary>
        /// Message for enter HomeLoan.
        /// </summary>
        public const string MSG_HomeLoan = "HomeLoan/Rent               :";

        /// <summary>
        /// Message for choice yes.
        /// </summary>
        public const string DEF_Capital_Y = "Y";

        /// <summary>
        /// Message for choice no.
        /// </summary>
        public const string DEF_Capital_N = "N";

        /// <summary>
        /// Message show when user enter invalid input.
        /// </summary>
        public const string ERR_InvalidDataError = "Enter Valid Data";

        /// <summary>
        /// Message show for program recontinue.
        /// </summary>
        public const string MSG_ProgramContinue = "Would You Like To Continue[Y/N]";

        /// <summary>
        /// Message show for ending line.
        /// </summary>
        public const string MSG_EndLine = "__________________________________________________________________________________________________";

        /// <summary>
        /// Message show for thank you at the time of program exit.
        /// </summary>
        public const string MSG_ThankYou = "Thank You Program Is Exit!!";

        /// <summary>
        /// Message show for Payable tax amount.
        /// </summary>
        public const string MSG_PayableAmount = "Payble Tax Amount           : ";

        /// <summary>
        /// Message show for taxableincome.
        /// </summary>
        public const string MSG_TaxableIncome = "TaxbleIncome Amount         : ";

        /// <summary>
        /// variable for check date format.
        /// </summary>
        public const string MSG_DateFormat = "dd-MM-yyyy";

        /// <summary>
        /// Variable for startline show.
        /// </summary>
        public const string MSG_StartLine = "*******************************************************************************************************";

        /// <summary>
        /// Message show title of program.
        /// </summary>
        public const string MSG_ProgramName = "TaxCalculator";

        /// <summary>
        /// message show when result of program.
        /// </summary>
        public const string MSG_Result = "TaxCalCulation Result:";

        /// <summary>
        /// Message show for firstline.
        /// </summary>
        public const string MSG_FirstTitleLine = "__________________________________________________________________________________";

        /// <summary>
        /// Message show when home loan amount is more then income.
        /// </summary>
        public const string ERR_MoreHomeLoan = "HomeloanAmount is not more than income";

        /// <summary>
        /// Message show when invest amount is more then income.
        /// </summary>
        public const string ERR_GreaterInvestment = "InvestAmount is not more than income";

        /// <summary>
        /// User enter more than limit age.
        /// </summary>
        public const string ERR_AgeValid = "Age Is More Than Limit Program Is Exit";

        /// <summary>
        /// Maximum age limit of person.
        /// </summary>
        public const int DEF_MaxAgeLimit = 118;

        /// <summary>
        /// Maximum loop range.
        /// </summary>
        public const int DEF_MaxLoopRange = 3;

        #endregion
    }
}
