/*
 * Program.cs
 * 
 * Version information
 * 
 * Author: Dylan Corry
 * Date: 02/01/2021 
 * Description: This is a simple  console unit converted program that can convert two numerical values from metric units into imperial units, using C#. Currently, you are inside the Driver of the program.
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
    class Program
    {
        static void Main(string[] args)
        { // start of main()

            /* Program Flow :
             * 
             * Start
             * 
             * User enter from units
             * 
             * User enters from value
             * 
             * User enters to units
             * 
             * Result is printed
             * 
             * Check if user wants to quit
             * 
             * End
             */

            UI ui = new UI(); // instantiate UI
            Units unit = new Units(); // instantiate Units

            // while loop for flow
            var y = "y";
            while (ui.getUserWantToQuit != y)
            {
                ui.Greeting();
                unit.convertMetricToImperial(ui.userFromChoice, ui.userToChoice, ui.userFromValue);
                unit.PrintResult(ui.userToChoice);
                // function to check if user wants to exit
                ui.ShouldConsoleExit();
            }


           

        } // end of main()
    }
}
/*
 * while (ui.getUserWantToQuit !== " y ")
 * {
 *          ui.Greeting();
            unit.convertMetricToImperial(ui.userFromChoice, ui.userToChoice, ui.userFromValue);
            unit.PrintResult(ui.userToChoice);
            // function to check if user wants to exit
            ui.ShouldConsoleExit();
 * }
 */