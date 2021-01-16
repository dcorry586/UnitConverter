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
            // from 
            Console.WriteLine("Metric Units To Choose From : \n");
            Console.WriteLine("Enter the desired unit by typing the characters representing that unit inside the ( ).\n" + "For example : (mm). You type 'mm '.\n");
            Console.WriteLine("Milimetres (mm) \n" + "Centimetres (cm) \n" + "Metres (m) \n" + "Kilograms (kg) \n" + "Celsius (c) \n" + "Mililitres (ml)\n" + "Litres (l)\n" + "Kilometres (km)\n"); // from units
            string fromChoice = Console.ReadLine();
            Console.WriteLine("From : " + fromChoice);
            
            Console.WriteLine("Enter numerical value: ");
            double fromValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Value = " + fromValue);

            // to 
            Console.WriteLine("Imperial Units To Convert Metric To : \n");
            Console.WriteLine("Enter the desired unit by typing the characters representing that unit inside the ( ).\n" + "For example : (ft). You type ' ft '.\n");
            Console.WriteLine("Inch (i) \n" + "Feet (ft) \n" + "Yard (y) \n" + "Pound (lbs) \n" + "Fahrenheit (f) \n" + "Ounces (oz)\n" + "Pint (pts)\n" + "Gallons (gal) \n" + "Miles (mile) \n"); // from units
            string toChoice = Console.ReadLine();
            Console.WriteLine("To : " + toChoice);

            // switch statement to do math - Convert(X,y) = Result : ...

            // if to = i; from * 2.5
            double Result = 00.00;

           if (fromChoice == "mm" && toChoice == "i") 
            {
                Result = fromValue * 0.0393701;
            }
           if (fromChoice == "mm" && toChoice == "ft")
            {
                Result = fromValue * 0.00328084;
            }
           if (fromChoice == "mm" && toChoice == "y")
            {
                Result = fromValue * 0.00109361;
            }
           if (fromChoice == "cm" && toChoice == "i")
            {
                Result = fromValue * 0.393701;
            }
            if (fromChoice == "cm" && toChoice == "ft")
            {
                Result = fromValue * 0.0328084;
            }
            if (fromChoice == "cm" && toChoice == "y")
            {
                Result = fromValue * 0.0109361;
            }
            if (fromChoice == "m" && toChoice == "i")
            {
                Result = fromValue * 39.3701;
            }
            if (fromChoice == "m" && toChoice == "ft")
            {
                Result = fromValue * 3.280841666667;
            }
            if (fromChoice == "m" && toChoice == "y")
            {
                Result = fromValue * 1.09361;
            }
            if (fromChoice == "m" && toChoice == "mile")
            {
                Result = fromValue * 0.000621371;
            }
            if (fromChoice == "km" && toChoice == "mile")
            {
                Result = fromValue * 0.621371;
            }
            if (fromChoice == "kg" && toChoice == "lbs")
            {
                Result = fromValue * 2.20462 ;
            }
            if (fromChoice == "kg" && toChoice == "oz")
            {
                Result = fromValue * 35.274;
            }
            if (fromChoice == "kg" && toChoice == "pts")
            {
                Result = fromValue * 0.473176475;
            }
            if (fromChoice == "kg" && toChoice == "gal")
            {
                Result = fromValue * 0.264172053;
            }
            if (fromChoice == "c" && toChoice == "f")
            {
                Result = (fromValue * 9 / 5) + 32; // (0°C × 9/5) + 32 = 32°F
            }
            if (fromChoice == "ml" && toChoice == "oz")
            {
                Result = fromValue * 0.0351951;
            }
            if (fromChoice == "ml" && toChoice == "pts")
            {
                Result = fromValue * 0.00175975;
            }
            if (fromChoice == "ml" && toChoice == "gal")
            {
                Result = fromValue * 0.000219969;
            }
            if (fromChoice == "l" && toChoice == "oz")
            {
                Result = fromValue * 35.1951;
            }
            if (fromChoice == "l" && toChoice == "pts")
            {
                Result = fromValue * 1.75975;
            }
            if (fromChoice == "l" && toChoice == "gal")
            {
                Result = fromValue * 0.264172;
            }

            Console.WriteLine(Result);
        }
    }
}
