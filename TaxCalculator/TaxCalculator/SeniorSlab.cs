namespace TaxCalculator
{
    /// <summary>
    /// SeniorSlab class for calculation of taxble amount and tax on taxble amount for Senior's.
    /// </summary>
    internal class SeniorSlab : TaxCalculator
    {
        #region PublicMethod

        /// <summary>
        /// Method for calculate taxable income.
        /// </summary>
        /// <param name="income"> Income of user.</param>
        /// <param name="invest"> Invest of user.</param>
        /// <param name="homeLoan"> Home invest of user.</param>
        /// <returns> TaxableAmount.</returns>
        public new double CalculateTaxableIncome(double income, double invest, double homeLoan)
        {
            return base.CalculateTaxableIncome(income, invest, homeLoan);
        }

        /// <summary>
        /// Method Used for calculate tax on taxable amount.
        /// </summary>
        /// <param name="taxbleAmount"> Taxable amount pass for calculate womentax on income.</param>
        /// <param name="SeniorSlabLowerRange"> It used for women slab lower range.</param>
        /// <param name="SeniorSlabInterset"> It is used for women midinterset rate.</param>
        /// <param name="SeniorAllSlabInterset"> It is used for women overall interset.</param>
        /// <returns> Tax.</returns>
        public double TaxOnIncome(double taxbleAmount)
        {
            return base.TaxOnIncome(taxbleAmount, Constant.DEF_SeniorSlablowerRange, Constant.DEF_SeniorFirstInterset, Constant.DEF_SeniorSlabSecondInterset);
        }

        #endregion
    }
}