using UnityEngine;

namespace Sketches.Entities
{
    public interface IPlacementSketch : ISketch
    {
        Vector3 Position { get; init; }
    }

    public abstract class PlacementSketch : Sketch, IPlacementSketch
    {
        public Vector3 Position { get; init; }
    }
}