using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Regular Pentagon implementation class
    /// </summary>
    public class RegularPentagon : Shape
    {
        /// <summary>
        ///     Gets formula for the area of the pentagon as a string.
        /// </summary>
        public new static string AreaFormula => "a×a×sqrt(5×(5+2×sqrt(5))/4";

        /// <summary>
        ///     Gets formula for the perimeter of the pentagon as a string.
        /// </summary>
        public new static string PerimeterFormula => "5×a";

        /// <inheritdoc/>
        public override double Area => Side * 5;

        /// <inheritdoc/>
        public override double Perimeter => Side * Side * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) / 4;

        private double Side { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegularPentagon"/> class.
        /// </summary>
        /// <param name="side">Side of RegularPentagon</param>
        public RegularPentagon(double side)
        {
            Side = side;
        }
    }
}
