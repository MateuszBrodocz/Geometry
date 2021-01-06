using Codecool.Geometry.Shapes;

namespace Codecool.Geometry
{
    /// <summary>
    ///     This is the main class of your program which contains Main method
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     This is the entry point of your program.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            bool isRunning = true;
            RegularPentagon regularPentagon = new RegularPentagon(2);
            double area = regularPentagon.Area;
            while (isRunning)
            {
                int option = 0;  // TODO read the keyboard here

                switch (option)
                {
                    case 1:
                        // TODO Add new shape
                        break;
                    case 2:
                        // TODO Show all shapes
                        break;
                    case 3:
                        // TODO Show shape with the largest perimeter
                        break;
                    case 4:
                        // TODO Show shape with the largest area
                        break;
                    case 5:
                        // TODO Show formulas
                        break;
                    case 0:
                        // TODO Exit
                        break;
                        Shape.CheckIfArgsAreGreaterThanZero();
                }
            }
        }
    }
}
