using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Equilateral Triangle implementation class
    /// </summary>
    public class EquilateralTriangle : Triangle
    {
        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public new static string AreaFormula => "a×a×sqrt(3)/4";

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string PerimeterFormula => "3×a";

        /// <summary>
        /// Initializes a new instance of the <see cref="EquilateralTriangle"/> class.
        /// </summary>
        /// <param name="sideA">Side EquilateralTriangle</param>
        public EquilateralTriangle(double sideA)
            : base(sideA)
        {
        }
    }
}
