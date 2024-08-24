using Sketches.Entities;
using UnityEngine;

namespace Sketches
{
    public class MapSketcher : PlacementSketcher
    {
        #region PlacementSketcher

        public override ISketch ToSketch() => new MapSketch();

        #endregion

        #region MapSketcher

        [SerializeField] private TerrainsSketcher terrainsSketcher;

        #endregion
    }
}