namespace TaxCalculator
{
    /// <summary>
    /// MenSlab for calculation of men income and tax for men.
    /// </summary>
    internal class MenSlab : TaxCalculator
    {
        #region PublicMethod
    
        /// <summary>
        /// Method for calculate taxable income.
        /// </summary>
        /// <param name="income"> Income of user.</param>
        /// <param name="invest"> Invest of user.</param>
        /// <param name="homeLoan"> Home invest of user.</param>
        /// <returns> Taxableamount.</returns>
        public new double CalculateTaxableIncome(double income, double invest, double homeLoan)
        {
            return base.CalculateTaxableIncome(income, invest, homeLoan);
        }

        /// <summary>
        /// Method used for calculate tax on taxable amount.
        /// </summary>
        /// <param name="taxbleAmount"> Taxable amount pass for calculate womentax on income.</param>
        /// <param name="MenSlabLowerRange"> It used for men slab lower range.</param>
        /// <param name="MenSlabInterset"> It is used for men midinterset rate.</param>
        /// <param name="MenAllSlabInterset"> It is used for men overall interset.</param>
        /// <returns> Tax.</returns>
        public double TaxOnIncome(double taxbleAmount)
        {
            return base.TaxOnIncome(taxbleAmount, Constant.DEF_MenSlabLowerRange, Constant.DEF_MenSlabFirstInterest, Constant.DEF_MenSlabSecondInterset);
        }

        #endregion
    }
}
