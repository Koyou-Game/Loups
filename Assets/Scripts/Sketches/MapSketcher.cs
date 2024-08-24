using Sketches.Entities;

namespace Sketches
{
    public class MapSketcher : PlacementSketcher
    {
        public override ISketch ToSketch() => new MapSketch();
    }
}