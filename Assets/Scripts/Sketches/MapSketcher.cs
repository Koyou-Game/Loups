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
                InteractionsSketch = (IInteractionsSketch)interactionsSketcher.SceneToSketch()
            };
        }

        public override void SketchToScene(ISketch sketch)
        {
            terrainsSketcher.SketchToScene(((IMapSketch)sketch).TerrainsSketch);
            interactionsSketcher.SketchToScene(((IMapSketch)sketch).InteractionsSketch);
        }

        #endregion

        #region MapSketcher

        [SerializeField] private TerrainsSketcher terrainsSketcher;
        [SerializeField] private InteractionsSketcher interactionsSketcher;

        #endregion
    }
}