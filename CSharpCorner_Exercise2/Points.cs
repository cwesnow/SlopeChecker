using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorner_Exercise2
{
    class Points
    {
        static List<Point> points = new List<Point>();

        /// <summary>
        /// Loops X times adding a point to the collection of points
        /// </summary>
        /// <param name="numberOfPoints"></param>
        public static void addPoints(int numberOfPoints)
        {
            // Collection of Slope inputs
            for (int x = 0; x < numberOfPoints; x++)
            {
                addPoint();
            }
        }
        
        /// <summary>
        /// Adds 1 Point to the collection of points
        /// </summary>
        public static void addPoint(){
            points.Add( Input.getPoint(points.Count+1) );
        }

        /// <summary>
        /// Output String that represents collection of points
        /// </summary>
        /// <returns>String</returns>
        public static string outputString()
        {
            var sb = new StringBuilder("\n Points List\n~~~~~~~~~~~~~\n");
            int count = 0;

            // Output each Slopes Points and Slope
            foreach (var point in points)
            {
                count++;
                sb.AppendFormat("Point {0} ({1},{2}){3}", count, point.x, point.y, Environment.NewLine);
            }
            return sb.ToString();
        }


        // Slope = delta y over delta x OR ( y2 - y1 ) / (x2 - x1)

        /// <summary>
        /// Checks if all points are on the same line using the slope formula
        /// </summary>
        /// <returns>bool</returns>
        public static bool isSameLine()
        {
            // Can't make a slope without 2 points
            if (points.Count < 2) throw new ArgumentOutOfRangeException();

            // Any 2 points will always create a straight line
            else if (points.Count == 2) return true;

            // Loop from First to 2nd from Last Element
            for (int j = 0; j < points.Count - 1; j++)
            {
                // Initial Slope Point to Point
                double slope1 = slope(points[j], points[j + 1]);

                // Get Slope from Point1 to nextPoint and if different, Not a Straight Line. Return False.
                for (int i = j+2; i < points.Count; i++)
                {
                    double slope2 = slope(points[j], points[i]);
                    if (slope1 != slope2) return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Given 2 points, returns the Slope as a Double
        /// </summary>
        /// <param name="pt1"></param>
        /// <param name="pt2"></param>
        /// <returns></returns>
        public static double slope(Point pt1, Point pt2)
        {
            if (pt2.x - pt1.x == 0) throw new DivideByZeroException();

            return (pt2.y - pt1.y) / (double)(pt2.x - pt1.x);
        }

    }
}