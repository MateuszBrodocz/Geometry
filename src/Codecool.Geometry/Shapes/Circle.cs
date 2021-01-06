using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Circle implementation class
    /// </summary>

    public class Circle : Shape
    {
        /// <summary>
        ///     Gets formula for the area of the circle as a string.
        /// </summary>
        public new static string AreaFormula
        {
            get
            {
                return " π×r×r";
            }
        }

        /// <summary>
        ///     Gets formula for the perimeter of the circle as a string.
        /// </summary>
        public new static string PerimeterFormula => "2×π×r";

        /// <inheritdoc />
        public override double Area
        {
            get
            {
                return 3.14 * (Radius * Radius);
            }
        }

        /// <inheritdoc />
        public override double Perimeter
        {
            get
            {
                return 2 * 3.14 * Radius;
            }
        }

        /// <summary>
        /// gets radius of circlet
        /// </summary>
        private double Radius { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">Radius of Circle</param>
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
