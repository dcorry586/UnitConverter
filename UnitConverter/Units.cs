/*
 * Units.cs
 * 
 * Version information
 * 
 * Author: Dylan Corry
 * Date: 02/01/2021 
 * Description: Class for the the conversion of units (Metric to Imperial).
 * 
 * Copyright notice
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Units
    {
        private double Result = 00.00;

        public void convertMetricToImperial(string fromChoice, string toChoice, double fromValue) // in Program.cs (THE DRIVER) insert the properties inplace of the paramters for the this function
        { // start of method
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
                Result = fromValue * 2.20462;
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
        } // end of method

        public void PrintResult()
        {
            Console.WriteLine(Result.ToString("N2"));
        }
    }
}
