using System.Collections.Generic;

namespace Sketches.Entities
{
    public interface ITerrainsSketch : IPlacementSketch
    {
        List<ISketch> Sketches { get; init; }
    }
    public class TerrainsSketch : PlacementSketch, ITerrainsSketch
    {
        public List<ISketch> Sketches { get; init; }
    }
}