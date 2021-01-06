using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Square implementation class
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        ///
        ///     Gets formula for the area of the rectangle as a string.
        /// </summary>
        ///
        public new static string AreaFormula => "a×a";

        /// <summary>
        ///     Gets formula for the perimeter of the rectangle as a string.
        /// </summary>
        public new static string PerimeterFormula
        {
            get
            {
                return "4×a";
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        /// <param name="side1">side square</param>
        public Square(double side1)
            : base(side1)
        {
        }
    }
}