using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorner_Exercise2
{
    class Slopes
    {
        internal static List<Point> points = new List<Point>();

        public static void addPoints(int numberOfPoints)
        {
            // Collection of Slope inputs
            for (int x = 0; x < numberOfPoints; x++)
            {
                addPoint();
            }
        }
        
        public static void addPoint(){
            points.Add( Input.getPoint(points.Count+1) );
        }

        public static string outputString()
        {
            var sb = new StringBuilder("");
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
        public static bool isSameLine()
        {
            if (points.Count < 2) throw new ArgumentOutOfRangeException();

            double division = points[1].x - points[0].x;
            if (division == 0) { throw new DivideByZeroException(); }

            // Slope of point 0 and 1
            double Slope1 = (points[1].y - points[0].y) / division;

            // Iterates through each Point.
            for (int i = 0; i < points.Count - 1; i++)
            {
                double Slope2 = (points[i + 1].y - points[i].y) / (points[i + 1].x - points[i].x);
                if (Slope2 != Slope1) return false;
            }

            return true;
        }

    }
}