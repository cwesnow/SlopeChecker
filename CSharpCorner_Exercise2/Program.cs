using System;

namespace CSharpCorner_Exercise2
{
    class Program
    {
        static void Main()
        {
            setup();

            // Original Requirement for 3x points
            //Slopes.addPoint();
            //Slopes.addPoint();
            //Slopes.addPoint();

            // This allows variable amounts of inputs, and uses getInt to set a min and max range for it.
            Slopes.addPoints( Input.getInt("How many points?", 2, 5) );
            
            
            // Display all entered Points - User gets a final look at the data before it's checked
            Console.Clear();
            Console.WriteLine(Slopes.outputString());

            Input.Pause();
            Console.Clear();

            Console.WriteLine("Performing Line check");
            // Slope check - Throws errors, display useful message
            try
            {
                if (Slopes.isSameLine()) { 
                    Console.WriteLine("All points are on the same line."); }
                else {
                    Console.WriteLine("Points are not on the same line."); }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Undefined line, Failed vertical line test");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Error: Requires 2 points to find a slope.");
            }
            catch (Exception e)
            {
                Console.WriteLine( "Error: {0}", e.Message );
            }

            Input.Pause();
        }

        static void setup()
        {
            string name = "Line Checker";
            Console.Title = name;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Welcome to the {0}!\n\n\tEnter a few points, and we'll find the line(s)", name);
        }
    }
}
