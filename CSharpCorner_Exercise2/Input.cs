using System;

namespace CSharpCorner_Exercise2
{
    class Input
    {
        /// <summary>
        /// Press Any Key to continue by default, allows custom message to be passed in
        /// </summary>
        internal static void Pause(String prompt = "Press any key to continue . . .")
        {
            Console.WriteLine(prompt);
            Console.ReadKey();
        }

        /// <summary>
        /// Allows for user input with a custom prompt that allows a minimum and maximum number range to be returned
        /// </summary>
        /// <param name="prompt">Console output for user</param>
        /// <param name="minimum">Smallest value allowed</param>
        /// <param name="maximum">Largest value allowed</param>
        /// <returns></returns>
        internal static int getInt(string prompt, int minimum, int maximum)
        {
            int x;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out x) || x < minimum || x > maximum)
                Console.WriteLine("Error: Number must be between {0} and {1}", minimum, maximum);
            return x;
        }

        /// <summary>
        /// User enters X and Y values then returns Point
        /// </summary>
        /// <param name="pointNumber"></param>
        /// <returns></returns>
        internal static Point getPoint(int pointNumber)
        {
            Console.WriteLine("{0}Creating Point {1}", Environment.NewLine, pointNumber);

            Point point;
            point.x = getInt("  X-coordinate >>> ", -100, 100);
            point.y = getInt("  Y-coordinate >>> ", -100, 100);

            // Check for correct input, before returning new values
            Console.Write("Add Point ({1},{2})? [Y,N] ", pointNumber, point.x, point.y);
            if ( Console.ReadLine().Substring(0, 1).ToUpper() != "Y") point = getPoint(pointNumber);
            return point;
        }
    }
}
