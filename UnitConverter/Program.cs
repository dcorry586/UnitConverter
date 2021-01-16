/*
 * Program.cs
 * 
 * Version information
 * 
 * Author: Dylan Corry
 * Date: 02/01/2021 
 * Description: This is a simple  console unit converted program that can convert two numerical values from metric units into imperial units, using C#.
 * 
 * Copyright notice
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // enter cm
            Console.WriteLine("Enter units in CM : ");
            double cmToInch = Convert.ToDouble(Console.ReadLine());
            double convertToInch = (cmToInch * 2.5);
            Console.WriteLine("Conversion Result = " + convertToInch + " " + "Inches");
            
        }
    }
}
