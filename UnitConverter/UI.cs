/*
 * UI.cs
 * 
 * Version information
 * 
 * Author: Dylan Corry
 * Date: 02/01/2021 
 * Description: Class for the console applciations's user interface.
 * 
 * Copyright notice
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{ // namespace start
    class UI
    { // class UI start

        private string fromChoice;
        private double fromValue = 00.00;
        private string toChoice;
        public void Greeting()
        {
            // from
            Console.WriteLine("Welcome to the console metric to imperial unit  converter.");
            Console.WriteLine("\n");
            Console.WriteLine("Enter the desired unit by typing the characters representing that unit inside the ( ).\n" + "For example : (mm). You type 'mm '.\n");
            Console.WriteLine("Milimetres (mm) \n" + "Centimetres (cm) \n" + "Metres (m) \n" + "Kilograms (kg) \n" + "Celsius (c) \n" + "Mililitres (ml)\n" + "Litres (l)\n" + "Kilometres (km)\n"); // from units
            fromChoice = Console.ReadLine();
            Console.WriteLine("From : " + fromChoice);

            Console.WriteLine("Enter numerical value: ");
            fromValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Value = " + fromValue);

            // to
            Console.WriteLine("Imperial Units To Convert Metric To : \n");
            Console.WriteLine("Enter the desired unit by typing the characters representing that unit inside the ( ).\n" + "For example : (ft). You type ' ft '.\n");
            Console.WriteLine("Inch (i) \n" + "Feet (ft) \n" + "Yard (y) \n" + "Pound (lbs) \n" + "Fahrenheit (f) \n" + "Ounces (oz)\n" + "Pint (pts)\n" + "Gallons (gal) \n" + "Miles (mile) \n"); // from units
            toChoice = Console.ReadLine();
            Console.WriteLine("To : " + toChoice);
        }
        // string fromChoice - filed
        // public string userFromChoice - property
        public string userFromChoice // so this property can be accessed inside Units class!
        {
            get { return fromChoice; }
            set { fromChoice = value; }
        }

        public double userFromValue
        {
            get { return fromValue; }
            set { fromValue = value; }
        }

        // toChoice
        public string userToChoice
        {
            get { return toChoice; }
            set { toChoice = value; }
        }


    } // class UI end
} // namespace end
