//Created by: Remedios Meneses
//Student # : 300691712
//Last Mod : July 24, 2020 @ 5:45 PM
//Description: Classes and Interface
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***\tPLANET++DIAMETER++MASS++DESCRIPTION*************************");
            Console.WriteLine();
            GiantPlanet Pluto = new GiantPlanet("Jupiter", 45.55, 20, "Gas");
            Console.WriteLine(Pluto.ToString());
            TerrestrialPlanet Planet = new TerrestrialPlanet("Mars", 21.3, 15, true);
            Console.WriteLine(Planet.ToString());
            Console.WriteLine();
            Console.WriteLine("********************************************************************");
            Console.ReadKey();
            
        }
    }
}
