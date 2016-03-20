using System.Linq;

namespace KnockKnockService
{
    internal class Triangle
    {
        /// <summary>
        /// Determines whether a set of 3 sides forms what type of triangle.
        /// </summary>
        /// <param name="firstSide">first side</param>
        /// <param name="secondSide">second side</param>
        /// <param name="thirdSide">third side</param>
        /// <returns></returns>
        public static TriangleType DetermineTriangleShape(int firstSide, int secondSide, int thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                return TriangleType.Error;
            }

            int[] sides = { firstSide, secondSide, thirdSide };

            // invalid shape
            // in a triangle - the sum of any 2 sides must me greater than the third side.
            if (firstSide + secondSide <= thirdSide || secondSide + thirdSide <= firstSide || thirdSide + firstSide <= secondSide)
            {
                return TriangleType.Error;
            }
            // looks like a valid shape
            else
            {
                var numberOfDistinctSides = sides.Distinct().Count();

                // all the sides are equal 
                switch (numberOfDistinctSides)
                {
                    case 1:
                        return TriangleType.Equilateral;
                    case 2:
                        return TriangleType.Isosceles;
                    default:
                        return TriangleType.Scalene;
                }
            }
        }
    }
}