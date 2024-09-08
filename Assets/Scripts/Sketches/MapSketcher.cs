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

        public override void SketchToScene(ISketch sketch)
        {
            terrainsSketcher.SketchToScene(((IMapSketch)sketch).TerrainsSketch);
        }

        #endregion

        #region MapSketcher

        [SerializeField] private TerrainsSketcher terrainsSketcher;

        #endregion
    }
}