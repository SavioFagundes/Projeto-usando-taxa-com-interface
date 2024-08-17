﻿using System.Globalization;
namespace Uso_de_interface.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double totalPayment
        {
            get { return BasicPayment + Tax; }

        }
        public override string ToString()
        {
            return "Basic payment: " +
                BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + totalPayment.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
