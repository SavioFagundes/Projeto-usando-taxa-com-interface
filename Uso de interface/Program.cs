using System.Globalization;
using Uso_de_interface.Entities;
using Uso_de_interface.Services;
namespace Uso_de_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();
            Console.WriteLine("PickUp (dd/mm/yyyy hh:mm: ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/mm/yyyy hh:mm: ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            CarRental carental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalservice = new RentalService(hour, day, new BrazilTaxServices());
            rentalservice.ProcessInvoice(carental);
            Console.WriteLine("Invoice: ");
            Console.WriteLine(carental.Invoice);
        }
    }
}