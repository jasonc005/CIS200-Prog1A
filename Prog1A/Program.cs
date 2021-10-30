/**
 * Student ID: 1778666
 * Program #: 1A
 * Due Date: 9/27/21
 * Course Section: 50
 * Description: Simple test program for Parcel classes
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog1A
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ", 
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", 
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", 
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            //Letter l1 = new Letter(a1, a3, 0.50M); // Test Letter 1
            //Letter l2 = new Letter(a2, a4, 1.20M); // Test Letter 2
            //Letter l3 = new Letter(a4, a1, 1.70M); // Test Letter 3

            GroundPackage gp1 = new GroundPackage(a1, a2, 12, 34, 5, 20);
            NextDayAirPackage ndap1 = new NextDayAirPackage(a3, a4, 36, 37, 38, 80, 8.35M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a2, a3, 12, 24, 6, 14, TwoDayAirPackage.Delivery.Saver);

            List<Parcel> parcels = new List<Parcel> { gp1, ndap1, tdap1 }; // Test list of parcels

            // Display data
            WriteLine("Program 1A - List of Parcels\n");

            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("--------------------");
            }

            ReadLine();
        }
    }
}
