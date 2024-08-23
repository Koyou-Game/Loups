namespace Sketches.Entities
{
    public interface IShapeSketch : IPlacementSketch { }

    public class ShapeSketch : PlacementSketch, IShapeSketch { }
}