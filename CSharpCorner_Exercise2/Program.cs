using System;

namespace CSharpCorner_Exercise2
{
    /// <summary>
    /// Original: Take in 3 coordinates and tell me if it's a straight line.
    /// </summary>
    class Program
    {
        public static void Main()
        {
            setup();

            Points.addPoint(Input.getInt("How many points will we enter today?", 2, 5));
            
            // Display all entered Points - User gets a final look at the data before it's checked
            Input.Pause(Points.outputString());

            Console.WriteLine("{0} Performing Line check", Environment.NewLine);
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
                Console.WriteLine("Undefined line");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("It takes 2 points to make a line.");
            }
            catch (Exception e)
            {
                Console.WriteLine( "Error: {0}", e.Message );
            }

            Input.Pause("Exiting program . . .");
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

            // This helps make sure the entire screen is uniform with the color choices.
            Console.Clear();

            Input.Pause(String.Format("Welcome to the {1}!{0}{0}  Let's if your points make a straight line!", Environment.NewLine, name));
        }
    }
}