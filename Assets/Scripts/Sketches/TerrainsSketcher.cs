using Sketches.Entities;

namespace Sketches
{
    public class TerrainsSketcher : PlacementSketcher
    {
        public override ISketch ToSketch() => new TerrainsSketch();
    }
}