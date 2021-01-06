using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Triangle implementation class
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public new static string AreaFormula => "sqrt(s×(s - a)×(s - b)×(s - c))";

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string PerimeterFormula => "Permimeter= a + b + c";

        /// <inheritdoc/>
        public override double Perimeter => SideA + SideB + SideC;

        /// <inheritdoc/>
        public override double Area => Math.Sqrt(SValue * ((SValue - SideA) * (SValue - SideB) * (SValue - SideC)));

        /// <summary>
        /// Gets S value (SideA + SideB + SideC) / 2)
        /// For Area Formula
        /// </summary>
        public double SValue => (SideA + SideB + SideC) / 2;

        private double SideA { get; }

        private double SideB { get; }

        private double SideC { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="sideA">Side Triangle</param>
        /// <param name="sideB">Side TriangleB</param>
        /// <param name="sideC">Side TriangleC</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="sideA">Side A if triangle have all sideA the same</param>
        public Triangle(double sideA)
        {
            SideA = sideA;
            SideB = sideA;
            SideC = sideA;
        }
    }
}
