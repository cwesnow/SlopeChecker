using System;

namespace CSharpCorner_Exercise2
{
    class Program
    {
        static void Main()
        {

            setup();

            // Add # of points based on user input, Ranging from 2 to 5
            Slopes.addPoints( Input.getInt("How many points?", 2, 5) );
            
            // Display current points
            Console.WriteLine(Slopes.outputString());

            // Slope check - Throws errors, display useful message
            try
            {
                if (Slopes.isSameLine()) { 
                    Console.WriteLine("All points are on the same line."); }
                else {
                    Console.WriteLine("Points are not on the same line."); }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Error: Requires 2 points to find a slope.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Undefined line, Failed vertical line test");
            }
            catch (Exception e)
            {
                Console.WriteLine( e.Message );
            }
            finally
            {
                // Pause
                Console.WriteLine("Press any key to exit . . .");
                Console.ReadKey();
            }
        }

        static void setup()
        {
            Console.Title = "Slope Checker";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}
