using System;

namespace CSharpCorner_Exercise2
{
    /// <summary>
    /// Original: Take in 3 coordinates and tell me if it's a straight line.
    /// </summary>
    class Program
    {
        static void Main()
        {
            setup();

            // This allows variable amounts of inputs, and uses getInt to set a min and max range for it.
            Points.addPoints( Input.getInt("\n How many (X,Y) points will you enter?", 2, 9) );
            
            
            // Display all entered Points - User gets a final look at the data before it's checked
            Console.WriteLine(Points.outputString());
            Input.Pause();

            Console.WriteLine("\n Performing Line check");
            // Slope check - Throws errors, displays useful user messages
            try
            {
                if (Points.isSameLine()) { 
                    Console.WriteLine("It made a Straight Line."); }
                else {
                    Console.WriteLine("It didn't make a Straight Line."); }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Undefined line");
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

        /// <summary>
        /// Sets Title, foreground, background, and displays Welcome Text
        /// </summary>
        static void setup()
        {
            string name = "Line Checker";
            Console.Title = name;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Welcome to the {0}!\n\n\tLet's figure out if your points make a straight line!", name);
            Input.Pause();
        }
    }
}
