using Sketches.Entities;
using UnityEngine;

namespace Sketches
{
    public class MapSketcher : PlacementSketcher
    {
        #region PlacementSketcher

        public override ISketch SceneToSketch()
        {
            return new MapSketch
            {
                TerrainsSketch = (ITerrainsSketch)terrainsSketcher.SceneToSketch(),
            };
        }

        #endregion

        #region MapSketcher

        [SerializeField] private TerrainsSketcher terrainsSketcher;

        #endregion
    }
}