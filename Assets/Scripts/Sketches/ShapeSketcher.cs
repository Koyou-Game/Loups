using Sketches.Entities;

namespace Sketches
{
    public class ShapeSketcher : PlacementSketcher
    {
        public override ISketch ToSketch()
        {
            return new ShapeSketch();
        }
    }
}