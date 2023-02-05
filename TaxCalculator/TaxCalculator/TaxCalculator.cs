namespace TaxCalculator
{
    /// <summary>
    /// TaxCalcultor class used For Calculation Of TaxableIncome And TaxOnTaxble Income.
    /// </summary>
    public class TaxCalculator
    {
        #region PublicMethod

        /// <summary>
        /// Method for calculate taxable income.
        /// </summary>
        /// <param name="income"> Income of user.</param>
        /// <param name="invest"> Investment of user.</param>
        /// <param name="homeLoan"> Home loan investment of user.</param>
        /// <returns> TaxAmount.</returns>
        public double CalculateTaxableIncome(double income, double invest, double homeLoan)
        {
            double taxAmount;
            double taxableIncome = income - (invest + homeLoan);
            double taxableHomeLoan = homeLoan * Constant.DEF_HomeLoanPercentage;

            if (invest <= Constant.DEF_InvestMentRange)
            {
                taxAmount = taxableIncome + taxableHomeLoan;
                return taxAmount;
            }

            double taxableInvest = invest - Constant.DEF_InvestMentRange;
            taxAmount = taxableIncome + taxableHomeLoan + taxableInvest;
            return taxAmount;
        }

        /// <summary>
        /// Merthod is used for calculate tax on taxable amount.
        /// </summary>
        /// <param name="taxbleAmount"> It is used to calculate taxon income.</param>
        /// <param name="lowerRange"> It used for lower range of slab.</param>
        /// <param name="lowerInterset"> It is used for lowerinterset of slab.</param>
        /// <param name="higherInterest"> It is used for higherinterset of slab.</param>
        /// <returns> Tax.</returns>
        public double TaxOnIncome(double taxbleAmount, double lowerRange, double lowerInterset, double higherInterest)
        {
            double tax = 0;
            double actualIncome = 0;

            // If else if block are used to calculate taxonincome accorroding to slab
            if (taxbleAmount <= lowerRange)
            {
                tax = 0;
            }
            else if (taxbleAmount >= lowerRange && taxbleAmount <= Constant.DEF_SlabMiddleRange)
            {
                actualIncome = taxbleAmount - lowerRange;
                tax = (Constant.DEF_TenPercentageInterest * actualIncome);
            }
            else if (taxbleAmount >= Constant.DEF_SlabMiddleRange && taxbleAmount <= Constant.DEF_SlabHigherRange)
            {
                actualIncome = taxbleAmount - Constant.DEF_SlabMiddleRange;
                tax = lowerInterset + (Constant.DEF_TwentyPercentageInterest * actualIncome);
            }
            else
            {
                actualIncome = taxbleAmount - Constant.DEF_SlabHigherRange;
                tax = higherInterest + (Constant.DEF_ThirtyPercentageInterest * actualIncome);
            }

            return tax;
        }

        #endregion
    }
}
