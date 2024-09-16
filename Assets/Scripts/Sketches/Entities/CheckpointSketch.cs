namespace Sketches.Entities
{
    public interface ICheckpointSketch : IPlacementSketch { }

    public class CheckpointSketch : PlacementSketch, ICheckpointSketch { }
}