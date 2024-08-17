namespace Uso_de_interface.Services
{
    internal class BrazilTaxServices : ITaxService
    {
        public double Tax(double amount)
        {
            if(amount <= 100)
            {
                return amount * 0.02;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
