using System.Linq;
using Codecool.Geometry.Shapes;

namespace Codecool.Geometry.Containers
{
    /// <summary>
    ///     Shape Collection class
    /// </summary>
    public class ShapeCollection
    {
        private Shape[] _shapeColection;

        /// <summary>
        /// Add Shape to _shapeColection.
        /// </summary>
        /// <param name="shape">Object class Shape</param>
        public void AddShape(Shape shape)
        {
            Shape[] shapetoadd = new Shape[1];
            shapetoadd[0] = shape;
            _shapeColection = _shapeColection.Union(shapetoadd).ToArray();
        }

        /// <summary>
        /// Get Largest Shape By Permiter.
        /// </summary>
        /// <returns>The bigest Perimiter shape from ShapeCollection._shapeColection</</returns>
        public object GetLargestShapeByPermiter()
        {
            double theBigestPermiter = 0;
            Shape shapeTheBigestPermiterIn_shapeColection = null;
            foreach (Shape shapes in _shapeColection)
            {
                if (shapes.Perimeter > theBigestPermiter)
                {
                    theBigestPermiter = shapes.Perimeter;
                    shapeTheBigestPermiterIn_shapeColection = shapes;
                }
            }

            return shapeTheBigestPermiterIn_shapeColection;
        }

        /// <summary>
        /// Get Largest Shape By Area
        /// </summary>
        /// <returns>The bigest Area shape from ShapeCollection._shapeColection</returns>
        public object GetLargestShapeByArea()
        {
            double theBigestArea = 0;
            Shape shapeTheBigestAreaIn_shapeColection = null;
            foreach (Shape shapes in _shapeColection)
            {
                if (shapes.Perimeter > theBigestArea)
                {
                    theBigestArea = shapes.Perimeter;
                    shapeTheBigestAreaIn_shapeColection = shapes;
                }
            }

            return shapeTheBigestAreaIn_shapeColection;
        }
    }
}
