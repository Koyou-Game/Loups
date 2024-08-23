namespace Sketches.Entities
{
    public interface IPlacementSketch : ISketch { }

    public abstract class PlacementSketch : Sketch, IPlacementSketch { }
}