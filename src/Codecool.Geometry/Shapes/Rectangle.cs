using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Rectangle implementation class
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        ///     Gets formula for the area of the rectangle as a string.
        /// </summary>
        public new static string AreaFormula => "Area =a * b";

        /// <summary>
        ///     Gets formula for the perimeter of the rectangle as a string.
        /// </summary>
        public new static string PerimeterFormula => "Perimeter =a * 2 + b * 2";

        /// <inheritdoc />
        public override double Area => Side1 * Side2;

        /// <inheritdoc />
        public override double Perimeter => (Side1 * 2) + (Side2 * 2);

        private double Side1 { get; }

        private double Side2 { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="side1">Side1 Rectangle</param>
        /// <param name="side2">Side2 Rectangle</param>
        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="side1">side Rectangle if value of all is the same </param>
        public Rectangle(double side1)
        {
            Side1 = side1;
            Side2 = side1;
        }
    }
}
