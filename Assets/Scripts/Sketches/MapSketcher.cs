using Sketches.Entities;
using UnityEngine;

namespace Sketches
{
    public class MapSketcher : PlacementSketcher
    {
        #region PlacementSketcher

        public override ISketch ToSketch()
        {
            return new MapSketch
            {
                TerrainsSketch = (ITerrainsSketch)terrainsSketcher.ToSketch(),
            };
        }

        #endregion

        #region MapSketcher

        [SerializeField] private TerrainsSketcher terrainsSketcher;

        #endregion
    }
}